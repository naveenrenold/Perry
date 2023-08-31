namespace GetApi.Controllers
{
    using GetApi.DataLayer.Classes;
    using GetApi.DataLayer.Interface;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        public GetApiData getApiData=new GetApiData() ;
        [HttpGet]
        public  IActionResult GetCommands()
        {   
            return Ok(getApiData.GetCommands());            
        }
    }
}