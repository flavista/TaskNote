using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskNote.Models;

namespace TaskNote.Database
{
    public static class DbInitializer
    {
        public static void Initialize(TaskNoteDbContext context)
        {

            context.Database.EnsureCreated();
            if (context.Pizarras.Any())
            {
                return;   // DB has been seeded
            }
        }
    }
}
