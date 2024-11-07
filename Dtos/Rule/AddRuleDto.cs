using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRMTest.Dtos.Rule
{
    public class AddRuleDto
    {
        public int Divisor { get; set; } 
        public string Replacement { get; set; } = string.Empty;

         
    }
}