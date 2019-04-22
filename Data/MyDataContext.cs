using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyDataContext :DbContext
    {
        public MyDataContext()
        {

        }
        DbSet<Product> Product { get; set; }
        DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEVPC\SQL2017;Database=DiplomadoNetCoreDB;User ID=sa;Password=Malaga21;Trusted_Connection=True;");

        }



    }

   
}
