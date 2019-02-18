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

        public override string ToString()
        {
            return $"{Number} {Letter}";
        }
    }
}
