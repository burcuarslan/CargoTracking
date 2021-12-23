using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Entity.Concrete
{
    public class CargoT:Cargo
    {
        public int CargoTrackingId { get; set; }
        public String CargoStatus { get; set; }
    }
}
