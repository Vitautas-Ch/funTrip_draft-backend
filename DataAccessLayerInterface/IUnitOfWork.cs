using DataAccessLayer.Interface.Repository;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Region> RegionRepository { get; }
        IGenericRepository<ImageRegion> ImageRegionRepository { get; }

        IGenericRepository<City> CityRepository { get; }
        IGenericRepository<ImageCity> ImageCityRepository { get; }

        IGenericRepository<Place> PlaceRepository { get; }
        IGenericRepository<ImagePlace> ImagePlaceRepository { get; }
        IGenericRepository<TypePlace> TypePlaceRepository { get; }

        void Save();
    }
}
