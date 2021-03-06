using library.data.Data.Interfaces;
using library.data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.service
{
    public class LibraryService
    {
        readonly private ILibraryRepository _libraryRepository;

        public LibraryService(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public List<Client> GetClients()
        {
            return _libraryRepository.GetClients();
        }

        public List<Book> GetBooks()
        {
            return _libraryRepository.GetBooks();
        }

        public void AddBook(Book book)
        {
            _libraryRepository.AddBook(book);
        }
        public void AddClient(Client client)
        {
            _libraryRepository.AddClient(client);
        }
        public Book GetBook(int id)
        {
            return _libraryRepository.GetBook(id);
        }
        public Book GetBook(string name)
        {
            return _libraryRepository.GetBook(name);
        }

        public Client GetClient(int id)
        {
            return _libraryRepository.GetClient(id);
        }
        public Client GetClient(string name)
        {
            return _libraryRepository.GetClient(name);
        }

        public void DeleteBook(Book book)
        {
            _libraryRepository.DeleteBook(book);
        }
        public void DeleteClient(Client client)
        {
            _libraryRepository.DeleteClient(client);
        }

        public void EditBook(Book book)
        {
            _libraryRepository.EditBook(book);
        }

        public void EditClient(Client client)
        {
            _libraryRepository.EditClient(client);
        }

        public void AddSales(Book book, Client client)
        {

            Sales sale = new Sales()
            {
                BookId = book.Id,
                ClientId = client.Id
            };
            _libraryRepository.UpdateClientsValueOfMOney(client,client.ValueOfMoney-book.Price);
            _libraryRepository.AddSale(sale);
        }

        public List<Sales> GetSales()
        {
            return _libraryRepository.GetSales();
        }

        public List<Book> GetBooksByDate(DateTime date)
        {
            return _libraryRepository.GetBooksByDate(date);
        }
        public List<Book> GetBooksByGenre(string genre)
        {
            return _libraryRepository.GetBooksByGenre(genre);
        }

        public void Discount(string genre)
        {
            _libraryRepository.Discount(genre);
        }

        public void SetOverprice(string genre)
        {
            _libraryRepository.SetOverprice(genre);
        }

        public List<Book> GetSortedBooksAsc()
        {
           return _libraryRepository.GetSortedBooksByAsc();
        }
         public List<Book> GetSortedBooksDes()
        {
           return _libraryRepository.GetSortedBooksByDes();
        }
        
       public List<Book> GetSortedBooksByNames()
        {
            return _libraryRepository.GetSortedBooksByNames();
        }


    }
}
