using System.Collections.Generic;
using System.Linq;
using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace InternshipLibrary.Domain.Repositories
{
    public class BookRepository
    {
        private LibraryContext _context;

        public BookRepository() => _context = new LibraryContext();

        public string Create(Book book)
        {
            if (book.CheckIfUnacceptableAtributes(book))
                return "You must input all values";
            _context.Publishers.Attach(book.Publisher);
            _context.Authors.Attach(book.Author);
            _context.Books.Add(book);
            _context.SaveChanges();
            _context = new LibraryContext();
            return "Successfully added";
        }

        public Book Read(int id) => _context.Books.Find(id);

        public List<Book> Read() => _context.Books.Include(book => book.Publisher).Include(aut => aut.Author).ToList();

        public string Update(Book newBook, Book oldBook)
        {
            if (newBook.CheckIfUnacceptableAtributes(newBook))
                return "You must input all values";

            oldBook.Name = newBook.Name;
            oldBook.Publisher = newBook.Publisher;
            oldBook.Author = newBook.Author;
            oldBook.NumberOfBooksAvailable = newBook.NumberOfBooksAvailable;
            oldBook.PageNumber = newBook.PageNumber;
            oldBook.Genre = newBook.Genre;
            _context.SaveChanges();
            _context = new LibraryContext();
            return "Successfully updated";
        }

        public string Delete(Book book)
        {
            if (_context.Borrowings.Any(x => x.Book == book))
                return "You must first return all of the copies of the existing book";
            _context.Books.Remove(book);
            _context.SaveChanges();
            _context = new LibraryContext();
            return "Successfully updated";
        }
    }
}
