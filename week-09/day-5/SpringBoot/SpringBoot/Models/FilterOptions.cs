using System.ComponentModel.DataAnnotations;

namespace SpringBoot.Models
{
    public class FilterOptions
    {
        [MaxLength(7)]
        public string Q { get; set; }
        public int Police { get; set; }
        public int Diplomat { get; set; }
    }
}
