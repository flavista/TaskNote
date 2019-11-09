using System;
using System.ComponentModel.DataAnnotations;

namespace TaskNote.Models
{
    public class Login
    {
        public Guid Id { get; set; }

        public string NombreUsuario { get; set; }

        [DataType(DataType.Password)]
        public byte[] Password { get; set; }
    }
}