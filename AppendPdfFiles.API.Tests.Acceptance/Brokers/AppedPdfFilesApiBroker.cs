using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace AppendPdfFiles.API.Tests.Acceptance;

public partial class AppedPdfFilesApiBroker
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;
    private readonly HttpClient httpClient;
    private readonly IRESTFulApiFactoryClient apiFactoryClient;

    public AppedPdfFilesApiBroker()
    {
        this.webApplicationFactory = new WebApplicationFactory<Program>();
        this.httpClient = this.webApplicationFactory.CreateClient();
        this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
    }
}
