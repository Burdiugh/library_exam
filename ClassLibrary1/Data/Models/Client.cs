using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.data.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field Name of book is required.")]
        public string Name { get; set; }
        public int ValueOfMoney { get; set; }
        public List<Sales> Sales { get; set; }

        public override string ToString()
        {
            return $"Name: | {Name} | ";
        }

    }
}
