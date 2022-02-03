using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.data.Data.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;


        //public Sales(int idBook, int idClient)
        //{
        //    BookId = idBook;
        //    ClientId = idClient;
        //}

    }
}
