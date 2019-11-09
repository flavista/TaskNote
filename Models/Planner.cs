using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TaskNote.Models
{
    public class Planner
    {
        public Guid Id { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
