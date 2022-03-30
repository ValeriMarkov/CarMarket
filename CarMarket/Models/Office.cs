using System.ComponentModel.DataAnnotations;

namespace CarMarket.Models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Picture Url")]
        public string PictureURL { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Manager")]
        public string Manager { get; set; }
        [Display(Name = "Phone Number")]
        public int Number { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}