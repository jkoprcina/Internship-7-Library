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

namespace Internship_7_Library.Forms.AddForms
{
    public partial class AddStudentForm : Form
    {
        private StudentRepository _studentRepository;
        private ClassRepository _classRepository;
        public AddStudentForm()
        {
            _studentRepository = new StudentRepository();
            _classRepository = new ClassRepository();
            InitializeComponent();
            ClearAndFillForm();
        }

        //Clearing the lists to refresh them and filling them at the start
        private void ClearAndFillForm()
        {
            foreach (var schoolClass in _classRepository.Read())
                ClassLbx.Items.Add(schoolClass);
            foreach (var gender in Enum.GetValues(typeof(Gender)).Cast<Gender>())
                GenderLbx.Items.Add(gender);
        }

        //Creating student
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ClassLbx.SelectedIndex > -1 && GenderLbx.SelectedIndex > -1)
            {
                MessageBox.Show(_studentRepository.Create(new Student
                {
                    FirstName = FirstNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                    LastName = LastNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                    DateOfBirth = DateOfBirthDtp.Value,
                    Class = ClassLbx.SelectedItem as Class,
                    Gender = (Gender) GenderLbx.SelectedItem
                }));
            }
            else
            {
                MessageBox.Show("You must choose a gender and class");
                return;
            }
        }

        //Exiting the form
        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
