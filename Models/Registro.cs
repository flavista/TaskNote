using System.ComponentModel.DataAnnotations;

namespace TaskNote.Models
{
    public class Registro
    {
        [Required, MaxLength(256)]
        public string NombreUsuario { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmarContrasenia { get; set; }
    }
}
