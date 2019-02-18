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

        //Clearing the lists to refresh them and filling them at the start
        private void ClearAndFillForm()
        {
            ClassLbx.Items.Clear();
            foreach (var schoolClass in _classRepository.Read())
                ClassLbx.Items.Add(schoolClass);
            LetterTxt.Text = "";
            YearTxt.Text = "";
        }

        //Create, Update, Delete class
        //Create class button
        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(_classRepository.Create(new Class
                {
                    Letter = char.Parse(LetterTxt.Text),
                    Number = int.Parse(YearTxt.Text)
                }));
                ClearAndFillForm();
            }
            catch 
            {
                MessageBox.Show("Wrong input");
            }
        }
        //Delete class button
        private void RemoveClassBtn_Click(object sender, EventArgs e)
        {
            if (ClassLbx.SelectedIndex > -1)
                MessageBox.Show(_classRepository.Delete(ClassLbx.SelectedItem as Class));
            else
                MessageBox.Show("Please first choose the author you wish to remove");
            ClearAndFillForm();
        }
        //Update class button
        private void EditClassBtn_Click(object sender, EventArgs e)
        {
            if (ClassLbx.SelectedIndex > -1)
            {
                try
                {
                    MessageBox.Show(_classRepository.Update(new Class
                    {
                        Letter = char.Parse(LetterTxt.Text),
                        Number = int.Parse(YearTxt.Text)
                    }, ClassLbx.SelectedItem as Class));
                }
                catch
                {
                    MessageBox.Show("Wrong input");
                }
            }
            else
                MessageBox.Show("Please first choose the author you wish to remove");
            ClearAndFillForm();
        }

        //Exiting the form
        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}
