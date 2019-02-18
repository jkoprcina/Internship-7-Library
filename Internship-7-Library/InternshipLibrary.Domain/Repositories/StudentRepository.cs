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

        public StudentRepository() => _context = new LibraryContext();

        public string Create(Student student)
        {
            if (student.CheckIfUnacceptableAtributes(student))
                return "You must fill all the required fields";
            if (student.IsNotOldEnough(student.DateOfBirth))
                return "Student is too young to go to school";

            _context.Classes.Attach(student.Class);
            _context.Students.Add(student);
            _context.SaveChanges();
            return "Successfully created";
        }

        public Student Read(int id) => _context.Students.Find(id);

        public List<Student> Read() => _context.Students.Include(student => student.Class).ToList();

        public string Update(Student newStudent, Student oldStudent)
        {
            if (newStudent.CheckIfUnacceptableAtributes(newStudent))
                return "You must fill all the required fields";
            if (newStudent.IsNotOldEnough(newStudent.DateOfBirth))
                return "Student is too young to go to school";
            if (oldStudent.FirstName == newStudent.FirstName && oldStudent.LastName == newStudent.LastName &&
                oldStudent.Class == newStudent.Class
                && oldStudent.DateOfBirth == newStudent.DateOfBirth && oldStudent.Gender == newStudent.Gender)
                return "You made no changes to the student";

            oldStudent.FirstName = newStudent.FirstName;
            oldStudent.LastName = newStudent.LastName;
            oldStudent.Class = newStudent.Class;
            oldStudent.DateOfBirth = newStudent.DateOfBirth;
            oldStudent.Gender = newStudent.Gender;
            _context.SaveChanges();
            return "Successfully updated";
        }

        public string Delete(Student student)
        {
            if (_context.Borrowings.Any(x => x.Student == student))
                return "You can not remove a student until he has returned the borrowed book";
            _context.Students.Remove(student);
            _context.SaveChanges();
            return "Successfully deleted";
        }
    }
}
