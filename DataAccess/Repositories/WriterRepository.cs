using Data.Models;

namespace DataAccess.Repositories
{
    public class WriterRepository
    {
        private static readonly List<Writer> WriterList = new()
        {
            new Writer { WriterId = 1, WriterName = "Vitor Hugo" }
        };
        public static List<Writer> GetAll()
        {
            return WriterList;
        }
        public static Writer GetById(int writerId)
        {
            Writer? writer = WriterList.FirstOrDefault(x => x.WriterId == writerId);
            return writer;
        }
        public static void Add(Writer writer)
        {
            WriterList.Add(writer);
        }
        public static void Remove(Writer writer)
        {
            WriterList.Remove(writer);
        }
    }
}
