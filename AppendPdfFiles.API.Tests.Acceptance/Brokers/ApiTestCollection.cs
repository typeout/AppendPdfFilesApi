using Xunit;

namespace AppendPdfFiles.API.Tests.Acceptance.Brokers;

[CollectionDefinition(nameof(ApiTestCollection))]
public class ApiTestCollection : ICollectionFixture<AppendPdfFilesApiBroker> { }
