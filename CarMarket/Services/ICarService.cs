using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarMarket.Services
{
    public interface ICarService
    {
        void AddCar(Car carToAdd);

        List<Car> GetCars();

        void EditCar(Car car);

        void DeleteCar(int id);
        Car GetById(int id);
    }
}
