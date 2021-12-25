using CargoTrackingApp.DataAccess.Abstract;
using CargoTrackingApp.Entity.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CargoTrackingApp.DataAccess.Concrete
{
    public class InMemoryCargoTracking : ICargoTrackingDal
    {
        List<CargoTracking> _cargos;
        public Object b;
        public InMemoryCargoTracking()
        {
            String a = File.ReadAllText(@"C:\Users\burcu\source\repos\CargoTracking\CargoTracking\data.json");
             b=JsonConvert.DeserializeObject(a);
           
            _cargos = new List<CargoTracking>
            {
                new CargoTracking{ UserId=1, Name="burcu", LastName="arslan", PhoneNumber="5442276917", Email="burcuarslln@gmail.com", Password="12345", CargoId=1, SendingAddress="slkrghşslkjgh", ReceivingAddress="slngslkjşhflsk",CargoTrackingId=1,CargoStatus="yolda" },
                new CargoTracking{ UserId=2, Name="emrecan", LastName="arslan", PhoneNumber="5442276917", Email="burcuarslln@gmail.com", Password="12345", CargoId=2, SendingAddress="slkrghşslkjgh", ReceivingAddress="slngslkjşhflsk",CargoTrackingId=1,CargoStatus="ürün teslim edildi" }

            };
            //string json = JsonConvert.SerializeObject(_cargos.ToArray());

            ////write string to file
            //System.IO.File.WriteAllText(@"C:\Users\burcu\source\repos\CargoTracking\CargoTracking\data.json", json);


        }

        public void Add(CargoTracking cargoT)
        {
            _cargos.Add(cargoT);
            string json = JsonConvert.SerializeObject(_cargos.ToArray());

            //write string to file
            File.WriteAllText(@"C:\Users\burcu\source\repos\CargoTracking\CargoTracking\data.json", json);
            

        }

        public void Delete(CargoTracking cargoT)
        {

             CargoTracking cargoToDelete = _cargos.SingleOrDefault(c => c.CargoId == cargoT.CargoId);
            _cargos.Remove(cargoToDelete);
        }


        public List<CargoTracking> GetAll()
        {
            return _cargos;
        }


        public List<CargoTracking> getById(int id)
        {
            return _cargos.Where(c => c.CargoId == id).ToList();

        }


        public void Update(CargoTracking cargoT)
        {
            CargoTracking cargoUpdate = _cargos.SingleOrDefault(c => c.CargoId == cargoT.CargoId);
            cargoUpdate.CargoId = cargoT.CargoId;
            cargoUpdate.CargoStatus = cargoT.CargoStatus;
        }
    }
}