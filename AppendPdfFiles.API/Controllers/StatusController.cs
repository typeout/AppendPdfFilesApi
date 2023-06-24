using Microsoft.AspNetCore.Mvc;

namespace FBR.API.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = false)]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        ///<summary>Test API with OK request</summary>
        ///<returns>Returns 200 OK response</returns>
        ///<response code="200">Return OK</response>
        ///<response code="400">Bad Request</response>
        [HttpGet]
        public ActionResult<string> Get() => Ok("OK");
    }
}
