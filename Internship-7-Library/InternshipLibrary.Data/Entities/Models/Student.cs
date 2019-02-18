using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Enums;

namespace InternshipLibrary.Data.Entities.Models
{
    public class Student
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public double Loan { get; set; }

        public Class Class { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }

        public override string ToString()
        {
            var bookToWriteOut = "No book";
            return $"{FirstName} {LastName} {DateOfBirth.Year}   {Gender} {Class}   {bookToWriteOut} {Loan}";
        }

        public bool CheckIfUnacceptableAtributes(Student student)
        {
            if (student.FirstName == "" || student.LastName == "")
                return true;
            return false;
        }

        public bool IsNotOldEnough(DateTime dateOfBirth)
        {
            if (DateTime.Now.Year - DateOfBirth.Year < 6)
                return true;
            return false;
        }
    }
}
