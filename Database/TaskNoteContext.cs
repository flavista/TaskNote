using Microsoft.EntityFrameworkCore;

namespace TaskNote.Models
{
    public class TaskNoteDbContext : DbContext
    {
        public TaskNoteDbContext(DbContextOptions<TaskNoteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contenedor> Contenedores { get; set; }
        public DbSet<Pizarra> Pizarras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<UsuarioPizarra> UsuariosPizarra { get; set; }
    }
}
