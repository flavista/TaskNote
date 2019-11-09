using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;




namespace TaskNote.Models
{
    public class Contenedor
    {
        public Guid ID { get; set; }
        public String Nombre { get; set; }
        public ICollection<Tarjeta> Tarjetas { get; set; }

        public Guid PizarraId { get; set; }
        public virtual Pizarra Pizarra { get; set; }
    }
}
