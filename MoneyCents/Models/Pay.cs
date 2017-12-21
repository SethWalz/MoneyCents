using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoneyCents.Models
{
    public class Pay
    {
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "Income Name")]
        public string Name { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public DateTime Year { get; set; }
        [Required]
        [Display(Name = "Gross Monthly Income")]
        public int GrossMonthlyIncome { get; set; }
        [Required]
        [Display(Name = "Gross Yearly Income")]
        public int GrossYearlyIncome { get; set; }
        [Display(Name = "Taxable Monthly Gross")]
        public int TaxableMonthlyGross { get; set; }
        [Display(Name = "Net Monthly Income")]
        public int NetMonthly { get; set; }
        [Display(Name = "Net Yearly Income")]
        public int NetYearly { get; set; }
    }
}
