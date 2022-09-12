

using AnexCase.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace AnexCase.Web.Context
{

    public class AnexCaseContext : DbContext
    {
        public AnexCaseContext(DbContextOptions<AnexCaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Result> Results { get; set; }
    }
}
