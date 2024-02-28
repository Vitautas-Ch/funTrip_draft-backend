using DataAccessLayer.Interface;
using DataAccessLayer.Interface.Repository;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        private IRegionRepository? regionRepository;
        private IGenericRepository<ImageRegion>? imageRegionRepository;

        private IGenericRepository<City>? cityRepository;
        private IGenericRepository<ImageCity>? imageCityRepository;

        private IGenericRepository<Place>? placeRepository;
        private IGenericRepository<ImagePlace>? imagePlaceRepository;
        private IGenericRepository<TypePlace>? typePlaceRepository;

        public IRegionRepository RegionRepository
        {
            get
            {
                regionRepository ??= new RegionRepository(_context);
                return regionRepository;
            }
        }
        public IGenericRepository<ImageRegion> ImageRegionRepository
        {
            get
            {
                imageRegionRepository ??= new GenericRepository<ImageRegion>(_context);
                return imageRegionRepository;
            }
        }
        public IGenericRepository<City> CityRepository
        {
            get
            {
                cityRepository ??= new GenericRepository<City>(_context);
                return cityRepository;
            }
        }
        public IGenericRepository<ImageCity> ImageCityRepository
        {
            get
            {
                imageCityRepository ??= new GenericRepository<ImageCity>(_context);
                return imageCityRepository;
            }
        }
        public IGenericRepository<Place> PlaceRepository
        {
            get
            {
                placeRepository ??= new GenericRepository<Place>(_context);
                return placeRepository;
            }
        }
        public IGenericRepository<ImagePlace> ImagePlaceRepository
        {
            get
            {
                imagePlaceRepository ??= new GenericRepository<ImagePlace>(_context);
                return imagePlaceRepository;
            }
        }
        public IGenericRepository<TypePlace> TypePlaceRepository
        {
            get
            {
                typePlaceRepository ??= new GenericRepository<TypePlace>(_context);
                return typePlaceRepository;
            }
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
