namespace AppendPdfFiles.API.Brokers;

public class PdfBroker : IPdfBroker
{
    public Task<MemoryStream> AppendPdfFileStreamAsync(IEnumerable<MemoryStream> pdfFiles)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CanBeAppendedAsync(MemoryStream pdfFile)
    {
        throw new NotImplementedException();
    }
}
