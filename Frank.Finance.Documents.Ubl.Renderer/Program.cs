// See https://aka.ms/new-console-template for more information

using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents;
using Frank.Finance.Documents.Ubl.Invoice;
using Frank.Finance.Documents.Ubl.Renderer.Models;
using Frank.Finance.Documents.Ubl.Renderer;
using QuestPDF.Companion;
using QuestPDF.Infrastructure;

Console.WriteLine("Starting UBL Renderer...");
QuestPDF.Settings.License = LicenseType.Community; 
var translator = new DefaultTranslator();

var baseDirectory = AppContext.BaseDirectory;
Console.WriteLine($"Base Directory: {baseDirectory}");
var norwegianXmlName = "Norwegian-example-1.xml";
var norwegianXmlPath = Path.Combine(baseDirectory, norwegianXmlName);
Console.WriteLine($"Norwegian XML Path: {norwegianXmlPath}");
if (!File.Exists(norwegianXmlPath))
{
    Console.WriteLine($"File not found: {norwegianXmlPath}");
    return;
}
var norwegianXmlContent = await File.ReadAllTextAsync(norwegianXmlPath);
Console.WriteLine($"Norwegian XML Content Length: {norwegianXmlContent.Length}");
var xDocument = System.Xml.Linq.XDocument.Parse(norwegianXmlContent);

// XML deserialization:
var serializer = new System.Xml.Serialization.XmlSerializer(typeof(InvoiceType));
using var reader = xDocument.CreateReader();
var invoiceFromXml = (InvoiceType?)serializer.Deserialize(reader);
if (invoiceFromXml == null)
{
    Console.WriteLine("Failed to deserialize invoice from XML");
    return;
}
Console.WriteLine($"Deserialized Invoice ID: {invoiceFromXml.Id?.Value}");
var invoice = invoiceFromXml;

var renderContext = new RenderContext(translator, Frank.Finance.Documents.Ubl.Renderer.Models.Language.EN, invoice);
var ublDocument = new UblDocument(renderContext);

await ublDocument.ShowInCompanionAsync();