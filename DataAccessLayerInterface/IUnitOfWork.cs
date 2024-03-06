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
        IRegionRepository RegionRepository { get; }
        IGenericRepository<ImageRegion> ImageRegionRepository { get; }

        ICityRepository CityRepository { get; }
        IGenericRepository<ImageCity> ImageCityRepository { get; }

        IPlaceRepository PlaceRepository { get; }
        IGenericRepository<ImagePlace> ImagePlaceRepository { get; }
        IGenericRepository<TypePlace> TypePlaceRepository { get; }

        void Save();
    }
}
