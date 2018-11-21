using MVC_Grid_System.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Grid_System.DataAccessLayer
{
    public class DatabaseContex : DbContext
    {
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        public DatabaseContex()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
