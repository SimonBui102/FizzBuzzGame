using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Data;
using JRMTest.Models;
using Microsoft.EntityFrameworkCore;

namespace JRMTest.Services
{
    public class GameService : IGameService
    {

        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
            
        }
        public async Task<List<Game>> GetAllGame()
        {

            var games = await _context.Games
                        .Include(g=> g.Rules).ToListAsync();

            return games;
        }
    }
}