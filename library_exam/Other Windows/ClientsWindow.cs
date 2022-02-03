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
    public partial class ClientsWindow : Form
    {
        Client _client;
        public ClientsWindow(Client client)
        {
            InitializeComponent();
            _client = client;
            tbName.Text = client.Name;
            numericMoney.Value = client.ValueOfMoney;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length<1)
            {
                tbName.BackColor = Color.Red;
                tbName.ForeColor = Color.White;
                MessageBox.Show("Field \"Name\" is required!");
            }
            else
            {
                try
                {
                    _client.Name = tbName.Text;
                    _client.ValueOfMoney = (int)numericMoney.Value;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 

    }
}
