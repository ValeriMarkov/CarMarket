using CarMarket.Models;
using CarMarket.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CarMarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        public IActionResult Index()
        {
            return View(this.carService.GetCars());
        }

        public IActionResult GetCar(int id)
        {
            var car = this.carService.GetById(id);
            return View(car);
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveCar(Car car)
        {
            this.carService.AddCar(car);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditCar(Car carToEdit)
        {
            this.carService.EditCar(carToEdit);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCar(int id)
        {
            this.carService.DeleteCar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var carDetails = this.GetCar(id);
            if (carDetails == null) return View("Empty");
                return View("Details");
        }
    }
}