using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Data.Entities.Models
{
    public class Borrowing
    {
        public int BorrowingId { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfBorrowing { get; set; }
        public DateTime DateOfReturn { get; set; }

        public Book Book { get; set; }
        public Student Student { get; set; }

        public Borrowing(DateTime dateOfBorrowing, DateTime dateOfReturn)
        {
            DateOfBorrowing = dateOfBorrowing;
            DateOfReturn = dateOfReturn;
        }
    }
}

