using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreOnExistingDb
{
    public class DesignTimeMweDbContextFactory : IDesignTimeDbContextFactory<MweDbContext>
    {
        public MweDbContext CreateDbContext(string[] args)
            => new MweDbContext(new DbContextOptionsBuilder<MweDbContext>()
                .UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=EfCoreMWE;Integrated Security=True")
                .Options);
    }
}