using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Extensions.Extensions;
using Microsoft.EntityFrameworkCore;

namespace InternshipLibrary.Domain.Repositories
{
    public class StudentRepository
    {
        private readonly LibraryContext _context;

        public StudentRepository()
        {
            _context = new LibraryContext();
        }

        public void Create(Student student)
        {
            _context.Attach(student.Class);
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public Student Read(int id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> Read()
        {
            return _context.Students.Include(student => student.Class).ToList();
        }

        public void Update(Student oldStudent, Student newStudent)
        {
            oldStudent.FirstName = newStudent.FirstName;
            oldStudent.LastName = newStudent.LastName;
            oldStudent.Class = newStudent.Class;
            oldStudent.DateOfBirth = newStudent.DateOfBirth;
            oldStudent.Gender = newStudent.Gender;
            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
