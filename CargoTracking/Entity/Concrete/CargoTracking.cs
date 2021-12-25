using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Entity.Concrete
{
    public class CargoTracking:Cargo
    {
        public int CargoTrackingId { get; set; }
        public String CargoStatus { get; set; }
        public CargoTracking()
        {

        }
        public CargoTracking(int UserId,String Name,String LastName,String PhoneNumber,String Email,String Password,int CargoId,String SendingAddress, String ReceivingAddress, int CargoTrackingId,string CargoStatus): base(UserId, Name, LastName, PhoneNumber,Email,Password,CargoId,SendingAddress,ReceivingAddress)
        {
            this.CargoTrackingId = CargoTrackingId;
            this.CargoStatus = CargoStatus;
        }
    }
}
