using System;
using System.Collections.Generic;

namespace TaskNote.Models
{
    public class Pizarra
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Contenedor> Contenedores { get; set; }
        public virtual ICollection<UsuarioPizarra> UsuariosPizarra { get; set; }
    }
}