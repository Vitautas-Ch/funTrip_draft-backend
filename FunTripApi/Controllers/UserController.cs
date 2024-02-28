using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//namespace FunTripApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;

//        public UserController(IUnitOfWork unitOfWork)
//        {
//            _unitOfWork = unitOfWork;
//        }

//        [HttpGet]
//        [Route("/filter")]

//        public IEnumerable<User> FilterUsersByName(string name)
//        {
//            IEnumerable<User> filteredUsers = _unitOfWork.UserRepository.Get((user) =>
//             {
//                 return user.Name == name;

//             });
//            return filteredUsers;
//        }
//    }
//}
