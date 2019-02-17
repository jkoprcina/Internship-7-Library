using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Domain.Repositories
{
    public class BorrowingRepository
    {
        private readonly LibraryContext _context;

        public BorrowingRepository()
        {
            _context = new LibraryContext();
        }

        public void Create(Borrowing borrowing)
        {
            _context.Students.Attach(borrowing.Student);
            _context.Books.Attach(borrowing.Book);
            _context.Borrowings.Add(borrowing);
            _context.SaveChanges();
        }

        public Borrowing Read(int id)
        {
            return _context.Borrowings.Find(id);
        }

        public List<Borrowing> Read()
        {
            return _context.Borrowings.Include(borrowing => borrowing.Student).Include(book => book.Book).ToList();
        }

        public void Delete(Borrowing borrowing)
        {
            _context.Borrowings.Remove(borrowing);
            _context.SaveChanges();
        }
    }
}
