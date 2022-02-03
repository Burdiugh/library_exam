using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.data.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field Name of book is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field Name of author is required.")]
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public string Genre { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime TheYearOfPublishing { get; set; }
        [Range(1,10000)]
        public int CostPrice { get; set; }
        [Range(1, 10000)]
        public int Price { get; set; }
        public List<Sales> Sales { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} | Price: {Price} ";
        }

    }
}
