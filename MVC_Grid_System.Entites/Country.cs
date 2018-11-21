using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Grid_System.Entites
{
    [Table("Countries")]
    public class Country : EntityBase
    {
        [Required, StringLength(100)]
        public string CountryName { get; set; }

        public List<Personel> Personeller { get; set; }

    }
}
