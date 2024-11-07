using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Dtos.Game;
using JRMTest.Dtos.Rule;
using Microsoft.AspNetCore.Mvc;

namespace JRMTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RuleController: ControllerBase
    {

        private readonly IRuleService _ruleService;

        public RuleController(IRuleService ruleService)
        {
            _ruleService = ruleService;
            
        }

        [HttpPost]
        public async Task<ActionResult<GetGameDto>> AddRule (List<AddRuleDto> newRules, int gameId){

            return Ok(await _ruleService.AddRule(newRules, gameId));
        }
        
    }
}