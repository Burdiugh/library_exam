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
    public partial class Form2 : Form
    {
        LibraryService _libraryService = new LibraryService(new LibraryRepository());
        List<Client> clients;
        public Form2()
        {
            InitializeComponent();
            clients = _libraryService.GetClients();
            UpdateClients();
        }
        void UpdateClients()
        {
            listClients.DataSource = null;
            listClients.DataSource = clients;
        }
        private void btnRemovClient_Click(object sender, EventArgs e)
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
            ClientsWindow clientsWindow = new ClientsWindow();
            try
            {
                clientsWindow.ShowDialog();
                if (clientsWindow.DialogResult == DialogResult.OK)
                {
                    _libraryService.AddClient(clientsWindow._client);
                    clients.Add(clientsWindow._client);
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
