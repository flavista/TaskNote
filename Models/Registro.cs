using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class Registro
    {
        [Required, MaxLength(256)]
        public string NombreUsuario { get; set; }

        [Required, DataType(DataType.Password)]
        public string Contrasenia { get; set; }

        [DataType(DataType.Password), Compare(nameof(Contrasenia))]
        public string ConfirmarContrasenia { get; set; }
    }
}
