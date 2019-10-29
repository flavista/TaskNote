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
        public Usuario asignado { get; set; }
        public String centroDeCostos { get; set; }
        public String empresa { get; set; }
    }

}
