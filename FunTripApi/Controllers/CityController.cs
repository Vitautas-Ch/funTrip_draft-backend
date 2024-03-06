using DataAccessLayer;
using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM;

namespace FunTripApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("city")]
        public IEnumerable<City> GetCities()
        {
            return _unitOfWork.CityRepository.Get();
        }

        [HttpGet]
        [Route("city-name")]
        public IEnumerable<City> FilterCitiesByName(string name)
        {
            IEnumerable<City> filteredCities = _unitOfWork.CityRepository.FilterCitiesByName((city) =>
            {
                return city.Name == name;
            }, true);
            return filteredCities;
        }
    }
}
