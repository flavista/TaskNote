using System;
using System.Collections.Generic;
namespace TaskNote.Models
{
    public class Pizarra
    {
        private Guid Id { get; set; }
        private int idPizarra { get; set; }
        private TipoPizarra tipoPizarra { get; set; }
        private List<Estilo> estilos { get; set; }
        private List<Contenedor> contenedor { get; set; }
        private List<Usuario> usuario { get; set; } 
    }
}
