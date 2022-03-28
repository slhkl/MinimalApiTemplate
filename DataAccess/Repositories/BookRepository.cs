using Data.Models;

namespace DataAccess.Repositories
{
    public class BookRepository
    {
        private static readonly List<Book> BookList = new()
        {
            new Book
            {
                BookId = 1,
                BookName = "sefiller",
                BookShelf = "A1",
                Writer = new Writer { WriterId = 1, WriterName = "Vitor Hugo" }
            }
        };
        
        public static List<Book> GetAll()
        {
                return BookList;
        }
        public static Book GetById(int bookId)
        {
            Book? book = BookList.FirstOrDefault(x => x.BookId == bookId);
            return book;
        }
        public static void Add(Book book)
        {
            BookList.Add(book);
        }
        public static void Remove(Book book)
        {
            BookList.Remove(book);
        }
    }
}