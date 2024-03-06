using DataAccessLayer;
using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM;

namespace FunTripApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlaceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("place")]
        public IEnumerable<Place> GetPlaces()
        {
            return _unitOfWork.PlaceRepository.Get();
        }

        [HttpGet]
        [Route("city-place")]
        public IEnumerable<Place> FilterPlacesByCity(long id)
        {
            IEnumerable<Place> filteredPlaces = _unitOfWork.PlaceRepository.FilterPlacesByCity((place) =>
            {
                return place.City?.Id == id;
            }, true);
            return filteredPlaces;
        }
    }
}
