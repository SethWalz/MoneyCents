using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoneyCents.Models
{
    public class Deductions
    {
        public int ID { get; set; }
        [Required]
        public int Name { get; set; }
        public int Amount { get; set; }
        public int Percent { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
