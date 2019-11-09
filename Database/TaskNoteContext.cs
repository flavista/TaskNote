using Microsoft.EntityFrameworkCore;
using TaskNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Models
{
    public class TaskNoteContext : DbContext
    {
        public TaskNoteContext(DbContextOptions<TaskNoteContext> options) 
            : base(options) {
        }
        public DbSet<Contenedor> Contenedors { get; set; }
        public DbSet<Pizarra> Pizarras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarjeta> Tarjetas{ get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<UsuarioPizarra> UsuarioPizarra { get; set; }

    }

}
