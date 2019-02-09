using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Extensions.Interfaces;

namespace InternshipLibrary.Domain.Repositories
{
    public class BookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository()
        {
            _context = new LibraryContext();
        }

        public void Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public Book Read(string name)
        {
            return _context.Books.Find(name);
        }

        public List<Book> Read()
        {
            return _context.Books.ToList();
        }

        public void Update(Book book, string name)
        {
            _context.Books.Remove(Read(name));
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
