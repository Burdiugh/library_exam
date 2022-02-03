using library.data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.data.Data.Interfaces
{
    public interface ILibraryRepository
    {

        List<Client> GetClients();
        List<Book> GetBooks();
        void AddBook(Book book);
        void AddClient(Client client);
        Book GetBook(int id);
        Book GetBook(string Name);
        Client GetClient(int id);
        Client GetClient(string Name);
        void DeleteBook(Book book);
        void DeleteClient(Client client);
        void EditBook(Book book);
        void EditClient(Client client);

        
        

    }
}
