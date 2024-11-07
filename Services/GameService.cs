using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JRMTest.Data;
using JRMTest.Dtos.Game;
using JRMTest.Models;
using Microsoft.EntityFrameworkCore;

namespace JRMTest.Services
{
    public class GameService : IGameService
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GameService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        public async Task<List<GetGameDto>> AddGame(AddGameDto newGame)
        {
            var game = _mapper.Map<Game>(newGame);

            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            var games = await _context.Games
                        .Include(g => g.Rules)
                        .Select(g => _mapper.Map<GetGameDto>(g))
                        .ToListAsync();


            return games;
        }

        public async Task<List<GetGameDto>> GetAllGame()
        {

            var games = await _context.Games
                        .Include(g=> g.Rules)
                        .Select(g => _mapper.Map<GetGameDto>(g))
                        .ToListAsync();

           

            return games;
        }

        public async Task<GetGameDto> GetGameById(int GameId)
        {

            var game = await _context.Games
                .Include(g=> g.Rules)
                .FirstOrDefaultAsync(g => g.Id == GameId);
            var result = _mapper.Map<GetGameDto>(game);
            return result;
        }
    }
}