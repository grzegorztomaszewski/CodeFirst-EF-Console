using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst_EF_Console.Models
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            :base ("DefaultConnection")
        {
            Database.Initialize(false);
        }
        public DbSet<Album> Albums { get; set; }
    }
}
