using Microsoft.EntityFrameworkCore;
using PNT1_TPFinal.Models;
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

    }

}
