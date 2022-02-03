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
        List<Client> clients;
        public Form1()
        {
            InitializeComponent();
            books = _libraryService.GetBooks();
            clients = _libraryService.GetClients();
            UpdateBooks();
            UpdateClients();
        }
        void UpdateClients()
        {
            listClients.DataSource = null;
            listClients.DataSource = clients;
        }
        void UpdateBooks()
        {
            listBooks.DataSource = null;
            listBooks.DataSource = books;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            BooksWindow bookWindow = new BooksWindow(book);
            try
            {
                bookWindow.ShowDialog();
                if (bookWindow.DialogResult == DialogResult.OK)
                {
                    _libraryService.AddBook(book);
                    books.Add(book);
                    UpdateBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            var client = listClients.SelectedItem as Client;
            if (client != null)
            {
                try
                {
                    _libraryService.DeleteClient(client);
                    clients.Remove(client);
                    UpdateClients();
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            ClientsWindow clientsWindow = new ClientsWindow(client);
            try
            {
                clientsWindow.ShowDialog();
                if (clientsWindow.DialogResult == DialogResult.OK)
                {
                    _libraryService.AddClient(client);
                    clients.Add(client);
                    UpdateClients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var client = listClients.SelectedItem as Client;
            if (client != null)
            {
                ClientsWindow clientsWindow = new ClientsWindow(client);
                clientsWindow.ShowDialog();
                if (clientsWindow.DialogResult == DialogResult.OK)
                {
                    clients.Remove(client);
                    _libraryService.EditClient(client);
                    clients.Add(client);
                }
                UpdateClients();
            }
        }
    }
}
