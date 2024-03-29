﻿using CargoTrackingApp.DataAccess.Abstract;
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
        List<Tracking> _cargos;
        public Object b;
        public InMemoryCargoTracking()
        {
            String a = File.ReadAllText(@"C:\Users\burcu\source\repos\CargoTracking\CargoTracking\data.json");
             b=JsonConvert.DeserializeObject(a);
           
            _cargos = new List<Tracking>
            {
                new Tracking{ UserId=1, Name="burcu", LastName="arslan", PhoneNumber="5442276917", Email="burcuarslln@gmail.com", CargoId=1, SendingAddress="slkrghşslkjgh", ReceivingAddress="slngslkjşhflsk",CargoTrackingId=1,CargoStatus="yolda" },
                new Tracking{ UserId=2, Name="emrecan", LastName="arslan", PhoneNumber="5442276917", Email="burcuarslln@gmail.com", CargoId=2, SendingAddress="slkrghşslkjgh", ReceivingAddress="slngslkjşhflsk",CargoTrackingId=1,CargoStatus="ürün teslim edildi" }

            };
            //string json = JsonConvert.SerializeObject(_cargos.ToArray());

            ////write string to file
            //System.IO.File.WriteAllText(@"C:\Users\burcu\source\repos\CargoTracking\CargoTracking\data.json", json);


        }

        public void Add(Tracking cargoT)
        {
            _cargos.Add(cargoT);
            string json = JsonConvert.SerializeObject(_cargos.ToArray());

            //write string to file
            File.WriteAllText(@"C:\Users\burcu\source\repos\CargoTracking\CargoTracking\data.json", json);
            

        }

        public void Delete(Tracking cargoT)
        {

            Tracking cargoToDelete = _cargos.SingleOrDefault(c => c.CargoId == cargoT.CargoId);
            _cargos.Remove(cargoToDelete);
        }


        public List<Tracking> GetAll()
        {
            return _cargos;
        }


        public List<Tracking> getById(int id)
        {
            return _cargos.Where(c => c.CargoId == id).ToList();

        }


        public void Update(Tracking cargoT)
        {
            Tracking cargoUpdate = _cargos.SingleOrDefault(c => c.CargoId == cargoT.CargoId);
            cargoUpdate.CargoId = cargoT.CargoId;
            cargoUpdate.CargoStatus = cargoT.CargoStatus;
        }
    }
}