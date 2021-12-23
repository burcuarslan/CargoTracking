using CargoTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.DataAccess.Abstract
{
    interface ICargoTrackingDal
    {
        List<CargoT> GetAll();
        void Add(CargoT cargoT);
        void Delete(CargoT cargoT);
        void Update(CargoT cargoT);
        List<CargoT> getById(int id);
    }
}
