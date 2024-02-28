using DataAccessLayer.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DataAccessLayer.Repository
//{
//    public class UserRepository : GenericRepository<User>, IUserRepository
//    {
//        private readonly DbContext _context;
//        private readonly DbSet<User> _dbSet;

//        public UserRepository(DbContext context) : base(context)
//        {
//            _context = context;
//            _dbSet = _context.Set<User>();
//        }


//        public IEnumerable<User> FilterUsers(Func<User, bool> predicate, bool includeRoles = false)
//        {
//            IQueryable<User> result = _dbSet;
//            if (includeRoles)
//            {
//                result = result.Include(x => x.Role);
//            }
//            var filteredUsers = result.Where(predicate);
//            return filteredUsers;
//        }


//    }
//}
