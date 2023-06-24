using Xunit;

namespace AppendPdfFiles.API.Tests.Acceptance;

[CollectionDefinition(nameof(ApiTestCollection))]
public class ApiTestCollection : ICollectionFixture<AppendPdfFilesApiBroker> { }
