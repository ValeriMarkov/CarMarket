using CarMarket.Models;
using System.Collections.Generic;

namespace CarMarket.Services
{
    public interface IOfficeService
    {
        void AddOffice(Office officeToAdd);

        List<Office> GetOffice();

        void EditOffice(Office office);

        void DeleteOffice(int id);
        Office GetById(int id);
    }
}
