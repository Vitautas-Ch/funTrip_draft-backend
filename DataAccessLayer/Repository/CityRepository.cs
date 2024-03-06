using DataAccessLayer.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<City> _dbSet;

        public CityRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<City>();
        }

        public IEnumerable<City> FilterCitiesByName(Func<City, bool> predicate, bool includeRegions = false)
        {
            IQueryable<City> result = _dbSet;
            if (includeRegions)
            {
                result = result.Include(x => x.Region);
            }
            var filteredCities = result.AsNoTracking().Where(predicate);
            return filteredCities;
        }
    }
}
