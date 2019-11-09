using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaskNote.Models
{
    public class Tarjeta
    {
        public Guid ID { get; set; }
        public String Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public String Descripcion { get; set; }

        public Guid ContenedorID { get; set; }
        public virtual Contenedor Contenedor { get; set; }
        

    }


}
