using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace JRMTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController: ControllerBase
    {
        private static Game _fizzBuzzGame = new Game();
      


        [HttpGet("GameInformation")]

        public ActionResult<Game> GetGameInformation(){


            return Ok(_fizzBuzzGame);
        }

       
        
    }
}