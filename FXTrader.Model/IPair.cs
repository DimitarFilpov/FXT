using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXTrader.Model
{
    public interface IPair
    {
        string Title { get; set; }
        double Commission { get; set; }
        double Miltiplier { get; set; }
        double Increment { get; set; }
        double MaxChange { get; set; }
        int CurrencyId { get; set; }
        Currency Currency { get; set; }

    }
}
