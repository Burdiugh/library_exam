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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void btnManageClient_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
           form2.ShowDialog();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            SalesWindow salesWindow = new SalesWindow();
            salesWindow.ShowDialog();
        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            QueriesWindow queriesWindow = new QueriesWindow();
            queriesWindow.ShowDialog();
        }
    }
}
