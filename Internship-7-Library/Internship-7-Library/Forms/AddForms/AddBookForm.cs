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
            foreach (var author in _authorRepository.Read())
                AuthorLbx.Items.Add(author);
            foreach (var publisher in _publisherRepository.Read())
                PublisherLbx.Items.Add(publisher);
        }

        //Exiting the form
        private void ExitBtn_Click(object sender, EventArgs e) => Close();

        //Creating book
        //Exits if the name is already in use, and exits if it's successfully added
        //A author and publisher must be chosen
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bookRepository.Read().Contains(_bookRepository.Read(NameTxt.Text)))
                {
                    Console.WriteLine("The name must not exist already");
                    return;
                }

                if (NameTxt.Text != "" && PageNumberTxt.Text != "" && AuthorLbx.SelectedIndex > -1
                    && PublisherLbx.SelectedIndex > -1)
                {
                    _bookRepository.Create(new Book(NameTxt.Text, int.Parse(PageNumberTxt.Text)));
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("All info must be filled/selected");
                    return;
                }
                Close();
            }
            catch
            {
                Console.WriteLine("Wrong input");
                return;
            }
        }
    }
}
