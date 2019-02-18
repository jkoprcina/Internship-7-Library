using InternshipLibrary.Domain.Repositories;
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
using InternshipLibrary.Extensions.Extensions;

namespace Internship_7_Library.Forms.AddForms
{
    public partial class AddBookForm : Form
    {
        private BookRepository _bookRepository;
        private AuthorRepository _authorRepository;
        private PublisherRepository _publisherRepository;
        public AddBookForm()
        {
            _bookRepository = new BookRepository();
            _authorRepository = new AuthorRepository();
            _publisherRepository = new PublisherRepository();
            InitializeComponent();
            ClearAndFillForm();
        }

        //Clearing the lists to refresh them and filling them at the start
        private void ClearAndFillForm()
        {
            AuthorLbx.Items.Clear();
            PublisherLbx.Items.Clear();
            GenreLbx.Items.Clear();
            foreach (var author in _authorRepository.Read())
                AuthorLbx.Items.Add(author);
            foreach (var publisher in _publisherRepository.Read())
                PublisherLbx.Items.Add(publisher);
            foreach (var genre in Enum.GetValues(typeof(Genre)).Cast<Genre>())
                GenreLbx.Items.Add(genre);
        }
        
        //Creating book
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AuthorLbx.SelectedIndex > -1 && PublisherLbx.SelectedIndex > -1 && GenreLbx.SelectedIndex > -1)
                {
                    MessageBox.Show(_bookRepository.Create(new Book
                    {
                        Name = NameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                        PageNumber = int.Parse(PageNumberTxt.Text),
                        NumberOfBooksAvailable = int.Parse(NumberOfBooksTxt.Text),
                        Publisher = PublisherLbx.SelectedItem as Publisher,
                        Genre = (Genre)GenreLbx.SelectedItem,
                        Author = AuthorLbx.SelectedItem as Author
                    }));
                }
                else
                    MessageBox.Show("You must select one of each list of options");
            }
            catch
            {
                MessageBox.Show("wrong input");
                return;
            }
        }

        //Exiting the form
        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
