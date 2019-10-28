using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaskNote.Models
{
    public class Tarjeta
    {
        [Key] public Guid Id { get; set; }
        public Estilo estilo { get; set; }
        public String titulo { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Estado estado { get; set; }
        public String comentarios { get; set; }

        public void setEstado(Estado estado)
        { 
            this.estado = estado;
        }

    }


}
