using Quiz_2.Models.Author;
using Quiz_2.Models.Genre;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Quiz_2.Interface
{
    public interface IAuthorRepo
    {
     public List<AuthorDto> GetAll();
     public AuthorDto GetById(int id);
     public void Post(AuthorPostDto author);
     public void Delete(int id);
     public void Update(AuthorDto authorDto);

    }
}
