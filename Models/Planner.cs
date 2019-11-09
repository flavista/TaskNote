using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Planner
    {
        public Guid ID { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}
