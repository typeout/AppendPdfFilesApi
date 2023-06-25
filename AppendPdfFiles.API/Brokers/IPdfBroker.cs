namespace AppendPdfFiles.API.Brokers;

public interface IPdfBroker
{
    Task<MemoryStream> AppendPdfFileStreamAsync(IEnumerable<MemoryStream> pdfFiles);
    Task<Boolean> CanBeAppendedAsync(MemoryStream pdfFile);
}
