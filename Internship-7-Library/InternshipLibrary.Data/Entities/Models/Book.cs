using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Data.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageNumber { get; set; }

        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }
    }
}
