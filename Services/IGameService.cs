using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Dtos.Game;
using JRMTest.Models;

namespace JRMTest.Services
{
    public interface IGameService
    {
        Task<List<GetGameDto>> GetAllGame();
        Task<GetGameDto> GetGameById(int GameId);

        Task<List<GetGameDto>> AddGame(AddGameDto newGame);
        
        
    }
}