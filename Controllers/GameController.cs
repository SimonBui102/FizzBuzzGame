using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Dtos.Game;
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
      


        [HttpGet("AllGameInformation")]

        public async Task<ActionResult<List<GetGameDto>>> GetGameList(){


            return Ok( await _gameService.GetAllGame());
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<GetGameDto>> GetGameById(int id){


            return Ok(await _gameService.GetGameById(id));
        }

        [HttpPost]

        public async Task<ActionResult<List<GetGameDto>>> AddGame (AddGameDto newGame){


            return Ok(await _gameService.AddGame(newGame));
        }

       
        
    }
}