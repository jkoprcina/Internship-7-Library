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
        //Exits if it's successfully added
        //A class and gender must be chosen, person must be older than 5 years
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DateOfBirthDtp.Value.Year < 6)
            {
                MessageBox.Show("The person must be over 5 years old since logic");
                return;
            }
            if (FirstNameTxt.Text != "" && LastNameTxt.Text != ""
                && ClassLbx.SelectedIndex > -1 && GenderLbx.SelectedIndex > -1)
            {
                _studentRepository.Create(new Student(FirstNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(), 
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

        //Exiting the form
        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
