using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FXTrader.Model;

namespace FXTrader.Repository
{
    public interface IPairRepository : IGenericRepository<Pair>
    {
        Pair GetByID(int id);
    }
}
