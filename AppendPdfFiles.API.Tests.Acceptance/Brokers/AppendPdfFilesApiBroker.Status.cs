namespace AppendPdfFiles.API.Tests.Acceptance;

public partial class AppendPdfFilesApiBroker
{
    private const string StatusRelativeUrl = "api/status";

    public async Task<string> GetStatusMessageAsync() =>
        await this.apiFactoryClient.GetContentStringAsync(StatusRelativeUrl);
}
