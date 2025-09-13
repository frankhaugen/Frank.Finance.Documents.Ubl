Got it—here’s a **tight, conceptual spec** for the QuestPDF layer only: how to build clean, reusable **IContainer**-driven components that render **generated UBL types directly** (Invoice/CreditNote/Reminder), with empty-field suppression and minimal duplication.

# QuestPDF Rendering Spec (Concepts & Patterns)

## Core principles

* **Pure components**: functions that take data + an `IContainer` and render. No state, no side-effects.
* **Compose, don’t branch**: small blocks (header meta, parties, lines, totals) composed per doc-type; only tiny per-type deltas.
* **Null = no output**: centralize null/empty checks to avoid `if`s in layout code.
* **Stable grid**: consistent columns/ratios across documents to keep visual rhythm.

---

## 1) Micro-DSL on `IContainer`

Create small extensions that keep templates declarative and suppress empties automatically.

```csharp
// field rows
static void Field(this IContainer c, string label, string? value)
{
    if (string.IsNullOrWhiteSpace(value)) return;
    c.Row(r =>
    {
        r.RelativeColumn(1).Text(label).SemiBold();
        r.RelativeColumn(2).Text(value.Trim());
    });
}

// money + hide nulls
static void Money(this IContainer c, string label, decimal? value, string? currency)
{
    if (value is null) return;
    c.Field(label, currency is null ? $"{value:0.##}" : $"{value:0.##} {currency}");
}

// table cells
static IContainer HCell(this IContainer c) => c.Background("#EEE").PaddingVertical(3).PaddingHorizontal(4).Bold();
static IContainer Cell(this IContainer c)  => c.PaddingVertical(2).PaddingHorizontal(4);

// labeled section (title + content lambda)
static void Section(this IContainer c, string title, Action<IContainer> content)
{
    c.Column(col =>
    {
        col.Item().Text(title).Bold().Size(12);
        col.Item().Element(content);
    });
}

// two-column area with fixed left/right content lambdas
static void TwoCol(this IContainer c, Action<IContainer> left, Action<IContainer> right)
{
    c.Row(r =>
    {
        r.RelativeColumn().Element(left);
        r.RelativeColumn().Element(right);
    });
}
```

> These five are your 90%: `Field`, `Money`, `HCell`, `Cell`, `Section`/`TwoCol`.

---

## 2) Page scaffold (title, header/footer, margins)

Define a single page template; content varies by doc-type.

```csharp
static void BuildPage(this PageDescriptor p, string title, Action<IContainer> body)
{
    p.Margin(36);
    p.Header().Row(r =>
    {
        r.RelativeColumn().Text(title).SemiBold().Size(16);
        r.ConstantColumn(120).AlignRight().Text(DateTime.Now.ToString("yyyy-MM-dd"));
    });
    p.Content().Element(body);
    p.Footer().AlignRight().Text(x =>
    {
        x.Span("Page ");
        x.CurrentPageNumber();
        x.Span(" / ");
        x.TotalPages();
    });
}
```

---

## 3) Header block (document meta + parties)

Keep a **left meta** and **right parties** pattern. Per-doc deltas are pluggable lambdas.

```csharp
static void HeaderBlock(this IContainer c,
    Action<IContainer> metaLeft,
    Action<IContainer> partiesRight)
{
    c.TwoCol(
        left: metaLeft,
        right: partiesRight
    );
}

// party renderer for generated PartyType
static void PartyBox(this IContainer c, string title, PartyType? p)
{
    if (p is null) return;
    c.Section(title, s =>
    {
        s.Field("Name",        p.PartyName?.FirstOrDefault()?.Name?.Value?.Trim());
        s.Field("OrgNo",       p.PartyLegalEntity?.FirstOrDefault()?.CompanyID?.Value?.Trim());
        s.Field("VAT",         p.PartyTaxScheme?.FirstOrDefault()?.CompanyID?.Value?.Trim());
        var a  = p.PostalAddress;
        var ct = p.Contact?.FirstOrDefault();
        s.Field("Street",      a?.StreetName?.Value?.Trim());
        s.Field("City",        a?.CityName?.Value?.Trim());
        s.Field("Postal",      a?.PostalZone?.Value?.Trim());
        s.Field("Country",     a?.Country?.IdentificationCode?.Value?.Trim());
        s.Field("Contact",     ct?.Name?.Value?.Trim());
        s.Field("Email",       ct?.ElectronicMail?.Value?.Trim());
        s.Field("Phone",       ct?.Telephone?.Value?.Trim());
    });
}
```

**Usage (Invoice example, using generated types directly):**

```csharp
content.HeaderBlock(
    metaLeft: left =>
    {
        left.Field("Document ID", inv.ID?.Value);
        left.Field("Issue Date",  inv.IssueDate?.Value);
        left.Field("Currency",    inv.DocumentCurrencyCode?.Value);
        left.Field("ProfileID",   inv.ProfileID?.Value);
        left.Field("CustomizationID", inv.CustomizationID?.Value);
        left.Field("TypeCode",    inv.InvoiceTypeCode?.Value);
        left.Field("Payment Means", inv.PaymentMeans?.FirstOrDefault()?.PaymentMeansCode?.Value);
        left.Field("Payment Terms", inv.PaymentTerms?.FirstOrDefault()?.Note?.FirstOrDefault()?.Value);
        left.Field("Payment Ref", inv.PaymentReference?.Value);
        // per-doc extras
        left.Field("Order Ref",   inv.OrderReference?.FirstOrDefault()?.ID?.Value);
        left.Field("Delivery Date", inv.Delivery?.FirstOrDefault()?.ActualDeliveryDate?.Value);
        left.Field("Notes",       inv.Note?.FirstOrDefault()?.Value);
    },
    partiesRight: right =>
    {
        right.PartyBox("Supplier", inv.AccountingSupplierParty?.Party);
        right.PartyBox("Customer", inv.AccountingCustomerParty?.Party);
    });
```

CreditNote/Reminder do the exact same but swap the few lines that differ (e.g., `BillingReference`, `Discrepancy`, `ReminderSequenceNumeric`, etc.).

---

## 4) Lines tables

Define **column layout** once; feed rows with small helpers per doc-type.

### 4.1 Invoice/CreditNote columns

```csharp
static void StandardLineTable(this IContainer c, Action<TableDescriptor> fillRows)
{
    c.Table(t =>
    {
        t.ColumnsDefinition(cols =>
        {
            cols.RelativeColumn(0.7f);  // #
            cols.RelativeColumn(3.0f);  // Name
            cols.RelativeColumn(4.0f);  // Description
            cols.RelativeColumn(2.0f);  // Seller ID
            cols.RelativeColumn(1.0f);  // Unit
            cols.RelativeColumn(1.0f);  // Qty
            cols.RelativeColumn(1.2f);  // Price
            cols.RelativeColumn(1.4f);  // Line Ext
            cols.RelativeColumn(1.0f);  // VAT%
            cols.RelativeColumn(1.4f);  // VAT Cat
        });

        t.Header(h =>
        {
            foreach (var head in new[] { "#","Name","Description","Seller ID","Unit","Qty","Price","Line Ext","VAT%","VAT Cat" })
                h.Cell().HCell().Text(head);
        });

        fillRows(t);
    });
}

// Add rows for Invoice
static void AddInvoiceLines(this TableDescriptor t, IEnumerable<InvoiceLineType> lines)
{
    foreach (var (ln, i) in lines.Select((x, i) => (x, i)))
    {
        string? F(decimal? v) => v is null ? null : v.Value.ToString("0.##");
        var item = ln.Item;
        var tax  = item?.ClassifiedTaxCategory?.FirstOrDefault();

        void C(string? v) => t.Cell().Cell().Text(v ?? "");

        var no = int.TryParse(ln.ID?.Value, out var n) ? n : i + 1;
        C(no.ToString());
        C(item?.Name?.FirstOrDefault()?.Value?.Trim());
        C(item?.Description?.FirstOrDefault()?.Value?.Trim());
        C(item?.SellersItemIdentification?.ID?.Value?.Trim());
        C(ln.InvoicedQuantity?.unitCodeSpecified == true ? ln.InvoicedQuantity.unitCode : null);
        C(F(ParseDec(ln.InvoicedQuantity?.Value)));
        C(F(ParseDec(ln.Price?.PriceAmount?.Value)));
        C(F(ParseDec(ln.LineExtensionAmount?.Value)));
        C(F(ParseDec(tax?.Percent?.Value)));
        C(tax?.ID?.Value?.Trim());
    }

    static decimal? ParseDec(string? s) =>
        decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var d) ? d : null;
}

// Add rows for CreditNote
static void AddCreditNoteLines(this TableDescriptor t, IEnumerable<CreditNoteLineType> lines)
{
    foreach (var (ln, i) in lines.Select((x, i) => (x, i)))
    {
        string? F(decimal? v) => v is null ? null : v.Value.ToString("0.##");
        var item = ln.Item;
        var tax  = item?.ClassifiedTaxCategory?.FirstOrDefault();

        void C(string? v) => t.Cell().Cell().Text(v ?? "");

        var no = int.TryParse(ln.ID?.Value, out var n) ? n : i + 1;
        C(no.ToString());
        C(item?.Name?.FirstOrDefault()?.Value?.Trim());
        C(item?.Description?.FirstOrDefault()?.Value?.Trim());
        C(item?.SellersItemIdentification?.ID?.Value?.Trim());
        C(ln.CreditedQuantity?.unitCodeSpecified == true ? ln.CreditedQuantity.unitCode : null);
        C(F(ParseDec(ln.CreditedQuantity?.Value)));
        C(F(ParseDec(ln.Price?.PriceAmount?.Value)));
        C(F(ParseDec(ln.LineExtensionAmount?.Value)));
        C(F(ParseDec(tax?.Percent?.Value)));
        C(tax?.ID?.Value?.Trim());
    }

    static decimal? ParseDec(string? s) =>
        decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var d) ? d : null;
}
```

### 4.2 Reminder columns

```csharp
static void ReminderLineTable(this IContainer c, IEnumerable<ReminderLineType> lines)
{
    c.Table(t =>
    {
        t.ColumnsDefinition(cols =>
        {
            cols.RelativeColumn(0.7f);  // #
            cols.RelativeColumn(5.0f);  // Reference
            cols.RelativeColumn(4.0f);  // Description
            cols.RelativeColumn(2.0f);  // Amount
            cols.RelativeColumn(1.0f);  // Curr
        });

        t.Header(h =>
        {
            foreach (var head in new[] { "#","Reference","Description","Amount","Curr" })
                h.Cell().HCell().Text(head);
        });

        foreach (var (ln, i) in lines.Select((x, i) => (x, i)))
        {
            void C(string? v) => t.Cell().Cell().Text(v ?? "");
            var no = int.TryParse(ln.ID?.Value, out var n) ? n : i + 1;

            C(no.ToString());
            C(ln.Reference?.FirstOrDefault()?.ID?.Value?.Trim() ?? ln.Note?.FirstOrDefault()?.Value?.Trim());
            C(ln.Note?.FirstOrDefault()?.Value?.Trim());
            C(ParseDec(ln.Amount?.Value)?.ToString("0.##"));
            C(ln.Amount?.currencyID);
        }

        static decimal? ParseDec(string? s) =>
            decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var d) ? d : null;
    });
}
```

---

## 5) Totals block

Right-aligned block; currency from totals payable if present, else document currency.

```csharp
static void TotalsBlock(this IContainer c, decimal? taxExcl, decimal? taxIncl, decimal? payable, string? currency, string payableLabel = "Total Payable")
{
    c.Row(r =>
    {
        r.RelativeColumn();
        r.RelativeColumn(4).Column(col =>
        {
            col.Item().Money("Tax Exclusive", taxExcl, currency);
            col.Item().Money("Tax Inclusive", taxIncl, currency);
            col.Item().Money(payableLabel, payable, currency);
        });
    });
}
```

**Usage (generated types directly):**

```csharp
var tot = inv.LegalMonetaryTotal;
var curr = tot?.PayableAmount?.currencyID ?? inv.DocumentCurrencyCode?.Value;
content.TotalsBlock(
    taxExcl: tot?.TaxExclusiveAmount?.Value?.ParseM(),
    taxIncl: tot?.TaxInclusiveAmount?.Value?.ParseM(),
    payable: tot?.PayableAmount?.Value?.ParseM(),
    currency: curr);

static decimal? ParseM(this string? s) =>
    decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var d) ? d : null;
```

---

## 6) Putting it together per doc type

You keep three short orchestrators that only differ in meta fields and line source.

### Invoice

```csharp
static void RenderInvoicePage(this PageDescriptor p, InvoiceType inv)
{
    p.BuildPage("Invoice", body =>
    {
        body.HeaderBlock(
            metaLeft: left =>
            {
                left.Field("Document ID", inv.ID?.Value);
                left.Field("Issue Date",  inv.IssueDate?.Value);
                left.Field("Currency",    inv.DocumentCurrencyCode?.Value);
                left.Field("ProfileID",   inv.ProfileID?.Value);
                left.Field("CustomizationID", inv.CustomizationID?.Value);
                left.Field("TypeCode",    inv.InvoiceTypeCode?.Value);
                left.Field("Payment Means", inv.PaymentMeans?.FirstOrDefault()?.PaymentMeansCode?.Value);
                left.Field("Payment Terms", inv.PaymentTerms?.FirstOrDefault()?.Note?.FirstOrDefault()?.Value);
                left.Field("Payment Ref", inv.PaymentReference?.Value);
                left.Field("Order Ref",   inv.OrderReference?.FirstOrDefault()?.ID?.Value);
                left.Field("Delivery Date", inv.Delivery?.FirstOrDefault()?.ActualDeliveryDate?.Value);
                left.Field("Notes",       inv.Note?.FirstOrDefault()?.Value);
            },
            partiesRight: right =>
            {
                right.PartyBox("Supplier", inv.AccountingSupplierParty?.Party);
                right.PartyBox("Customer", inv.AccountingCustomerParty?.Party);
            });

        var lines = inv.InvoiceLine ?? Array.Empty<InvoiceLineType>();
        if (lines.Length > 0)
            body.StandardLineTable(t => t.AddInvoiceLines(lines));

        var total = inv.LegalMonetaryTotal;
        var curr  = total?.PayableAmount?.currencyID ?? inv.DocumentCurrencyCode?.Value;
        body.TotalsBlock(
            taxExcl: total?.TaxExclusiveAmount?.Value?.ParseM(),
            taxIncl: total?.TaxInclusiveAmount?.Value?.ParseM(),
            payable: total?.PayableAmount?.Value?.ParseM(),
            currency: curr);
    });
}
```

### Credit Note

* Same as invoice; swap the few header fields and feed `CreditNoteLine`.

```csharp
static void RenderCreditNotePage(this PageDescriptor p, CreditNoteType cn)
{
    p.BuildPage("Credit Note", body =>
    {
        body.HeaderBlock(
            metaLeft: left =>
            {
                left.Field("Document ID", cn.ID?.Value);
                left.Field("Issue Date",  cn.IssueDate?.Value);
                left.Field("Currency",    cn.DocumentCurrencyCode?.Value);
                left.Field("ProfileID",   cn.ProfileID?.Value);
                left.Field("CustomizationID", cn.CustomizationID?.Value);
                left.Field("TypeCode",    cn.CreditNoteTypeCode?.Value);
                left.Field("Original Invoice", cn.BillingReference?.FirstOrDefault()?.InvoiceDocumentReference?.ID?.Value);
                left.Field("Discrepancy", cn.DiscrepancyResponse?.FirstOrDefault()?.Description?.FirstOrDefault()?.Value);
                left.Field("Payment Means", cn.PaymentMeans?.FirstOrDefault()?.PaymentMeansCode?.Value);
                left.Field("Payment Terms", cn.PaymentTerms?.FirstOrDefault()?.Note?.FirstOrDefault()?.Value);
                left.Field("Payment Ref", cn.PaymentReference?.Value);
                left.Field("Notes",       cn.Note?.FirstOrDefault()?.Value);
            },
            partiesRight: right =>
            {
                right.PartyBox("Supplier", cn.AccountingSupplierParty?.Party);
                right.PartyBox("Customer", cn.AccountingCustomerParty?.Party);
            });

        var lines = cn.CreditNoteLine ?? Array.Empty<CreditNoteLineType>();
        if (lines.Length > 0)
            body.StandardLineTable(t => t.AddCreditNoteLines(lines));

        var total = cn.LegalMonetaryTotal;
        var curr  = total?.PayableAmount?.currencyID ?? cn.DocumentCurrencyCode?.Value;
        body.TotalsBlock(
            taxExcl: total?.TaxExclusiveAmount?.Value?.ParseM(),
            taxIncl: total?.TaxInclusiveAmount?.Value?.ParseM(),
            payable: total?.PayableAmount?.Value?.ParseM(),
            currency: curr);
    });
}
```

### Reminder

```csharp
static void RenderReminderPage(this PageDescriptor p, ReminderType rem)
{
    p.BuildPage("Payment Reminder", body =>
    {
        body.HeaderBlock(
            metaLeft: left =>
            {
                left.Field("Document ID", rem.ID?.Value);
                left.Field("Issue Date",  rem.IssueDate?.Value);
                left.Field("Currency",    rem.DocumentCurrencyCode?.Value);
                left.Field("ProfileID",   rem.ProfileID?.Value);
                left.Field("CustomizationID", rem.CustomizationID?.Value);
                left.Field("TypeCode",    rem.ReminderTypeCode?.Value);
                left.Field("Reminder Seq", rem.ReminderSequenceNumeric?.Value);
                left.Field("Related Invoice", rem.BillingReference?.FirstOrDefault()?.InvoiceDocumentReference?.ID?.Value);
                left.Field("Reminder Period", rem.ReminderPeriod?.FirstOrDefault()?.Description?.FirstOrDefault()?.Value);
                left.Field("Payment Means", rem.PaymentMeans?.FirstOrDefault()?.PaymentMeansCode?.Value);
                left.Field("Payment Terms", rem.PaymentTerms?.FirstOrDefault()?.Note?.FirstOrDefault()?.Value);
                left.Field("Payment Ref", rem.PaymentReference?.Value);
                left.Field("Notes",       rem.Note?.FirstOrDefault()?.Value);
            },
            partiesRight: right =>
            {
                right.PartyBox("Supplier", rem.AccountingSupplierParty?.Party);
                right.PartyBox("Customer", rem.AccountingCustomerParty?.Party);
            });

        var lines = rem.ReminderLine ?? Array.Empty<ReminderLineType>();
        if (lines.Length > 0)
            body.ReminderLineTable(lines);

        var total = rem.LegalMonetaryTotal;
        var curr  = total?.PayableAmount?.currencyID ?? rem.DocumentCurrencyCode?.Value;
        body.TotalsBlock(
            taxExcl: total?.TaxExclusiveAmount?.Value?.ParseM(),
            taxIncl: total?.TaxInclusiveAmount?.Value?.ParseM(),
            payable: total?.PayableAmount?.Value?.ParseM(),
            currency: curr,
            payableLabel: "Outstanding Payable");
    });
}
```

---

## 7) Document factory (simple dispatcher)

```csharp
static Document CreateUblDocument(UblContainer u) =>
    Document.Create(container =>
    {
        container.Page(p =>
        {
            switch (u)
            {
                case { Invoice: not null }    : p.RenderInvoicePage(u.Invoice); break;
                case { CreditNote: not null } : p.RenderCreditNotePage(u.CreditNote); break;
                case { Reminder: not null }   : p.RenderReminderPage(u.Reminder); break;
                default: p.Content().Text("Empty UBL container");
            }
        });
    });
```

---

## 8) Optional niceties (drop-in)

* **Auto-wrap long text**: already handled by QuestPDF; avoid fixed widths.
* **Conditional sections**: just omit if lambda has nothing to print (your `Field` helper ensures that).
* **Per-profile toggles**: add a `RenderOptions` record; pass to meta lambdas to include/exclude columns or labels.
* **Page breaks**: call `col.Item().PageBreak()` between big sections if needed.
* **Logos/QR**: add `IContainer.Image(stream)` in header (keep within a `ConstantColumn`).

---

### TL;DR

* Build a tiny **IContainer micro-DSL** (`Field`, `Money`, `Section`, `TwoCol`, `HCell`, `Cell`).
* Use one **page scaffold** and one **header block** pattern.
* Define **two table shapes** (standard lines, reminder lines) and feed rows directly from generated types.
* Totals block is a **single reusable** function.
* Per doc-type, the only code that differs is **which fields you pass** into the shared blocks.

Want this turned into a ready-to-paste **single `.cs` file** with all helpers grouped and no external dependencies beyond QuestPDF? I can emit that next.
