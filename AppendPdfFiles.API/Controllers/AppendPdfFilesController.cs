using AppendPdfFiles.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FBR.API.Controllers;

public class AppendPdfFilesController : Controller
{
    ///<summary>Download appended PDF file</summary>
    ///<returns>Returns a file</returns>
    ///<response code="200">Returns File Response</response>
    ///<response code="400">Bad Request</response>
    [HttpPost("api/appendpdffiles", Name = "AppendPdfFiles")]
    [ProducesResponseType(typeof(File), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BadRequestResult), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AppendPdfFiles(
        [FromServices] IAppendPdfFilesService appendPdfFilesService,
        [FromForm] IFormFileCollection pdfFiles
    )
    {
        try
        {
            return Ok(await appendPdfFilesService.AppendPdfFilesAsync(pdfFiles));
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }
}
