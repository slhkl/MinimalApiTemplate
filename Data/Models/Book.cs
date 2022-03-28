using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookShelf { get; set; }
        public Writer? Writer { get; set; }
    }
}
