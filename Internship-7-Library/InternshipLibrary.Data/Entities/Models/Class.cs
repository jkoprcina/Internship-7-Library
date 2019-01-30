using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Data.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
