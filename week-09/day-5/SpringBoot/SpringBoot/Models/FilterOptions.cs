using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
