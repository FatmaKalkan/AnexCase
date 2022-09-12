using AnexCase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnexCase.Context
{
    public class AnexCaseContext : DbContext
    {
        public AnexCaseContext()
            : base("name=AnexCaseConstr")
        {
           
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
