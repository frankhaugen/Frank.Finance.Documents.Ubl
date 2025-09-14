// See https://aka.ms/new-console-template for more information

using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents;
using Frank.Finance.Documents.Ubl.CreditNote;
using Frank.Finance.Documents.Ubl.Invoice;
using Frank.Finance.Documents.Ubl.Reminder;
using Frank.Finance.Documents.Ubl.Renderer.Models;
using Frank.Finance.Documents.Ubl.Renderer;
using QuestPDF.Companion;
using QuestPDF.Infrastructure;

Console.WriteLine("Starting UBL Renderer...");
QuestPDF.Settings.License = LicenseType.Community; 
var translator = new DefaultTranslator();

var baseDirectory = AppContext.BaseDirectory;
Console.WriteLine($"Base Directory: {baseDirectory}");

RenderContext renderContext;
var diceRoll = new Random().Next(1, 4);

switch (diceRoll)
{
    case 1:
        Console.WriteLine("Rendering Invoice...");
        var invoicePath = Path.Combine(baseDirectory, "Files", "UBL-Invoice-2.1-Example.xml");
        if (!File.Exists(invoicePath))
        {
            Console.WriteLine($"Invoice file not found: {invoicePath}");
            return;
        }

        var invoiceXmlContent = await File.ReadAllTextAsync(invoicePath);
        Console.WriteLine($"XML Content Length: {invoiceXmlContent.Length}");
        var invoiceXDocument = System.Xml.Linq.XDocument.Parse(invoiceXmlContent);

        // XML deserialization:
        var invoiceSerializer = new System.Xml.Serialization.XmlSerializer(typeof(InvoiceType));
        using (var invoiceReader = invoiceXDocument.CreateReader())
        {
            var invoiceFromXml = (InvoiceType?)invoiceSerializer.Deserialize(invoiceReader);
            if (invoiceFromXml == null)
            {
                Console.WriteLine("Failed to deserialize invoice from XML");
                return;
            }

            Console.WriteLine($"Deserialized Invoice ID: {invoiceFromXml.Id?.Value}");
            var invoice = invoiceFromXml;

            renderContext = new RenderContext(translator, Frank.Finance.Documents.Ubl.Renderer.Models.Language.EN, invoice);
        }
        break;
    case 2:
        Console.WriteLine("Rendering Credit Note...");
        var creditNotePath = Path.Combine(baseDirectory, "Files", "UBL-CreditNote-2.1-Example.xml");
        if (!File.Exists(creditNotePath))
        {
            Console.WriteLine($"Credit Note file not found: {creditNotePath}");
            return;
        }

        var creditNoteXmlContent = await File.ReadAllTextAsync(creditNotePath);
        Console.WriteLine($"XML Content Length: {creditNoteXmlContent.Length}");
        var creditNoteXDocument = System.Xml.Linq.XDocument.Parse(creditNoteXmlContent);
        var creditNoteSerializer = new System.Xml.Serialization.XmlSerializer(typeof(CreditNoteType));
        using (var creditNoteReader = creditNoteXDocument.CreateReader())
        {
            var creditNoteFromXml = (CreditNoteType?)creditNoteSerializer.Deserialize(creditNoteReader);
            if (creditNoteFromXml == null)
            {
                Console.WriteLine("Failed to deserialize credit note from XML");
                return;
            }

            Console.WriteLine($"Deserialized Credit Note ID: {creditNoteFromXml.Id?.Value}");
            var creditNote = creditNoteFromXml;
            renderContext = new RenderContext(translator, Frank.Finance.Documents.Ubl.Renderer.Models.Language.EN, null, creditNote);
        }
        break;
    case 3:
        Console.WriteLine("Rendering Reminder...");
        var reminderPath = Path.Combine(baseDirectory, "Files", "UBL-Reminder-2.1-Example.xml");
        if (!File.Exists(reminderPath))
        {
            Console.WriteLine($"Reminder file not found: {reminderPath}");
            return;
        }

        var reminderXmlContent = await File.ReadAllTextAsync(reminderPath);
        Console.WriteLine($"XML Content Length: {reminderXmlContent.Length}");
        var reminderXDocument = System.Xml.Linq.XDocument.Parse(reminderXmlContent);
        var reminderSerializer = new System.Xml.Serialization.XmlSerializer(typeof(ReminderType));
        using (var reminderReader = reminderXDocument.CreateReader())
        {
            var reminderFromXml = (ReminderType?)reminderSerializer.Deserialize(reminderReader);
            if (reminderFromXml == null)
            {
                Console.WriteLine("Failed to deserialize reminder from XML");
                return;
            }

            Console.WriteLine($"Deserialized Reminder ID: {reminderFromXml.Id?.Value}");
            var reminder = reminderFromXml;
            renderContext = new RenderContext(translator, Frank.Finance.Documents.Ubl.Renderer.Models.Language.EN, null, null, reminder);
        }
        break;
    default:
        Console.WriteLine("Invalid dice roll");
        return;
}

var ublDocument = new UblDocument(renderContext);

await ublDocument.ShowInCompanionAsync();