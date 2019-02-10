using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternshipLibrary.Domain.Repositories;
using InternshipLibrary.Data.Entities.Models;
using Publisher = InternshipLibrary.Data.Entities.Models.Publisher;

namespace Internship_7_Library
{
    public partial class PublisherForm : Form
    {
        private PublisherRepository _publisherRepository;
        public PublisherForm()
        {
            _publisherRepository = new PublisherRepository();
            InitializeComponent();
            ClearAndFillForm();
        }

        //Clearing the lists to refresh them and filling them at the start
        private void ClearAndFillForm()
        {
            PublisherLbx.Items.Clear();
            foreach (var publisher in _publisherRepository.Read())
                PublisherLbx.Items.Add(publisher);
        }

        //Exiting the form
        private void Exit_Click(object sender, EventArgs e) => Close();

        //Create, Update, Delete publisher
        //Create publisher button
        private void AddNewPublisher_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                MessageBox.Show("You must enter a first and last name");
                return;
            }
            else
            {
                foreach (var publisher in _publisherRepository.Read())
                {
                    if (NameTxt.Text == publisher.Name)
                    {
                        MessageBox.Show("That author already exists");
                        return;
                    }
                }
            }
            _publisherRepository.Create(new Publisher(NameTxt.Text));
            ClearAndFillForm();
        }
        //Delete publisher button
        private void RemovePublisherBtn_Click(object sender, EventArgs e)
        {
            if (PublisherLbx.SelectedIndex > -1)
            {
                _publisherRepository.Delete(PublisherLbx.SelectedItem as Publisher);
                ClearAndFillForm();
            }
            else
            {
                MessageBox.Show("Please first choose the author you wish to remove");
            }
            ClearAndFillForm();
        }

        //Update publisher button
        private void EditPublisherBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                MessageBox.Show("You must enter a first and last name");
                return;
            }
            else
            {
                foreach (var publisher in _publisherRepository.Read())
                {
                    if (NameTxt.Text == publisher.Name)
                    {
                        MessageBox.Show("That author already exists");
                        return;
                    }
                }
            }
            _publisherRepository.Update(new Publisher(NameTxt.Text), PublisherLbx.SelectedItem as Publisher);
            ClearAndFillForm();
        }
    }
}
