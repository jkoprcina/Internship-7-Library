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
    public partial class EditBookForm : Form
    {
        private BookRepository _bookRepository;
        private AuthorRepository _authorRepository;
        private PublisherRepository _publisherRepository;
        private Book _book;
        public EditBookForm(Book book)
        {
            _bookRepository = new BookRepository();
            _authorRepository = new AuthorRepository();
            _publisherRepository = new PublisherRepository();
            _book = book;
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
            NameTxt.Text = _book.Name;
            NumberOfBooksTxt.Text = _book.NumberOfBooksAvailable.ToString();
            PageNumberTxt.Text = _book.PageNumber.ToString();
        }

        //Updating Book 
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AuthorLbx.SelectedIndex > -1 && PublisherLbx.SelectedIndex > -1 && GenreLbx.SelectedIndex > -1)
                {
                    _bookRepository.Update(new Book
                    {
                        Name = NameTxt.Text.RemoveWhiteSpaces().CapitalizeWords(),
                        NumberOfBooksAvailable = int.Parse(NumberOfBooksTxt.Text),
                        NumberOfBooksBorrowed = 0,
                        Author = AuthorLbx.SelectedItem as Author,
                        Publisher = PublisherLbx.SelectedItem as Publisher,
                        Genre = (Genre) GenreLbx.SelectedItem
                    }, _book);
                    Close();
                }
                else
                    MessageBox.Show("All info must be filled/selected");
            }
            catch
            {
                Console.WriteLine("Wrong input");
                return;
            }
        }

        //Exiting form
        private void ExitBtn_Click(object sender, EventArgs e) => Close();
    }
}
