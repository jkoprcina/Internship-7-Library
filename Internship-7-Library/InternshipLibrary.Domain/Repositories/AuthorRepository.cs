using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Domain.Repositories
{
    public class AuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository()
        {
            _context = new LibraryContext();
        }

        public void Create(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public Author Read(int id)
        {
            return _context.Authors.Find(id);
        }

        public List<Author> Read()
        {
            return _context.Authors.ToList();
        }

        public void Update(Author newAuthor, Author oldAuthor)
        {
            newAuthor.Id = oldAuthor.Id;
            _context.Remove(oldAuthor);
            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}

