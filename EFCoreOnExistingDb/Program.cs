using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreOnExistingDb
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var context = new MweDbContext(new DbContextOptionsBuilder<MweDbContext>()
                .UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=EfCoreMWE;Integrated Security=True")
                .Options);

            var foo = await context.Foos.SingleAsync(f => f.FooId == 1);

            Console.WriteLine(foo.Bar.Baz);

            return 0;
        }
    }
}
