using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_TPFinal.Models
{
    public class Tarjeta
    {
        private Estilo estilo;
        private String titulo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Estado estado;
        private String comentarios;

        public void setEstado(Estado estado)
        { 
            this.estado = estado;
        }

    }


}
