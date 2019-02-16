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
            if (DateOfBirthDtp.Value.Year < 6)
            {
                MessageBox.Show("The person must be over 5 years old since logic");
                return;
            }
            if (FirstNameTxt.Text != "" && LastNameTxt.Text != ""
                && ClassLbx.SelectedIndex > -1 && GenderLbx.SelectedIndex > -1)
            {
                _studentRepository.Update(_student, new Student(FirstNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                    LastNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(), DateOfBirthDtp.Value,
                    ClassLbx.SelectedItem as Class, (Gender)GenderLbx.SelectedItem));
            }
            else
            {
                MessageBox.Show("You must fill all parts of the form and choose a gender and class");
                return;
            }
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
