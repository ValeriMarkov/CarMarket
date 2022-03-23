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

        public void AddOffice(Office officetoAdd)
        {
            db.Offices.Add(officetoAdd);
            db.SaveChanges();
        }

        public void DeleteOffice(int id)
        {
            var officeToBeDeleted = this.GetById(id);
            this.db.Offices.Remove(officeToBeDeleted);
            db.SaveChanges();
        }

        public void EditOffice(Office officetoEdit)
        {
            var office = this.GetById(officetoEdit.Id);

            office.PictureURL = officetoEdit.PictureURL;
            office.Name = officetoEdit.Name;
            office.Location = officetoEdit.Location;
            office.Manager = officetoEdit.Manager;
            office.Number = officetoEdit.Number;

            db.SaveChanges();
        }

        public List<Office> GetOffices()
        {
            return db.Offices.ToList();
        }

        public Office GetById(int id)
        {
            return this.db.Offices.FirstOrDefault(x => x.Id == id);
        }
    }
}
