using CarMarket.Models;
using System.Collections.Generic;

namespace CarMarket.Services
{
    public interface ICarService
    {
        void AddCar(Car carToAdd);

        List<Car> GetCar();

        void EditCar(Car carToEdit);

        void DeleteCar(int id);
        Car GetById(int id);
    }
}
