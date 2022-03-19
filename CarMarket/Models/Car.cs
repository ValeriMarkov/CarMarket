using CarMarket.Data;
using CarMarket.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Picture { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public double Engine { get; set; }
        public int HorsePower { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ManufactureDate { get; set; }
        public int TotalMileage { get; set; }
        public string Description { get; set; }
        public double SalePrice { get; set; }

        public List<Features> Features { get; set; }
    }
}
