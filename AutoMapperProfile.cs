using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JRMTest.Dtos.Game;
using JRMTest.Dtos.Rule;
using JRMTest.Models;

namespace JRMTest
{
    public class AutoMapperProfile:Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Game,GetGameDto>();
            CreateMap<Rule,GetRuleDto>();
            CreateMap<AddGameDto,Game>();

        }
        
    }
}