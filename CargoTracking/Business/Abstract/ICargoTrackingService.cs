using CargoTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Business.Abstract
{
    interface ICargoTrackingService
    {
        List<CargoT> GetAll();
        List<CargoT> GetById(int id);

    }
}
