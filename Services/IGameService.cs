using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Models;

namespace JRMTest.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGame();
        
        
    }
}