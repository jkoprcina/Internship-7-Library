using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Enums;
using InternshipLibrary.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipLibrary.Data.Entities
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LibraryContext"].ConnectionString);
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
