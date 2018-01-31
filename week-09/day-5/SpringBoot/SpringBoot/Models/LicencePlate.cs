using System.ComponentModel.DataAnnotations;

namespace SpringBoot.Models
{
    public class LicencePlate
    {
        [Key]
        public string Plate { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
    }
}
