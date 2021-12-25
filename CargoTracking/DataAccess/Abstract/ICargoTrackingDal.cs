using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.DataAccess.Abstract
{
    public interface ICargoTrackingDal
    {
        List<CargoTracking> GetAll();
        void Add(CargoTracking cargoT);
        void Delete(CargoTracking cargoT);
        void Update(CargoTracking cargoT);
        List<CargoTracking> getById(int id);
    }
}
