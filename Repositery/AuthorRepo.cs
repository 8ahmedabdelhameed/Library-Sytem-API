using Quiz_2.Configuration;
using Quiz_2.Interface;
using Quiz_2.Models.Author;

namespace Quiz_2.Repositery
{
    public class AuthorRepo : IAuthorRepo
    {
        private readonly AppDbContext _context;

        public AuthorRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
        }

        public List<AuthorDto> GetAll()
        {
        }

        public AuthorDto GetById(int id)
        {
        }

        public void Post(AuthorPostDto author)
        {
        }

        public void Update(AuthorDto authorDto)
        {
        }
    }
}
