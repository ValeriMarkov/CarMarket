using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }
        public string PictureURL { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}