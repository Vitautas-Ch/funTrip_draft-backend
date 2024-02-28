using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM;

namespace FunTripApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypePlaceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TypePlaceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("/type-place")]
        public IEnumerable<TypePlace> GetTypePlaces()
        {
            return _unitOfWork.TypePlaceRepository.Get();
        }
    }
}
