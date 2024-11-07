using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Models;
using Microsoft.EntityFrameworkCore;

namespace JRMTest.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Rule> Rules { get; set; }
        
    }
}