using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaskNote.Models
{
    public class Empresa : Tarjeta
    {
        public Guid ID { get; set; }
        public Usuario Asignado { get; set; }
        public String CentroDeCostos { get; set; }
    }

}
