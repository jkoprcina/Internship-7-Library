using System;
using System.Linq;
using System.Windows.Forms;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Domain.Repositories;
using InternshipLibrary.Extensions.Extensions;

namespace Internship_7_Library.Forms.MainForms
{
    public partial class AuthorForm : Form
    {
        private AuthorRepository _authorRepository;
        public AuthorForm()
        {
            _authorRepository = new AuthorRepository();
            InitializeComponent();
            ClearAndFillForm();
        }

        //Clearing the lists to refresh them and filling them at the start
        private void ClearAndFillForm()
        {
            AuthorsLbx.Items.Clear();
            foreach (var author in _authorRepository.Read())
                AuthorsLbx.Items.Add(author);
            FirstNameTxt.Text = "";
            LastNameTxt.Text = "";
        }

        //Create, Update, Delete Author
        //Create author button
        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_authorRepository.Create(new Author
            {
                FirstName = FirstNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                LastName = LastNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords()
            }));
            ClearAndFillForm();
        }

        //Delete author button
        private void RemoveAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AuthorsLbx.SelectedIndex > -1)
                MessageBox.Show(_authorRepository.Delete(AuthorsLbx.SelectedItem as Author));
            else
                MessageBox.Show("Please first choose the author you wish to remove");
            ClearAndFillForm();
        }

        //Update author button
        private void EditAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AuthorsLbx.SelectedIndex > -1)
            {
                MessageBox.Show(_authorRepository.Update(new Author
                {
                    FirstName = FirstNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                    LastName = LastNameTxt.Text.RemoveWhiteSpaces().CapitalizeWords()
                },AuthorsLbx.SelectedItem as Author));
            }
            else
                MessageBox.Show("Please first choose the author you wish to edit");
            ClearAndFillForm();
        }

        //Exiting the form
        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}
