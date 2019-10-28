using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Educacion : Tarjeta
    {
        [Key] public Guid Id { get; set; }
        public Usuario asignado { get; set; }
        public String establecimiento { get; set; }
        public String aula { get; set; }
    }
}
