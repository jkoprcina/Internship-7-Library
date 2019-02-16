using System.Collections.Generic;
using System.Linq;
using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipLibrary.Domain.Repositories
{
    public class BookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository() => _context = new LibraryContext();

        public void Create(Book book)
        {
            _context.Attach(book.Publisher);
            _context.Attach(book.Author);
            _context.Add(book);
            _context.SaveChanges();
        }

        public Book Read(int id) => _context.Books.Find(id);

        public List<Book> Read()
        {
            return _context.Books.Include(book => book.Publisher).Include(aut => aut.Author).ToList();
        }

        public void Update(Book oldBook, Book newBook)
        {
            oldBook.Name = newBook.Name;
            oldBook.Publisher = newBook.Publisher;
            oldBook.Author = newBook.Author;
            oldBook.NumberOfBooksAvailable = newBook.NumberOfBooksAvailable;
            oldBook.PageNumber = newBook.PageNumber;
            oldBook.Genre = newBook.Genre;
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
