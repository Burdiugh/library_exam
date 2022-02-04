using library.data.Data.Classes;
using library.data.Data.Models;
using library.service;
using library_exam.Other_Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_exam
{
    public partial class Form1 : Form
    {

        LibraryService _libraryService = new LibraryService(new LibraryRepository());
        List<Book> books;
        public Form1()
        {
            InitializeComponent();
            books = _libraryService.GetBooks();
            UpdateBooks();
            comboBox.Items.Add("Name");
            comboBox.Items.Add("Price des");
            comboBox.Items.Add("Price asc");
        }

        void UpdateBooks()
        {
            listBooks.DataSource = null;
            listBooks.DataSource = books;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
           
            BooksWindow bookWindow = new BooksWindow();

            bookWindow.ShowDialog();
            if (bookWindow.DialogResult == DialogResult.OK)
            {
                try
                {
                    _libraryService.AddBook(bookWindow._book);
                    books.Add(bookWindow._book);
                    UpdateBooks();
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            var book = listBooks.SelectedItem as Book;
            if (book != null)
            {
                try
                {
                    _libraryService.DeleteBook(book);
                    books.Remove(book);
                    UpdateBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Doesn't exiist!");
            }
        }

        private void listBooks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var book = listBooks.SelectedItem as Book;
            if (book != null)
            {
                BooksWindow booksWindow = new BooksWindow(book);
                booksWindow.ShowDialog();

                if (booksWindow.DialogResult == DialogResult.OK)
                {
                    books.Remove(book);
                    _libraryService.EditBook(book);
                    books.Add(book);

                }
                UpdateBooks();
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex != -1)
            {
                var strCombo = comboBox.SelectedItem.ToString();
                if (strCombo == "Price asc")
                {

                    try
                    {
                        books = _libraryService.GetSortedBooksAsc();
                        UpdateBooks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (strCombo == "Price des")
                {
                    try
                    {
                        books = _libraryService.GetSortedBooksDes();
                        UpdateBooks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (strCombo == "Name")
                {
                    try
                    {
                        books = _libraryService.GetSortedBooksByNames();
                        UpdateBooks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select something!");
            }
        }
    }
}
