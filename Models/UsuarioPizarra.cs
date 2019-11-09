using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class UsuarioPizarra
    {
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("PizarraID")]
        public int PizarraId { get; set; }
        public Pizarra Pizarra { get; set; }

        [ForeignKey("UsuarioID")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public Boolean Estado { get; set; }
    }
}
