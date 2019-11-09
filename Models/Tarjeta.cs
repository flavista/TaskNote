using System;

namespace TaskNote.Models
{
    public class Tarjeta
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }

        public Guid ContenedorId { get; set; }
        public virtual Contenedor Contenedor { get; set; }
    }
}
