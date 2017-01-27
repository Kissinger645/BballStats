using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BaseballDB
{
    public class BaseballContext : DbContext
    {        
        public DbSet<Team> Team { get; set; }
        public DbSet<Stat> Stat { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}
