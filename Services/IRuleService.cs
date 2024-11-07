using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Dtos.Game;
using JRMTest.Dtos.Rule;

namespace JRMTest.Services
{
    public interface IRuleService
    {

        Task<GetGameDto> AddRule (List<AddRuleDto> newRules, int gameId);
        
    }
}