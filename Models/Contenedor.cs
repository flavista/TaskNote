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
        public List<Tarjeta> Tarjetas { get; set; }

        public Guid PizarraId;
        public virtual Pizarra Pizarra { get; set; }
    }
}
