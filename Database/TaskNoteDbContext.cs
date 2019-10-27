using Microsoft.EntityFrameworkCore;
using TaskNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskNote.Database
{
    public class TaskNoteDbContext : DbContext
    {
        public TaskNoteDbContext(DbContextOptions<TaskNoteDbContext> options) : base(options) {
        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarjeta> Tarjetas{ get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<Personal> Personals{ get; set; }
        public DbSet<Estilo> Estilos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Educacion> Educaciones { get; set; }

    }

}
