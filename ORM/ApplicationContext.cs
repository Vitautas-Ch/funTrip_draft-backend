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
        public DbSet<Region> Regions { get; set; }
        public DbSet<ImageRegion> ImageRegions { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<ImageCity> ImageCities { get; set; }

        public DbSet<Place> Places { get; set; }
        public DbSet<TypePlace> TypePlaces { get; set; }
        public DbSet<ImageCity> ImagePlaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FunTripDb;Trusted_Connection=True;AttachDbFilename=|DataDirectory|mydbfile.mdf;");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FunTripDb;Trusted_Connection=True;AttachDbFilename=|DataDirectory|\mydbfile.mdf;");
        }
        //public ApplicationContext() { }
    }
}