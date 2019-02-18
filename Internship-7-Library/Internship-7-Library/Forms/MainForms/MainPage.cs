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
using InternshipLibrary.Extensions.Extensions;
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
            NumberOfDaysTxt.Text = "";
            LoanReturnTxt.Text = "";
            AddRemoveCopiesTxt.Text = "";
        }

        //A few methods to check if the needed info is selected
        //Checking is book selected
        private bool IsBookSelected()
        {
            if (BooksLbx.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a book");
                return false;
            }
            return true;
        }

        //Checking is student selected
        private bool IsStudentSelected()
        {
            if (StudentLbx.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a student");
                return false;
            }
            return true;
        }

        //Checking is book and student selected
        private bool IsBookAndStudentSelected()
        {
            if (BooksLbx.SelectedIndex < 0 || StudentLbx.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a student and a book");
                return false;
            }
            return true;
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
            if(!IsBookSelected())
                return;
            var message = "Are you sure you wish to remove this book?";
            var caption = "Asking approval";
            var buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.No)
                return;
            MessageBox.Show(_bookRepository.Delete(BooksLbx.SelectedItem as Book));
            ClearAndFillForm();
        }

        //Update book button
        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            if (!IsBookSelected())
                return;
            var editBook = new EditBookForm(BooksLbx.SelectedItem as Book);
            editBook.ShowDialog();
            ClearAndFillForm();
        }

        //Adds new copies of an old book
        private void AddCopiesBtn_Click(object sender, EventArgs e)
        {
            if (!IsBookSelected())
                return;
            try
            {
                (BooksLbx.SelectedItem as Book).AddCopies(int.Parse(AddRemoveCopiesTxt.Text));
            }
            catch
            {
                MessageBox.Show("Wrong input");
                return;
            }
            ClearAndFillForm();
        }

        //Removes copies of an old book
        private void RemoveCopiesBtn_Click(object sender, EventArgs e)
        {
            if (!IsBookSelected())
                return;
            try
            {
                MessageBox.Show((BooksLbx.SelectedItem as Book).RemoveCopies(int.Parse(AddRemoveCopiesTxt.Text)));
            }
            catch
            {
                MessageBox.Show("Wrong input");
                return;
            }
            ClearAndFillForm();
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
            if (!IsStudentSelected())
                return;
            var message = "Are you sure you wish to remove this student?";
            var caption = "Asking approval";
            var buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.No)
                return;
            MessageBox.Show(_studentRepository.Delete(StudentLbx.SelectedItem as Student));
            ClearAndFillForm();
        }

        //Update student button
        private void EditStudentBtn_Click(object sender, EventArgs e)
        {
            if (!IsStudentSelected())
                return;
            var editStudent = new EditStudentForm(StudentLbx.SelectedItem as Student);
            editStudent.ShowDialog();
            ClearAndFillForm();
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

        private void LoanReturnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsStudentSelected())
                    return;
                var student = StudentLbx.SelectedItem as Student;
                if (student.Loan >= double.Parse(LoanReturnTxt.Text))
                {
                    student.Loan -= double.Parse(LoanReturnTxt.Text);
                    MessageBox.Show($"The student now has {student.Loan} left to return");
                    ClearAndFillForm();
                    return;
                }
                else
                {
                    MessageBox.Show($"Return {double.Parse(LoanReturnTxt.Text) - student.Loan} to the student");
                    student.Loan = 0;
                    ClearAndFillForm();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
                return;
            }
        }

        //Borrow, return and Exit Buttons
        //Borrow book button
        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            if (!IsBookAndStudentSelected())
                return;
            _student = StudentLbx.SelectedItem as Student;
            _book = BooksLbx.SelectedItem as Book;
            if (NumberOfDaysTxt.Text == "")
                MessageBox.Show(_borrowingRepository.Create(new Borrowing(DateTime.Now, (DateTime.Now.AddDays(30)), 
                    BooksLbx.SelectedItem as Book,_student, false)));
            else
            {
                try
                {
                    var CatchingException = int.Parse(NumberOfDaysTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong input");
                    return;
                }
                MessageBox.Show(_borrowingRepository.Create(new Borrowing(DateTime.Now, DateTime.Now.AddDays(int.Parse(NumberOfDaysTxt.Text))
                    ,_book, _student, false)));
            }
            ClearAndFillForm();
        }
        //Return book button
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (!IsStudentSelected())
                return;
            _student = StudentLbx.SelectedItem as Student;
            var borrowing = _borrowingRepository.Read(_student.Id);
            if (borrowing == null)
            {
                MessageBox.Show("The student doesn't have a book to return");
                return;
            }
            _student.Loan += MoneyFunctions.CountLoan(borrowing.DateOfReturn);
            MessageBox.Show(_borrowingRepository.Delete(borrowing));
            ClearAndFillForm();
        }

        //Exit app method 
        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}
