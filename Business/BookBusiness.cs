using Data.Dtos;
using Data.Models;
using DataAccess.Repositories;

namespace Business
{
    public class BookBusiness
    {
        public static List<Book> GetAll()
        {
            return BookRepository.GetAll();
        }
        public static Book GetById(int bookId)
        {
            return BookRepository.GetById(bookId);
        }
        public static string Add(BookDTO book)
        {
            Writer? writer = WriterRepository.GetById(book.WriterId);
            if (writer != null)
            {
                BookRepository.Add(new Book { BookId = book.BookId, BookName = book.BookName, BookShelf = book.BookShelf, Writer = writer });
                return "Book successfully added.";
            }
            return "No writer found with writerId";
        }
        public static string Remove(int bookId)
        {
            Book? book = BookRepository.GetById(bookId);
            if (book != null)
            {
                BookRepository.Remove(book);
                return "The book has been deleted successfully.";
            }
            return "No book found with bookId";
        }
    }
}