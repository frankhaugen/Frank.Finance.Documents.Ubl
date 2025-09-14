using Frank.Finance.Documents.Ubl.Renderer.Models;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Xunit.Abstractions;

namespace Frank.Finance.Documents.Ubl.Tests;

public class UblRendererTests(ITestOutputHelper outputHelper)
{
    [Fact]
    public async Task GenerateForcedInvoiceUblDocumentPdfAsync()
    {
        QuestPDF.Settings.License = LicenseType.Community; 
        var baseDirectory = AppContext.BaseDirectory;
        outputHelper.WriteLine($"Base Directory: {baseDirectory}");
        var translator = new DefaultTranslator();
        var ublDocument = await DocumentProvider.GetUblDocumentAsync(baseDirectory, translator, _invoice);
        Assert.NotNull(ublDocument);
        outputHelper.WriteLine($"Document Type: {ublDocument.GetType().Name}");
        _ = ublDocument.GeneratePdf();
    }

    [Fact]
    public async Task GenerateForcedCreditNoteUblDocumentPdfAsync()
    {
        QuestPDF.Settings.License = LicenseType.Community; 
        var baseDirectory = AppContext.BaseDirectory;
        outputHelper.WriteLine($"Base Directory: {baseDirectory}");
        var translator = new DefaultTranslator();
        var ublDocument = await DocumentProvider.GetUblDocumentAsync(baseDirectory, translator, _creditNote);
        Assert.NotNull(ublDocument);
        outputHelper.WriteLine($"Document Type: {ublDocument.GetType().Name}");
        _ = ublDocument.GeneratePdf();
    }
    
    [Fact]
    public async Task GenerateForcedReminderUblDocumentPdfAsync()
    {
        QuestPDF.Settings.License = LicenseType.Community; 
        var baseDirectory = AppContext.BaseDirectory;
        outputHelper.WriteLine($"Base Directory: {baseDirectory}");
        var translator = new DefaultTranslator();
        var ublDocument = await DocumentProvider.GetUblDocumentAsync(baseDirectory, translator, _reminder);
        Assert.NotNull(ublDocument);
        outputHelper.WriteLine($"Document Type: {ublDocument.GetType().Name}");
        _ = ublDocument.GeneratePdf();
    }

    [Fact]
    public async Task GenerateAllUblDocumentPdfAsync()
    {
        QuestPDF.Settings.License = LicenseType.Community; 
        var baseDirectory = AppContext.BaseDirectory;
        outputHelper.WriteLine($"Base Directory: {baseDirectory}");
        var translator = new DefaultTranslator();
        for (var i = 1; i <= 3; i++)
        {
            var ublDocument = await DocumentProvider.GetUblDocumentAsync(baseDirectory, translator, i);
            Assert.NotNull(ublDocument);
            outputHelper.WriteLine($"Document Type: {ublDocument.GetType().Name}");
            _ = ublDocument.GeneratePdf();
        }
    }
    
    private static int _invoice = 1;
    private static int _creditNote = 2;
    private static int _reminder = 3;
}