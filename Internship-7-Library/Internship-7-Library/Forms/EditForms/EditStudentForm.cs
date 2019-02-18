using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Data.Enums;
using InternshipLibrary.Domain.Repositories;
using InternshipLibrary.Extensions.Extensions;

namespace Internship_7_Library.Forms.EditForms
{
    public partial class EditStudentForm : Form
    {
        private StudentRepository _studentRepository;
        private ClassRepository _classRepository;
        private Student _student;
        public EditStudentForm(Student student)
        {
            _studentRepository = new StudentRepository();
            _classRepository = new ClassRepository();
            _student = student;
            InitializeComponent();
            ClearAndFillForm();
        }

        private void ClearAndFillForm()
        {
            foreach (var schoolClass in _classRepository.Read())
                ClassLbx.Items.Add(schoolClass);
            foreach (var gender in Enum.GetValues(typeof(Gender)).Cast<Gender>())
                GenderLbx.Items.Add(gender);
            FirstNameTxt.Text = _student.FirstName;
            LastNameTxt.Text = _student.LastName;
            DateOfBirthDtp.Value = _student.DateOfBirth;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ClassLbx.SelectedIndex > -1 && GenderLbx.SelectedIndex > -1)
            {
                MessageBox.Show(_studentRepository.Update(new Student
                {
                    FirstName = FirstNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                    LastName = LastNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                    DateOfBirth = DateOfBirthDtp.Value,
                    Class = ClassLbx.SelectedItem as Class,
                    Gender = (Gender)GenderLbx.SelectedItem
                }, _student));
            }
            else
            {
                MessageBox.Show("You must choose a gender and class");
                return;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
