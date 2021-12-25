using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Business.Abstract
{
    public interface ICargoTrackingService
    {
        List<CargoTracking> GetAll();
        List<CargoTracking> GetById(int id);
        void Add(CargoTracking cargoT);
        void Delete(CargoTracking cargoT);
        void Update(CargoTracking cargoT);

    }
}
