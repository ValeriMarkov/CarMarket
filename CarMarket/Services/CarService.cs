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

        public Car GetById(int id)
        {
            return this.db.Cars.FirstOrDefault(x => x.Id == id);
        }

        public void AddCar(Car carToAdd)
        {
            db.Cars.Add(carToAdd);
            db.SaveChanges();
        }

        public void EditCar(Car carToEdit)
        {
            var editedCar = this.GetById(carToEdit.Id);

            editedCar.Picture = carToEdit.Picture;
            editedCar.Brand = carToEdit.Brand;
            editedCar.Model = carToEdit.Model;
            editedCar.Engine = carToEdit.Engine;
            editedCar.HorsePower = carToEdit.HorsePower;
            editedCar.ManufactureDate = carToEdit.ManufactureDate;
            editedCar.TotalMileage = carToEdit.TotalMileage;
            editedCar.Features = carToEdit.Features;
            editedCar.SalePrice = carToEdit.SalePrice;

            db.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var carToBeDeleted = this.GetById(id);
            this.db.Cars.Remove(carToBeDeleted);
            db.SaveChanges();
        }

        public List<Car> GetCar()
        {
            return db.Cars.ToList();
        }

    }
}
