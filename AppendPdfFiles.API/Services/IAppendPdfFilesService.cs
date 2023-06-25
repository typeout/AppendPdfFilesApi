namespace AppendPdfFiles.API.Services;

interface IAppendPdfFilesService
{
    Task<IFormFile> AppendPdfFilesAsync(IFormFileCollection pdfFiles);
}
