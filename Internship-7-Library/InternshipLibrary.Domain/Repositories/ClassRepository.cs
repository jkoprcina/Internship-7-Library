using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;

namespace InternshipLibrary.Domain.Repositories
{
    public class ClassRepository
    {
        private readonly LibraryContext _context;

        public ClassRepository() => _context = new LibraryContext();

        public string Create(Class schoolClass)
        {
            if (schoolClass.Letter.ToString() == "" || schoolClass.Number.ToString() == "")
                return "You must enter a class letter and year";
            if (Read().Any(x => x.Letter == schoolClass.Letter && x.Number == schoolClass.Number))
                return "That class already exists";
            schoolClass.Letter = char.ToUpper(schoolClass.Letter);
            _context.Classes.Add(schoolClass);
            _context.SaveChanges();
            return "Successfully added";
        }

        public Class Read(int id) => _context.Classes.Find(id);

        public List<Class> Read() => _context.Classes.ToList();

        public string Update(Class newSchoolClass, Class oldSchoolClass)
        {
            if (newSchoolClass.Letter.ToString() == "" || newSchoolClass.Number.ToString() == "")
                return "You must enter a class letter and year";
            if (Read().Any(x => x.Letter == newSchoolClass.Letter && x.Number == newSchoolClass.Number))
                return "You made no changes";

            oldSchoolClass.Letter = char.ToUpper(newSchoolClass.Letter);
            oldSchoolClass.Number = newSchoolClass.Number;
            _context.SaveChanges();
            return "Successfully updated";
        }

        public string Delete(Class schoolClass)
        {
            if (_context.Students.Any(x => x.Class == schoolClass))
                return "You must first remove all students which are in that class";
            _context.Classes.Remove(schoolClass);
            _context.SaveChanges();
            return "Successfully removed";
        }
    }
}
