using System;

namespace TaskNote.Models
{
    public class UsuarioPizarra
    {
        public Guid Id { get; set; }

        public int PizarraId { get; set; }
        public Pizarra Pizarra { get; set; }

        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public bool Confirmado { get; set; }
    }
}
