using CarMarket.Data;
using CarMarket.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarMarket.Services
{
    public class CarService : ICarService
    {
        private readonly AppDbContext db;

        public CarService(AppDbContext db)
        {
            this.db = db;
        }
        public void AddCar(Car cartoAdd)
        {
            db.Cars.Add(cartoAdd);
            db.SaveChanges();
        }

        public Car GetById(int id)
        {
            return this.db.Cars.FirstOrDefault(x => x.Id == id);
        }


        public void EditCar(Car cartoEdit)
        {
            var editedCar = this.GetById(cartoEdit.Id);

            editedCar.Picture = cartoEdit.Picture;
            editedCar.Brand = cartoEdit.Brand;
            editedCar.Model = cartoEdit.Model;
            editedCar.Engine = cartoEdit.Engine;
            editedCar.HorsePower = cartoEdit.HorsePower;
            editedCar.ManufactureDate = cartoEdit.ManufactureDate;
            editedCar.TotalMileage = cartoEdit.TotalMileage;
            editedCar.Features = cartoEdit.Features;
            editedCar.SalePrice = cartoEdit.SalePrice;

            db.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var carToBeDeleted = this.GetById(id);
            this.db.Cars.Remove(carToBeDeleted);
            db.SaveChanges();
        }

        public List<Car> GetCars()
        {
            return db.Cars.ToList();
        }

    }
}
