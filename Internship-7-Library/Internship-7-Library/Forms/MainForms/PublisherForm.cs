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
using InternshipLibrary.Extensions.Extensions;
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
            NameTxt.Text = "";
        }
        
        //Create, Update, Delete publisher
        //Create publisher button
        private void AddNewPublisher_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_publisherRepository.Create(new Publisher
            {
                Name = NameTxt.Text.RemoveWhiteSpaces().CapitalizeWords()
            }));
            ClearAndFillForm();
        }

        //Delete publisher button
        private void RemovePublisherBtn_Click(object sender, EventArgs e)
        {
            if (PublisherLbx.SelectedIndex > -1)
                MessageBox.Show(_publisherRepository.Delete(PublisherLbx.SelectedItem as Publisher));
            else
                MessageBox.Show("Please first choose the author you wish to remove");
            ClearAndFillForm();
        }

        //Update publisher button
        private void EditPublisherBtn_Click(object sender, EventArgs e)
        {
            if (PublisherLbx.SelectedIndex > -1)
            {
                MessageBox.Show(_publisherRepository.Update(new Publisher
                {
                    Name = NameTxt.Text.RemoveWhiteSpaces().CapitalizeWords()
                }, PublisherLbx.SelectedItem as Publisher));
            }
            else
                MessageBox.Show("Please choose the publisher you wish to edit");
            ClearAndFillForm();
        }

        //Exiting the form
        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}
