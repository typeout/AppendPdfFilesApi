using AppendPdfFiles.API.Tests.Acceptance.Brokers;
using FluentAssertions;
using Xunit;

namespace AppendPdfFiles.API.Tests.Acceptance.APIs;

[Collection(nameof(ApiTestCollection))]
public class StatusApiTest
{
    private readonly AppendPdfFilesApiBroker appendPdfFilesApiBroker;

    public StatusApiTest(AppendPdfFilesApiBroker appendPdfFilesApiBroker)
    {
        this.appendPdfFilesApiBroker = appendPdfFilesApiBroker;
    }

    [Fact]
    public async Task ShouldReturnOkStatusMessageAsync()
    {
        string expectedMessage = "OK";

        string actualMessage = await this.appendPdfFilesApiBroker.GetStatusMessageAsync();

        actualMessage.Should().Be(expectedMessage);
    }
}
