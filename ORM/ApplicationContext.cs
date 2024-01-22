using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Regions> Regions { get; set; }
        public DbSet<ImageRegions> ImageRegions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FunTripDb;Trusted_Connection=True;");
        }
        //public ApplicationContext() { }
    }
}
