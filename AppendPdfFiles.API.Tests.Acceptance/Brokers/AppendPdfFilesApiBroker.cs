using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace AppendPdfFiles.API.Tests.Acceptance;

public partial class AppendPdfFilesApiBroker
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;
    private readonly HttpClient httpClient;
    private readonly IRESTFulApiFactoryClient apiFactoryClient;

    public AppendPdfFilesApiBroker()
    {
        this.webApplicationFactory = new WebApplicationFactory<Program>();
        this.httpClient = this.webApplicationFactory.CreateClient();
        this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
    }
}
