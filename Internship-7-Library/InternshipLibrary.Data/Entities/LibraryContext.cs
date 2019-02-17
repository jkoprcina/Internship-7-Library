using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace InternshipLibrary.Data.Entities
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SchoolLibraryDatabase"].ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrowing>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Borrowing>()
                .HasOne(br => br.Book)
                .WithMany(b => b.Borrowings)
                .HasForeignKey(br => br.BookId);

            modelBuilder.Entity<Borrowing>()
                .HasOne(br => br.Student)
                .WithMany(s => s.Borrowings)
                .HasForeignKey(br => br.StudentId);
        }
    }
}
