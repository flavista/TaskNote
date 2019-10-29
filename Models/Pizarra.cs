using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaskNote.Models;

namespace TaskNote.Models

{ 
    public enum TipoPizarra { Empresa, Personal, Educacion }
    public class Pizarra
    {
        public Guid ID { get; set; }
        public TipoPizarra TipoPizarra { get; set; }
        public List<Estilo> Estilos { get; set; }
        public List<Contenedor> Contenedor { get; set; }
        public List<Usuario> Usuario { get; set; }


    }
}
