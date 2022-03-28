using Data.Models;
using DataAccess.Repositories;

namespace Business
{
    public class WriterBusiness
    {
        public static List<Writer> GetAll()
        {
            return WriterRepository.GetAll();
        }
        public static Writer GetById(int writerId)
        {
            return WriterRepository.GetById(writerId);
        }
        public static string Add(Writer writer)
        {
            WriterRepository.Add(writer);
            return "Writer successfully added.";
        }
        public static string Remove(int writerId)
        {
            Writer? writer = WriterRepository.GetById(writerId);
            if (writer != null)
            {
                WriterRepository.Remove(writer);
                return "The writer has been deleted successfully.";
            }
            return "No writer found with writerId";
        }
    }
}
