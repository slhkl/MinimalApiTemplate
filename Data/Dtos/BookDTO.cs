using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookShelf { get; set; }
        public int WriterId { get; set; }
    }
}
