using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskNote.Models

{
    public class Pizarra
    {
        [Key] public Guid Id { get; set; }
        public TipoPizarra tipoPizarra { get; set; }
        public List<Estilo> estilos { get; set; }
        public List<Contenedor> contenedor { get; set; }
        public List<Usuario> usuario { get; set; }
    }
}
