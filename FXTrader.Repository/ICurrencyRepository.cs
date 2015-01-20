using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FXTrader.Model;

namespace FXTrader.Repository
{
    public interface ICurrencyRepository : IGenericRepository<Currency>
    {
        /// <summary>
        /// Get Currency By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Currency specified by it's id</returns>
        Currency GetById(int id);

    }
}
