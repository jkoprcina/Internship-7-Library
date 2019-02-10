using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Enums;

namespace InternshipLibrary.Data.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageNumber { get; set; }
        public int NumberOfBooks { get; set; }

        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }

        public Book()
        {
        }

        public Book(string name, int pageNumber, int numberOfBooks, Author author, Publisher publisher, Genre genre)
        {
            Name = name;
            PageNumber = pageNumber;
            NumberOfBooks = numberOfBooks;
            Author = author;
            Publisher = publisher;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Name} Number:{NumberOfBooks} Author:{Author} Publisher:{Publisher}";
        }
    }
}
