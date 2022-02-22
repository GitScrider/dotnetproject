using dotnetproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace dotnetproject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PositionController : ControllerBase
    {

        public PositionController()
        {

        }


        [HttpGet]
        public ActionResult<string> Test()
        {
            return ("ok");
        }

        [HttpPost]
        public IActionResult SendPosition([FromBody] PositionXY positionXY)
        {
            Console.WriteLine(positionXY.X + " - " + positionXY.Y);

            teste x = new teste()
            {
                msg = "teste"
            };

            return Ok(x);

        }

    }
}


class teste
{
    public string msg;
}