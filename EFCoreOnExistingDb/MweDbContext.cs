using EFCoreOnExistingDb.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreOnExistingDb
{
    public class MweDbContext : DbContext
    {
        public MweDbContext(DbContextOptions<MweDbContext> options) : base(options)
        {
        }

        public DbSet<Foo> Foos { get; set; }

        public DbSet<Bar> Bars { get; set; }
    }
}