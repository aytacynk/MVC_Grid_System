using MVC_Grid_System.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Grid_System.BussinessLayer
{
    public class Test
    {
        Repository<Personel> repo_per = new Repository<Personel>();

        public Test()
        {
            List<Personel> perList = repo_per.List();
        }
    }
}
