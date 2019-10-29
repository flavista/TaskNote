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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Pizarra>()
                .Property(p => p.TipoPizarra)
                .HasConversion(
                    v => v.ToString(),
                    v => (TipoPizarra)Enum.Parse(typeof(TipoPizarra), v));
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
