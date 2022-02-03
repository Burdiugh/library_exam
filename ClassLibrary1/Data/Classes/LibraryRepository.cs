using library.data.Data.Interfaces;
using library.data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.data.Data.Classes
{
    public class LibraryRepository : ILibraryRepository
    {
        public void AddBook(Book book)
        {
            using AppDbContext context = new AppDbContext();
            context.Add(book);
            context.SaveChanges();
        }

        public void AddClient(Client client)
        {
            using AppDbContext context = new AppDbContext();
            context.Add(client);
            context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            using AppDbContext context = new AppDbContext();
            context.Remove(book);
            context.SaveChanges();
        }

        public void DeleteClient(Client client)
        {
            using AppDbContext context = new AppDbContext();
            context.Remove(client);
            context.SaveChanges();
        }

        public void EditBook(Book book)
        {
            using AppDbContext context = new AppDbContext();
            context.Update(book);
            context.SaveChanges();
        }

        public void EditClient(Client client)
        {
            using AppDbContext context = new AppDbContext();
            context.Update(client);
            context.SaveChanges();
        }

        public Book GetBook(int id)
        {
            using AppDbContext context = new AppDbContext();
            var book = context.Books.Where(b => b.Id == id).FirstOrDefault();
            return book;
        }

        public Book GetBook(string name)
        {
            using AppDbContext context = new AppDbContext();
            var book = context.Books.Where(b => b.Name == name).FirstOrDefault();
            return book;
        }

        public List<Book> GetBooks()
        {
            using AppDbContext context = new AppDbContext();
            var books = context.Books.ToList();
            return books;
        }

        public Client GetClient(int id)
        {
            using AppDbContext context = new AppDbContext();
            var client = context.Clients.Where(c => c.Id == id).FirstOrDefault();
            return client;
        }

        public Client GetClient(string name)
        {
            using AppDbContext context = new AppDbContext();
            var client = context.Clients.Where(c => c.Name == name).FirstOrDefault();
            return client;
        }

        public List<Client> GetClients()
        {
            using AppDbContext context = new AppDbContext();
            var clients = context.Clients.ToList();
            return clients;
        }

        

    }
}
