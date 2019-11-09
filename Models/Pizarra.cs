using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaskNote.Models;

namespace TaskNote.Models

{ 
    public class Pizarra
    {
        public Guid ID { get; set; }
        public String Nombre { get; set; }
        public ICollection<Contenedor> Contenedor { get; set; }
        public virtual ICollection<UsuarioPizarra> UsuarioPizarra { get; set; }
        

    }
}
