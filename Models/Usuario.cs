using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public String NombreApellido { get; set; }
        public String Email { get; set; }
        public DateTime Nacimiento { get; set; }
        public String NombreUsuario { get; set; }
        public String Password { get; set; }

        public Guid PizarraId { get; set; }
        public virtual Pizarra Pizarra { get; set; }
    }


}
