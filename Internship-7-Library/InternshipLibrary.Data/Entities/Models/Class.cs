using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Data.Entities.Models
{
    public class Class
    {
        public int Id { get; set; }
        public char Letter { get; set; }
        public int Number { get; set; }

        public ICollection<Student> Students { get; set; }

        public Class(char letter, int number)
        {
            Letter = letter;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number} {Letter}";
        }
    }
}
