using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Data.Entities.Models
{
    public class Borrowing
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfBorrowing { get; set; }
        public DateTime DateOfReturn { get; set; }
        public bool IsReturned { get; set; }

        public Book Book { get; set; }
        public Student Student { get; set; }

        public Borrowing()
        {
        }

        public Borrowing(DateTime dateOfBorrowing, DateTime dateOfReturn, Book book, Student student,bool isReturned)
        {
            DateOfBorrowing = dateOfBorrowing;
            DateOfReturn = dateOfReturn;
            Book = book;
            Student = student;
            IsReturned = isReturned;
        }
    }
}

