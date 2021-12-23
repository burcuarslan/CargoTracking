using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Entity.Concrete
{
    public class Cargo:Customer
    {
        public int CargoId { get; set; }
        public String SendingAddress { get; set; }
        public String ReceivingAddress { get; set; }

    }
}
