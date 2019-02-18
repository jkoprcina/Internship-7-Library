using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Enums;

namespace InternshipLibrary.Data.Entities.Models
{
    public class Book
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageNumber { get; set; }
        public int NumberOfBooksAvailable { get; set; }
        public int NumberOfBooksBorrowed { get; set; }

        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }

        public override string ToString()
        {
            return $"{Name} Author:{Author.FirstName} Publisher:{Publisher.Name} Number:{NumberOfBooksAvailable}";
        }

        public void AddCopies(int numberToAdd) => NumberOfBooksAvailable += numberToAdd;

        public string RemoveCopies(int numberToRemove)
        {
            if (NumberOfBooksAvailable - numberToRemove < 0)
                return "You can not remove that many books because there are less available";
            else
                NumberOfBooksAvailable -= numberToRemove;
            return "Succesfully removed";
        }

        public void Borrowing()
        {
            NumberOfBooksAvailable -= 1;
            NumberOfBooksBorrowed += 1;
        }

        public void Returning()
        {
            NumberOfBooksAvailable += 1;
            NumberOfBooksBorrowed -= 1;
        }

        public bool CheckIfUnacceptableAtributes(Book book)
        {
            if (book.Name == "" || book.NumberOfBooksAvailable.ToString() == "" || book.NumberOfBooksAvailable < 1
                || book.PageNumber < 1 || book.PageNumber.ToString() == "")
                return true;
            return false;
        }
    }
}
