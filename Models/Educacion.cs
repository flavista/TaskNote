using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class Educacion : Tarjeta
    {
        private Guid Id { get; set; }
        private Usuario asignado { get; set; }
        private String establecimiento { get; set; }
        private String aula { get; set; }
    }
}
