using CargoTracking.Business.Abstract;
using CargoTracking.DataAccess.Abstract;
using CargoTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Business.Concrete
{
    class CargoTrackingManager : ICargoTrackingService
    {
        ICargoTrackingDal _cargoDal;
        public CargoTrackingManager(ICargoTrackingDal cargoDal)
        {
            _cargoDal = cargoDal;
        }
        public List<CargoT> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CargoT> GetById(int id)
        {
            return _cargoDal.getById(id);
        }
    }
}
