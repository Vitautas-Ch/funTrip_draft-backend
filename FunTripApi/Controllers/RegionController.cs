using DataAccessLayer;
using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ORM;

namespace FunTripApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RegionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("region")]
        public IEnumerable<Region> GetRegions()
        {
            return _unitOfWork.RegionRepository.Get();
        }

        [HttpGet]
        [Route("region-name")]
        public IEnumerable<Region> FilterRegionsByName(long id)
        {
            IEnumerable<Region> filteredRegions = _unitOfWork.RegionRepository.FilterRegionsByName((region) =>
            {
                return region.Id == id;
            }, true);
            return filteredRegions;
        }
    }
}
