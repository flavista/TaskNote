using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public String nombreApellido { get; set; }
        public int idUsuario { get; set; }
        public String email { get; set; }
        public DateTime nacimiento { get; set; }
        public String nombreUsuario { get; set; }
        public String contrasenia { get; set; }

        public Guid PizarraId;
        public virtual Pizarra Pizarra { get; set; }
    }


}
