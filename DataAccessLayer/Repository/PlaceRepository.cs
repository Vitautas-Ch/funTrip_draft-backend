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
    public class PlaceRepository : GenericRepository<Place>, IPlaceRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Place> _dbSet;

        public PlaceRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Place>();
        }
        public IEnumerable<Place> FilterPlacesByCity(Func<Place, bool> predicate, bool includeCities = false)

        {
            IQueryable<Place> result = _dbSet;

            if (includeCities)
            {
                result = result.Include(x => x.City);
            }
            var filteredPlaces = result.AsNoTracking().Where(predicate);
            return filteredPlaces;
        }
    }
}