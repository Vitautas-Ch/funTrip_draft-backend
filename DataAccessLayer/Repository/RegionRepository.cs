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
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Region> _dbSet;

        public RegionRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Region>();
        }

        public IEnumerable<Region> FilterRegionsByName(Func<Region, bool> predicate, bool includeCities)
        {
            IQueryable<Region> result = _dbSet;
            if (includeCities)
            {
                result = result.Include(x => x.Cities);
            }
            var filteredRegions = result.Where(predicate);
            return filteredRegions;
        }
    }
}
