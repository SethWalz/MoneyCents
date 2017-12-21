using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyCents.Models
{
    public class Expenses
    {        
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Catagory { get; set; }
        public int Budgeted { get; set; }
        public int Actual { get; set; }
        public int Percent { get; set; }
        public DateTime LastUpdatedDate { get; set; }

    }
}
