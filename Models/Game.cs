using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRMTest.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string .Empty;

        public List<Rule>? Rules { get; set; }  
    }
}