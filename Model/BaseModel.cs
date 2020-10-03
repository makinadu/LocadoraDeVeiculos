using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.Model
{
    class BaseModel
    {
        public BaseModel() => CriadoEm = DateTime.Now;
        [Key]
        public int ID { get; set; }

        public DateTime CriadoEm { get; set; } 
    }
}
