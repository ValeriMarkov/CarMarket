using CarMarket.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace CarMarket.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Picture URL")]
        public string Picture { get; set; }
        [Display(Name = "Brand")]
        public Brand Brand { get; set; }
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Display(Name = "Engine")]
        public double Engine { get; set; }
        [Display(Name = "Transmission")]
        public Transmission Transmission { get; set; }
        [Display(Name = "Fuel")]
        public Fuel Fuel { get; set; }
        [Display(Name = "Horse Power")]
        public int HorsePower { get; set; }
        [Display(Name = "Manufacture Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ManufactureDate { get; set; }
        [Display(Name = "Total Mileage")]
        public int TotalMileage { get; set; }
        [Display(Name = "Doors")]
        public Doors Doors { get; set; }
        [Display(Name = "Steering Wheel")]
        public SteeringWheel SteeringWheel { get; set; }
        [Display(Name = "Color")]
        public Color Color { get; set; }
        [Display(Name = "Sale Price")]
        public double SalePrice { get; set; }
    }
}
