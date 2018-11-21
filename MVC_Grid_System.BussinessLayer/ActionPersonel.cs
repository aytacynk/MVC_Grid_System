using MVC_Grid_System.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Grid_System.BussinessLayer
{
    public class ActionPersonel
    {
        Repository<Personel> repo_per = new Repository<Personel>();

        public List<Personel> GetPersonels()
        {
            List<Personel> Personel_List = repo_per.List();
            return Personel_List;
        }
    }
}
