using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRMTest.Dtos.Game
{
    public class AddGameDto
    {
        public string Name  { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;
    }
}