using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class Estilo
    {
        public Guid ID { get; set; }
        public String font { get; set; }
        public String fondo { get; set; }
        public String theme { get; set; }

        public Guid PizarraId;
        public virtual Pizarra Pizarra { get; set; }
    }
}
