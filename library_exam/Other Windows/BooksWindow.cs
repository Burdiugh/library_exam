using library.data.Data.Models;
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
    public partial class BooksWindow : Form
    {
        Book _book;
        public BooksWindow(Book book)
        {
            InitializeComponent();
            _book = book;
            tbName.Text = book.Name;
            tbAuthor.Text = book.Author;
            tbPublishing.Text = book.PublishingHouse;
            tbGenre.Text = book.Genre;
            datePicker.Value = book.TheYearOfPublishing;
            numPages.Value = book.NumberOfPages;
            numCostPrice.Value = book.CostPrice;
            numPrice.Value = book.Price;
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length < 1 || tbAuthor.Text.Length < 1)
            {
                tbName.BackColor = Color.Red;
                tbAuthor.BackColor = Color.Red;
                 tbName.ForeColor = Color.White;
                tbAuthor.ForeColor = Color.White;

                MessageBox.Show("Incorrect data, these fienlds is required!");
            }
            else
            {
                if (datePicker.Value < DateTime.Now)
                {

                    try
                    {
                        _book.Name = tbName.Text;
                        _book.Author = tbAuthor.Text;
                        _book.PublishingHouse = tbPublishing.Text;
                        _book.Genre = tbGenre.Text;
                        _book.TheYearOfPublishing = datePicker.Value;
                        _book.NumberOfPages = (int)numPages.Value;
                        _book.CostPrice = (int)numCostPrice.Value;
                        _book.Price = (int)numPrice.Value;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Somethink went wrong in BookWindow with: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect date!");
                }
            }
        }
    }
}
