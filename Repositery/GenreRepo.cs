using Quiz_2.Configuration;
using Quiz_2.Interface;
using Quiz_2.Models.Book;

namespace Quiz_2.Repositery
{
    public class GenreRepo : IBookRepo
    {
        private readonly AppDbContext _context;

        public GenreRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
        }

        public List<BookDto> GetAll()
        {
        }

        public BookDto GetById(int id)
        {
        }

        public void Post(BookPostDto Book)
        {
        }

        public void Update(BookDto BookDto)
        {
        }
    }
}
