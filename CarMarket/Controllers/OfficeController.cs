using Microsoft.AspNetCore.Mvc;
using CarMarket.Data;
using CarMarket.Models;
using CarMarket.Services;
using System;
using System.Diagnostics;

namespace CarMarket.Controllers
{
    public class OfficeController : Controller
    {
        private readonly IOfficeService officeService;

        public OfficeController(IOfficeService officeService)
        {
            this.officeService = officeService;
        }

        public IActionResult Index()
        {
            return View(this.officeService.GetOffices());
        }

        [HttpGet]
        public IActionResult AddOffice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveOffice(Office office)
        {
            this.officeService.AddOffice(office);
            return RedirectToAction("Index");
        }

        public IActionResult GetOffice(int id)
        {
            var office = this.officeService.GetById(id);
            return View(office);
        }

        public IActionResult EditOffice(Office officeToEdit)
        {
            this.officeService.EditOffice(officeToEdit);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteOffice(int id)
        {
            this.officeService.DeleteOffice(id);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}