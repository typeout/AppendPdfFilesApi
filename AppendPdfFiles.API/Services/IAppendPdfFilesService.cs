namespace AppendPdfFiles.API.Services;

public interface IAppendPdfFilesService
{
    Task<IFormFile> AppendPdfFilesAsync(IFormFileCollection pdfFiles);
}
