using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("actionResult")]
        public IActionResult actionResult() 
        {
            Database db= Database.GetDatabase;
            db.Connection();
            db.Disconnec();

            return Ok(db.Count);
        }
        [HttpGet("actionResult2")]
        public IActionResult actionResult2() 
        {
            Database db = Database.GetDatabase;
            db.Connection();
            db.Disconnec();
            return Ok(db.Count);
        }
    }
}
