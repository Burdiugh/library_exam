using library.data.Data.Classes;
using library.data.Data.Models;
using library.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_exam.Other_Windows
{
    public partial class QueriesWindow : Form
    {

        LibraryService _libraryService = new LibraryService(new LibraryRepository());
        public QueriesWindow()
        {
            InitializeComponent();
            comboGenres.Items.Add("Romance");
            comboGenres.Items.Add("Adventure");
            comboGenres.Items.Add("Documental");
            comboGenres.SelectedIndex = 0;
        }
       
        private void btnGetNewestBooks_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            var books = _libraryService.GetBooksByDate(datePicker.Value);
            if (books != null)
            {
                foreach (var book in books)
                {
                    listView.Items.Add($"Name: {book.Name}");
                    listView.Items.Add($"Date: { book.TheYearOfPublishing}");
                    listView.Items.Add(Environment.NewLine);
                }
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            var genre = comboGenres.SelectedItem.ToString();
            try
            {
                _libraryService.Discount(genre);
                var books = _libraryService.GetBooksByGenre(genre);
                if (books!=null)
                {
                    foreach (var book in books)
                    {
                        listView.Items.Add($"Name: {book.Name}");
                        listView.Items.Add($"New price: { book.Price}");
                        listView.Items.Add(Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show($"No one book with genre \"{genre}\" was found!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOverprice_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            var genre = comboGenres.SelectedItem.ToString();
            try
            {
                _libraryService.SetOverprice(genre);
                var books = _libraryService.GetBooksByGenre(genre);
                if (books != null)
                {
                    foreach (var book in books)
                    {
                        listView.Items.Add($"Name: {book.Name}");
                        listView.Items.Add($"New price: { book.Price}");
                        listView.Items.Add(Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show($"No one book with genre \"{genre}\" was found!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
