using CarMarket.Data;
using CarMarket.Models;
using System.Collections.Generic;

namespace CarMarket.Services
{
    public interface IOfficeService
    {
        void AddOffice(Office officetoAdd);

        List<Office> GetOffices();

        Office GetById(int id);

        void EditOffice(Office office);

        void DeleteOffice(int id);
    }
}
