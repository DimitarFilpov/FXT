using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXTrader.Model
{
    public class Currency : Entity<int>
    {
        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Abbreviation(€, £, $)")]
        public string Abbreviation { get; set; }
        
        [Required]
        public int Decimals { get; set; }

    }
}
