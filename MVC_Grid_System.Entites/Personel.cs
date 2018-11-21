using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Grid_System.Entites
{
    [Table("Personel")]
    public class Personel : EntityBase
    {
        [Required, StringLength(50)]
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int Yas { get; set; }

        public Country Country { get; set; }
    }
}
