using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class Tarjeta
    {
        private Guid Id { get; set; }
        private Estilo estilo { get; set; }
        private String titulo { get; set; }
        private DateTime fechaInicio { get; set; }
        private DateTime fechaFin { get; set; }
        private Estado estado { get; set; } 
        private String comentarios { get; set; }

        public void setEstado(Estado estado)
        { 
            this.estado = estado;
        }

    }


}
