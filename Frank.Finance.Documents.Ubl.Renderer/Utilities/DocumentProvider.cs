using System.Xml.Linq;
using System.Xml.Serialization;
using Frank.Finance.Documents.Ubl.CreditNote;
using Frank.Finance.Documents.Ubl.Invoice;
using Frank.Finance.Documents.Ubl.Reminder;
using Frank.Finance.Documents.Ubl.Renderer.Models;

namespace Frank.Finance.Documents.Ubl.Renderer.Utilities;

public static class DocumentProvider
{
    public static async Task<UblDocument> GetUblDocumentAsync(string baseDirectory, ITranslator translator, int? forcedDocumentType = null)
    {
        RenderContext renderContext;
        var diceRoll = new Random().Next(1, 4);

        switch (forcedDocumentType ?? diceRoll)
        {
            case 1:
                Console.WriteLine("Rendering Invoice...");
                var invoicePath = Path.Combine(baseDirectory, "Files", "UBL-Invoice-2.1-Example.xml");
                if (!File.Exists(invoicePath))
                {
                    Console.WriteLine($"Invoice file not found: {invoicePath}");
                    throw new InvalidOperationException($"Invoice file not found: {invoicePath}");
                }

                var invoiceXmlContent = await File.ReadAllTextAsync(invoicePath);
                Console.WriteLine($"XML Content Length: {invoiceXmlContent.Length}");
                var invoiceXDocument = XDocument.Parse(invoiceXmlContent);

                // XML deserialization:
                var invoiceSerializer = new XmlSerializer(typeof(InvoiceType));
                using (var invoiceReader = invoiceXDocument.CreateReader())
                {
                    var invoiceFromXml = (InvoiceType?)invoiceSerializer.Deserialize(invoiceReader);
                    if (invoiceFromXml == null)
                    {
                        Console.WriteLine("Failed to deserialize invoice from XML");
                        throw new InvalidOperationException("Failed to deserialize invoice from XML");
                    }

                    Console.WriteLine($"Deserialized Invoice ID: {invoiceFromXml.Id?.Value}");
                    var invoice = invoiceFromXml;

                    renderContext = new RenderContext(translator, Language.EN, invoice);
                }

                break;
            case 2:
                Console.WriteLine("Rendering Credit Note...");
                var creditNotePath = Path.Combine(baseDirectory, "Files", "UBL-CreditNote-2.1-Example.xml");
                if (!File.Exists(creditNotePath))
                {
                    Console.WriteLine($"Credit Note file not found: {creditNotePath}");
                    throw new InvalidOperationException($"Credit Note file not found: {creditNotePath}");
                }

                var creditNoteXmlContent = await File.ReadAllTextAsync(creditNotePath);
                Console.WriteLine($"XML Content Length: {creditNoteXmlContent.Length}");
                var creditNoteXDocument = XDocument.Parse(creditNoteXmlContent);
                var creditNoteSerializer = new XmlSerializer(typeof(CreditNoteType));
                using (var creditNoteReader = creditNoteXDocument.CreateReader())
                {
                    var creditNoteFromXml = (CreditNoteType?)creditNoteSerializer.Deserialize(creditNoteReader);
                    if (creditNoteFromXml == null)
                    {
                        Console.WriteLine("Failed to deserialize credit note from XML");
                        throw new InvalidOperationException("Failed to deserialize credit note from XML");
                    }

                    Console.WriteLine($"Deserialized Credit Note ID: {creditNoteFromXml.Id?.Value}");
                    var creditNote = creditNoteFromXml;
                    renderContext = new RenderContext(translator, Language.EN, null, creditNote);
                }

                break;
            case 3:
                Console.WriteLine("Rendering Reminder...");
                var reminderPath = Path.Combine(baseDirectory, "Files", "UBL-Reminder-2.1-Example.xml");
                if (!File.Exists(reminderPath))
                {
                    Console.WriteLine($"Reminder file not found: {reminderPath}");
                    throw new InvalidOperationException($"Reminder file not found: {reminderPath}");
                }

                var reminderXmlContent = await File.ReadAllTextAsync(reminderPath);
                Console.WriteLine($"XML Content Length: {reminderXmlContent.Length}");
                var reminderXDocument = XDocument.Parse(reminderXmlContent);
                var reminderSerializer = new XmlSerializer(typeof(ReminderType));
                using (var reminderReader = reminderXDocument.CreateReader())
                {
                    var reminderFromXml = (ReminderType?)reminderSerializer.Deserialize(reminderReader);
                    if (reminderFromXml == null)
                    {
                        Console.WriteLine("Failed to deserialize reminder from XML");
                        throw new InvalidOperationException("Failed to deserialize reminder from XML");
                    }

                    Console.WriteLine($"Deserialized Reminder ID: {reminderFromXml.Id?.Value}");
                    var reminder = reminderFromXml;
                    renderContext = new RenderContext(translator, Language.EN, null, null, reminder);
                }

                break;
            default:
                Console.WriteLine("Invalid dice roll");
                throw new InvalidOperationException("Invalid dice roll");
        }

        var ublDocument = new UblDocument(renderContext);

        return ublDocument;
    }
}