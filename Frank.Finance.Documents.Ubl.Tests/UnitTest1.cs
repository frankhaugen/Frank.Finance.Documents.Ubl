using Frank.Finance.Documents.Ubl.Renderer.Models;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;
using QuestPDF.Companion;
using Xunit.Abstractions;

namespace Frank.Finance.Documents.Ubl.Tests;

public class UblRendererTests(ITestOutputHelper outputHelper)
{
    [Fact]
    public async Task GetUblDocumentAsync()
    {
        var baseDirectory = AppContext.BaseDirectory;
        outputHelper.WriteLine($"Base Directory: {baseDirectory}");
        var translator = new DefaultTranslator();
        var ublDocument = await DocumentProvider.GetUblDocumentAsync(baseDirectory, translator);
        Assert.NotNull(ublDocument);
        outputHelper.WriteLine($"Document Type: {ublDocument.GetType().Name}");
        
        await ublDocument.ShowInCompanionAsync();
    }
}