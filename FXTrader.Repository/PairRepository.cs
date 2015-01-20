using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FXTrader.Model;

namespace FXTrader.Repository
{
    public class PairRepository : GenericRepository<Pair>, IPairRepository
    {
        public PairRepository(DbContext context)
            : base(context)
        {
        }

        public override IEnumerable<Pair> GetAll()
        {
            return _entities.Set<Pair>().Include(x => x.Currency).AsEnumerable();
        }
        public Pair GetById(int id)
        {
            return _dbset.Include(x => x.Currency).Where(x => x.Id == id).FirstOrDefault();
            
        }
        
    }
}
