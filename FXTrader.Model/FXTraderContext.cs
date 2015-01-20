using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXTrader.Model
{
    public class FXTraderContext : DbContext
    {

        public FXTraderContext()
            : base("Name=FXTraderContext")
        {

        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Pair> Pairs {get; set;}

        public override int SaveChanges()
        {
            
            return base.SaveChanges();
        }

    }
}
