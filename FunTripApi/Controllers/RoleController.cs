using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM;

//namespace FunTripApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RoleController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        public RoleController(IUnitOfWork unitOfWork) 
//        {
//            _unitOfWork = unitOfWork;
//        }

//        [HttpGet]
//        [Route("/all")]
//        public IEnumerable<Role> GetRoles()
//        {
//           return _unitOfWork.RoleRepository.Get();
//        }
//    }
//}
