using System;
using System.Windows.Forms;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Domain.Repositories;

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
        }

        //Exiting the form
        private void Exit_Click(object sender, EventArgs e) => Close();

        //Create, Update, Delete Author
        //Create author button
        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            if (FirstNameTxt.Text == "" || LastNameTxt.Text == "")
            {
                MessageBox.Show("You must enter a first and last name");
                return;
            }
            foreach (var author in _authorRepository.Read())
            {
                if (FirstNameTxt.Text == author.FirstName && LastNameTxt.Text == author.LastName)
                {
                    MessageBox.Show("That author already exists");
                    return;
                }
            }
            _authorRepository.Create(new Author(FirstNameTxt.Text, LastNameTxt.Text));
            ClearAndFillForm();
        }
        //Delete author button
        private void RemoveAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AuthorsLbx.SelectedIndex > -1)
            {
                _authorRepository.Delete(AuthorsLbx.SelectedItem as Author);
            }
            else
            {
                MessageBox.Show("Please first choose the author you wish to remove");
            }
            ClearAndFillForm();
        }
        //Update author button
        private void EditAuthorBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
