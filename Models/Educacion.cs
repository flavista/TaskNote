using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Educacion : Tarjeta
    {
        public Guid ID { get; set; }
        public Usuario Asignado { get; set; }
        public String Establecimiento { get; set; }
        public String Aula { get; set; }
    }
}
