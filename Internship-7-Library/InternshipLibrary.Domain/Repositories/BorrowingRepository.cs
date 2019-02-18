using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Migrations;

namespace InternshipLibrary.Domain.Repositories
{
    public class BorrowingRepository
    {
        private readonly LibraryContext _context;

        public BorrowingRepository()
        {
            _context = new LibraryContext();
        }

        public string Create(Borrowing borrowing)
        {
            if (Read(borrowing.Student.Id) != null)
                return "The student has a book already, he can take a new one after he returns that one";
            if (borrowing.Book.NumberOfBooksAvailable <= 0)
                return "There are no more copies of that book available";

            _context.Students.Attach(borrowing.Student);
            _context.Books.Attach(borrowing.Book);
            _context.Classes.Attach(borrowing.Student.Class);
            _context.Authors.Attach(borrowing.Book.Author);
            _context.Publishers.Attach(borrowing.Book.Publisher);

            borrowing.Book.Borrowing();
            _context.Borrowings.Add(borrowing);
            _context.SaveChanges();
            return "Book borrowed";
        }

        public Borrowing Read(int studentId)
        {
            return _context.Borrowings
                .Include(x => x.Book).ThenInclude(x => x.Publisher)
                .Include(x => x.Book).ThenInclude(x => x.Author)
                .Include(x => x.Student).ThenInclude(x => x.Class)
                .FirstOrDefault(x => x.StudentId == studentId);
        }

        public string Delete(Borrowing borrowing)
        {
            borrowing.Book.Returning();
            _context.Borrowings.Remove(borrowing);
            _context.SaveChanges();
            return "successful";
        }
    }
}
