using CarMarket.Models;
using CarMarket.Services;
using Microsoft.AspNetCore.Mvc;

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
            return View(this.officeService.GetOffice());
        }

        public IActionResult GetOffice(int id)
        {
            var office = this.officeService.GetById(id);
            return View(office);
        }

        [HttpGet]
        public IActionResult AddOffice()
        {
            return View();
        }

        public IActionResult EditOffice(Office office)
        {
            this.officeService.EditOffice(office);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteOffice(int id)
        {
            this.officeService.DeleteOffice(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SaveOffice(Office office)
        {
            this.officeService.AddOffice(office);
            return RedirectToAction("Index");
        }
    }
}