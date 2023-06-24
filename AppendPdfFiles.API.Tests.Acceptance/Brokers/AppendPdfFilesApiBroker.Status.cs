namespace AppendPdfFiles.API.Tests.Acceptance.Brokers;

public partial class AppendPdfFilesApiBroker
{
    private const string StatusRelativeUrl = "api/status";

    public async Task<string> GetStatusMessageAsync() =>
        await this.apiFactoryClient.GetContentStringAsync(StatusRelativeUrl);
}
