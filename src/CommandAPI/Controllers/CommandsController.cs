using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    //Route api/[controller] jelentése
    //localhost:5001/api/commands
    //commandsController leválasztja a controller előtti részt
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetActionResult()
        {
            return new string[] { "this", "is", "hard", "code" };
        }
    }
}