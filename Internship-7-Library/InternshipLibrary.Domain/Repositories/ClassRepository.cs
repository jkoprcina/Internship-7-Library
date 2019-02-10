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

        public ClassRepository()
        {
            _context = new LibraryContext();
        }

        public void Create(Class schoolClass)
        {
            _context.Classes.Add(schoolClass);
            _context.SaveChanges();
        }

        public Class Read(int id)
        {
            return _context.Classes.Find(id);
        }

        public List<Class> Read()
        {
            return _context.Classes.ToList();
        }

        public void Update(Class newSchoolClass, Class oldSchoolClass)
        {
            newSchoolClass.Id = oldSchoolClass.Id;
            _context.Classes.Remove(oldSchoolClass);
            _context.Classes.Add(newSchoolClass);
            _context.SaveChanges();
        }

        public void Delete(Class schoolClass)
        {
            _context.Classes.Remove(schoolClass);
            _context.SaveChanges();
        }
    }
}
