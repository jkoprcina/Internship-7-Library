using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Domain.Repositories;
using Internship_7_Library.Forms.AddForms;
using Internship_7_Library.Forms.EditForms;
using Internship_7_Library.Forms.MainForms;

namespace Internship_7_Library.Forms
{
    public partial class MainPage : Form
    {
        private BookRepository _bookRepository;
        private StudentRepository _studentRepository;
        private BorrowingRepository _borrowingRepository;
        private Book _book;
        private Student _student;
        public MainPage()
        {
            _bookRepository = new BookRepository();
            _studentRepository = new StudentRepository();
            _borrowingRepository = new BorrowingRepository();
            InitializeComponent();
            ClearAndFillForm();
        }

        //Clearing the lists to refresh them and filling them at the start
        private void ClearAndFillForm()
        {
            BooksLbx.Items.Clear();
            StudentLbx.Items.Clear();
            foreach (var book in _bookRepository.Read())
                BooksLbx.Items.Add(book);
            foreach (var student in _studentRepository.Read())
                StudentLbx.Items.Add(student);
            _book = null;
            _student = null;
        }

        //Create, Update, Delete buttons for Books
        //Create new book button
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            var addNewBook = new AddBookForm();
            addNewBook.ShowDialog();
            ClearAndFillForm();
        }
        //Remove book button
        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            if (BooksLbx.SelectedIndex > -1)
            {
                const string message = "Are you sure you wish to remove this book?";
                const string caption = "Asking approval";
                var buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.No)
                {
                    return;
                }
                _bookRepository.Delete(BooksLbx.SelectedItem as Book);
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show("Please select the book you wish to remove");
                return;
            }
        }
        //Update book button
        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            if (BooksLbx.SelectedIndex > -1)
            {
                var editBook = new EditBookForm(BooksLbx.SelectedItem as Book);
                editBook.ShowDialog();
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show("Please select the book you wish to edit");
                return;
            }
        }

        //Create, Update, Delete buttons for Students
        //Create new student button
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            var addNewStudent = new AddStudentForm();
            addNewStudent.ShowDialog();
            ClearAndFillForm();
        }
        //Delete student button
        private void RemoveStudentBtn_Click(object sender, EventArgs e)
        {
            if(StudentLbx.SelectedIndex > -1)
            {
                const string message = "Are you sure you wish to remove this student?";
                const string caption = "Asking approval";
                var buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.No)
                {
                    return;
                }
                _studentRepository.Delete(StudentLbx.SelectedItem as Student);
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show("Please select the student you wish to remove");
                return;
            }
        }
        //Update student button
        private void EditStudentBtn_Click(object sender, EventArgs e)
        {
            if (StudentLbx.SelectedIndex > -1)
            {
                var editStudent = new EditStudentForm(StudentLbx.SelectedItem as Student);
                editStudent.ShowDialog();
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show("Please select the student you wish to edit");
                return;
            }
        }

        //Buttons to open Authors, Publishers and Classes
        //Authors button
        private void AuthorBtn_Click(object sender, EventArgs e)
        {
            var author = new AuthorForm();
            author.ShowDialog();
        }
        //Publishers button
        private void PublisherBtn_Click(object sender, EventArgs e)
        {
            var publisher = new PublisherForm();
            publisher.ShowDialog();
        }
        //Classes button
        private void ClassBtn_Click(object sender, EventArgs e)
        {
            var libraryClass = new ClassForm();
            libraryClass.ShowDialog();
        }

        //Borrow, return and Exit Buttons
        //Borrow book button
        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            if (BooksLbx.SelectedIndex > -1 && StudentLbx.SelectedIndex > -1)
            {
                if ((StudentLbx.SelectedItem as Student).Borrowings != null)
                {
                    MessageBox.Show("The student has a book already, he can take a new one after he returns that one");
                    return;
                }
                _student = StudentLbx.SelectedItem as Student;
                _book = BooksLbx.SelectedItem as Book;
                _borrowingRepository.Create(new Borrowing(DateTime.Now, (DateTime.Now.AddDays(30)), _book, _student));
                _book.NumberOfBooksAvailable -= 1;
                _book.NumberOfBooksBorrowed += 1;
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show("Please select a book and student");
                return;
            }
        }
        //Return book button
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (StudentLbx.SelectedIndex > -1)
            {
                if ((StudentLbx.SelectedItem as Student).Borrowings == null)
                {
                    MessageBox.Show("The student doesn't have a book to return");
                    return;
                }

                _student = StudentLbx.SelectedItem as Student;
                var borrowing = _borrowingRepository.Read().FirstOrDefault(borr => borr.Student == _student);
                borrowing.Book.NumberOfBooksAvailable += 1;
                borrowing.Book.NumberOfBooksBorrowed -= 1;
                _borrowingRepository.Delete(borrowing);
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show("Please select a book and student");
                return;
            }
        }
        //Exit app method 
        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}
