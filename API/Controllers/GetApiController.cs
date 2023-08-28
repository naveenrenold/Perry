namespace GetApi.Controllers
{
    using GetApi.DataLayer.Interface;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        public readonly IGetApiData iGetApiData;
        [HttpGet]
        public  IActionResult GetCommands()
        {   
            return Ok(iGetApiData.GetCommands());            
        }
    }
}