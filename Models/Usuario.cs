using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public String NombreApellido { get; set; }
        public int IdUsuario { get; set; }
        public String Email { get; set; }
        public DateTime Nacimiento { get; set; }
        public String NombreUsuario { get; set; }
        public String Contrasenia { get; set; }

        public Guid PizarraId;
        public virtual Pizarra Pizarra { get; set; }
    }


}
