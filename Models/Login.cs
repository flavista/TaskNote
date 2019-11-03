using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class Login
    {
        public string NombreUsuario { get; set; }

        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

        public string ReturnUrl { get; set; }

    }
}



