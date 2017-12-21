using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoneyCents.Models
{
    public class Tax
    {
        public int ID { get; set; }
        public DateTime Year { get; set; }

        public DateTime LastUpdatedDate { get; set; }
        [Required]
        public int FederalWithholding { get; set; }
        [Required]
        public int FederalMEDEE { get; set; }
        [Required]
        public int FederalOASDIEE { get; set; }
        [Required]
        public int StateWithholding { get; set; }
        public int CityWithholding { get; set; }
    }
}
