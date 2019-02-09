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
using InternshipLibrary.Domain.Repositories;

namespace Internship_7_Library
{
    public partial class ClassForm : Form
    {
        private ClassRepository _classRepository;
        public ClassForm()
        {
            _classRepository = new ClassRepository();
            InitializeComponent();
            ClearAndFillForm();
        }
        //Exiting the form
        private void Exit_Click(object sender, EventArgs e) => Close();

        //Clearing the lists to refresh them and filling them at the start
        private void ClearAndFillForm()
        {
            ClassLbx.Items.Clear();
            foreach (var schoolClass in _classRepository.Read())
                ClassLbx.Items.Add(schoolClass);
        }

        //Create, Update, Delete class
        //Create class button
        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (YearTxt.Text == "" || LetterTxt.Text == "")
                {
                    MessageBox.Show("You must enter a first and last name");
                    return;
                }
                else
                {
                    foreach (var schoolClass in _classRepository.Read())
                    {
                        if (int.Parse(YearTxt.Text) == schoolClass.Number &&
                            char.Parse(LetterTxt.Text) == schoolClass.Letter)
                        {
                            MessageBox.Show("That author already exists");
                            return;
                        }
                    }
                }
                _classRepository.Create(new Class(char.Parse(LetterTxt.Text), int.Parse(YearTxt.Text)));
                ClearAndFillForm();
            }
            catch 
            {
                MessageBox.Show("Wrong input");
                return;
            }
        }
        //Delete class button
        private void RemoveClassBtn_Click(object sender, EventArgs e)
        {
            if (ClassLbx.SelectedIndex > -1)
            {
                _classRepository.Delete(ClassLbx.SelectedItem as Class);
            }
            else
            {
                MessageBox.Show("Please first choose the author you wish to remove");
            }
            ClearAndFillForm();
        }
        //Update class button
        private void EditClassBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
