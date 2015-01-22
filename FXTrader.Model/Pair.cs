using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FXTrader.Model
{
    public class Pair : Entity<int>, IPair
    {
        #region IPair Members

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public double Commission { get; set; }
        
        [Required]
        public double Miltiplier { get; set; }

        [Required]
        public double Increment { get; set; }

        [Required]
        public double MaxChange { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual Currency Currency { get; set; }

        #endregion
    }
    
}
