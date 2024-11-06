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
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {

            _gameService = gameService;
            
        }
      


        [HttpGet("GameInformation")]

        public async Task<ActionResult<List<Game>>> GetGameInformation(){


            return Ok( await _gameService.GetAllGame());
        }

       
        
    }
}