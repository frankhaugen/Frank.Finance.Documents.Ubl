// See https://aka.ms/new-console-template for more information

using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents;
using Frank.Finance.Documents.Ubl.CreditNote;
using Frank.Finance.Documents.Ubl.Invoice;
using Frank.Finance.Documents.Ubl.Reminder;
using Frank.Finance.Documents.Ubl.Renderer.Models;
using Frank.Finance.Documents.Ubl.Renderer;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;
using QuestPDF.Companion;
using QuestPDF.Infrastructure;

Console.WriteLine("Starting UBL Renderer...");
QuestPDF.Settings.License = LicenseType.Community; 
var translator = new DefaultTranslator();

var baseDirectory = AppContext.BaseDirectory;
Console.WriteLine($"Base Directory: {baseDirectory}");

var ublDocument = await DocumentProvider.GetUblDocumentAsync(baseDirectory, translator);

await ublDocument.ShowInCompanionAsync();