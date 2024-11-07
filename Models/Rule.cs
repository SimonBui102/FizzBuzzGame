using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JRMTest.Models
{
    public class Rule
    {
        public int Id { get; set; }
        public int Divisor { get; set; } =0;
        public string Replacement { get; set; } = string.Empty;

        
        public Game? game { get; set; }




    }
}