using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class Empresa : Tarjeta
    {
        private Guid Id { get; set; }
        private Usuario asignado { get; set; }
        private String centroDeCostos { get; set; }
        private String empresa { get; set; }
    }

}
