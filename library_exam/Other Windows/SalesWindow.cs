using library.data.Data.Classes;
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
    public partial class SalesWindow : Form
    {
        LibraryService _libraryService = new LibraryService(new LibraryRepository());
        public SalesWindow()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (tbBookName.Text.Length > 0 && tbClientName.Text.Length > 0)
            {
                try
                {
                    var book = _libraryService.GetBook(tbBookName.Text);
                    var client = _libraryService.GetClient(tbClientName.Text);
                    if (book != null && client != null)
                    {
                        _libraryService.AddSales(book, client);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The book or client with these names weren't found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You sould input name of book and client!");
            }

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var sales = _libraryService.GetSales();
            if (sales != null)
            {
                foreach (var sale in sales)
                {
                    stringBuilder.Append($"Book Name: | {sale.Book?.Name} |\nBuyer: | {sale.Client?.Name} | \nFor {sale.Book?.Price}$\nDate: | {sale.Date} |\n\n");
                }
                MessageBox.Show(stringBuilder.ToString());
            }
            else
            {
                MessageBox.Show("No one sale in history!");
            }
        }
    }
}
