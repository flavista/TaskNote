using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public DateTime Nacimiento { get; set; }
        public String NombreUsuario { get; set; }
        public String Password { get; set; }
        public virtual ICollection<UsuarioPizarra> UsuarioPizarra{ get; set; }




    }
}