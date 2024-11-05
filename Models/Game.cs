using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRMTest.Models
{
    public class Game
    {
        public int Id { get; set; }

        public int FirstNumber  { get; set; } = 3;
        public string FirstWord { get; set; } = "Fizz";

        public int SecondNumner { get; set; } = 5;

        public string SecondWord { get; set;} = "Buzz";
    }
}