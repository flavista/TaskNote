using System;
using System.Collections.Generic;

namespace TaskNote.Models
{
    public class Usuario
    {
        private Guid Id { get; set; }
        private String nombreApellido { get; set; }
        private int idUsuario { get; set; }
        private String email { get; set; }
        private DateTime nacimiento { get; set; }
        private String nombreUsuario { get; set; }
        private String contrasenia { get; set; }
        private List<Pizarra> pizarras { get; set; }
    }


}
