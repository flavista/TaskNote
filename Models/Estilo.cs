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
        public String Font { get; set; }
        public String Fondo { get; set; }
        public String Theme { get; set; }

        public Guid PizarraId { get; set; }
        public virtual Pizarra Pizarra { get; set; }
    }
}
