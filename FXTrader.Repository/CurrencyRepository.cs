using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FXTrader.Model;

namespace FXTrader.Repository
{
    public class CurrencyRepository : GenericRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(DbContext context)
            : base(context)
        {
        }
        

        #region ICurrencyRepository Members

        /// <summary>
        /// Get's Currency by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Currency Object</returns>
        public Currency GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }

        #endregion
    }
}
