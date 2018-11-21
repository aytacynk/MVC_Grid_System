using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Grid_System.Entites
{
    [Table("Adresses")]
    public class Adress :EntityBase
    {
        public string Adress_Text { get; set; }
    }
}
