using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Extensions.Extensions;

namespace InternshipLibrary.Domain.Repositories
{
    public class AuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository() => _context = new LibraryContext();

        public string Create(Author author)
        {
            if (author.FirstName == "" || author.LastName == "")
                return "You must enter a first and last name";
            if (Read().FirstOrDefault(x => x.FirstName == author.FirstName && x.LastName == author.LastName) != null)
                return "That author already exists";
            _context.Authors.Add(author);
            _context.SaveChanges();
            return "Successfully added";
        }

        public Author Read(int id) => _context.Authors.Find(id);

        public List<Author> Read() => _context.Authors.ToList();

        public string Update(Author newAuthor, Author oldAuthor)
        {
            if (newAuthor.FirstName == "" || newAuthor.LastName == "")
                return "You must enter a first and last name";
            if (Read().FirstOrDefault(x => x.FirstName == newAuthor.FirstName && x.LastName == newAuthor.LastName) != null)
                return "You didn't change anything";

            oldAuthor.FirstName = newAuthor.FirstName;
            oldAuthor.LastName = newAuthor.LastName;
            _context.SaveChanges();
            return "Successfully updated";
        }

        public string Delete(Author author)
        {
            if (_context.Books.Any(x => x.Author == author))
                return "You must first delete all the authors books";
            _context.Authors.Remove(author);
            _context.SaveChanges();
            return "Successfully removed";
        }
    }
}

