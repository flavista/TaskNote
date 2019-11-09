using System;
using System.Collections.Generic;

namespace TaskNote.Models
{
    public class Contenedor
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public Guid PizarraId { get; set; }
        public virtual Pizarra Pizarra { get; set; }

        public virtual ICollection<Tarjeta> Tarjetas { get; set; }
    }
}
