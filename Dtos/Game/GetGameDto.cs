using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Dtos.Rule;

namespace JRMTest.Dtos.Game
{
    public class GetGameDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;

        public List<GetRuleDto>? Rules { get; set; }
    }
}