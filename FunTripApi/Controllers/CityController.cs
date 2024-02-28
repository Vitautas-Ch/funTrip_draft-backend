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
        [Route("/city")]
        public IEnumerable<City> GetCities()
        {
            return _unitOfWork.CityRepository.Get();
        }

        [HttpGet]
        [Route("/city-name")]
        public IEnumerable<City> FilterCitiesByName(string name)
        {
            IEnumerable<City> filteredCities = _unitOfWork.CityRepository.Get((city) =>
            {
                return city.Name == name;
            });
            return filteredCities;
        }

        //[HttpGet]
        //[Route("/city-region")]
        //public IEnumerable<City> FilterCitiesByRegion(string region)
        //{
        //    IEnumerable<City> filteredCities = _unitOfWork.CityRepository.Get((city) =>
        //    {
        //        return city.Region?.Name == region;
        //    });
        //    return filteredCities;
        //}
    }
}
