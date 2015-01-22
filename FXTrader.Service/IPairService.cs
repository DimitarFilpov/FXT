using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FXTrader.Model;

namespace FXTrader.Service
{
    public interface IPairService : IEntityService<Pair>
    {
        Pair GetById(int id);
    }
}
