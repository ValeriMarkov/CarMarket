using CarMarket.Data;
using CarMarket.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarMarket.Services
{
    public class OfficeService : IOfficeService
    {

        private readonly AppDbContext db;

        public OfficeService(AppDbContext db)
        {
            this.db = db;
        }

        public Office GetById(int id)
        {
            return this.db.Offices.FirstOrDefault(x => x.Id == id);
        }

        public void AddOffice(Office officeToAdd)
        {
            db.Offices.Add(officeToAdd);
            db.SaveChanges();
        }

        public void EditOffice(Office officeToEdit)
        {
            var editedOffice = this.GetById(officeToEdit.Id);

            editedOffice.PictureURL = officeToEdit.PictureURL;
            editedOffice.Name = officeToEdit.Name;
            editedOffice.Location = officeToEdit.Location;

        }

        public void DeleteOffice(int id)
        {
            var officeToBeDeleted = this.GetById(id);
            this.db.Offices.Remove(officeToBeDeleted);
            db.SaveChanges();
        }

        public List<Office> GetOffice()
        {
            return db.Offices.ToList();
        }
    }
}