using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JRMTest.Data;
using JRMTest.Dtos.Game;
using JRMTest.Dtos.Rule;
using JRMTest.Models;
using Microsoft.EntityFrameworkCore;

namespace JRMTest.Services
{
    public class RuleService : IRuleService
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public RuleService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }
        public async Task<GetGameDto> AddRule(List<AddRuleDto> newRulesDto, int gameId)
        {

            var currentGame = await _context.Games.FirstOrDefaultAsync( g => g.Id == gameId );


            foreach(AddRuleDto newRuleDto in newRulesDto){

                var rule = new Rule {
                    Divisor = newRuleDto.Divisor,
                    Replacement = newRuleDto.Replacement,
                    game = currentGame

                };

                _context.Rules.Add(rule);

            }

            await _context.SaveChangesAsync();

            
            var result = _mapper.Map<GetGameDto>(currentGame);

           return result;
        }
    }
}