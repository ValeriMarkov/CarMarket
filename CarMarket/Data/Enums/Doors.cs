using System.ComponentModel.DataAnnotations;

namespace CarMarket.Data
{
    public enum Doors
    {
        [Display(Name = "2/3")]
        TwoThree = 1,
        [Display(Name = "4/5")]
        FourFive,
    }
}
