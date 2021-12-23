using CargoTracking.Entity.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.DataAccess.Abstract
{
    public class InMemoryCargoTracking : ICargoTrackingDal
    {
        List<CargoT> cargos;
        public InMemoryCargoTracking()
        {
           cargos= new List<CargoT>
           {
                new CargoT{UserId=1,Name="burcu",LastName="arslan",PhoneNumber="5442276917",Email="burcuarslln@gmail.com",Password="12345",CargoId=1,SendingAddress="slkrghşslkjgh", ReceivingAddress="slngslkjşhflsk",CargoStatus="yolda"}

           };
            string json = JsonConvert.SerializeObject(cargos.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"D:\path.txt", json);

        }
        
        

        public void Add(CargoT cargoT)
        {
            cargos.Add(cargoT);
            

        }

        public void Delete(CargoT cargoT)
        {

            CargoT cargoToDelete = cargos.SingleOrDefault(c => c.CargoId == cargoT.CargoId);
            cargos.Remove(cargoToDelete);
        }


        public List<CargoT> GetAll()
        {
            return cargos;
        }

        public List<CargoT> getById(int id)
        {
            return cargos.Where(c => c.CargoId == id).ToList();
           
        }

        public void Update(CargoT cargoT)
        {
            throw new NotImplementedException();
        }
    }
}
