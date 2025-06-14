using Quiz_2.Models.Book;

namespace Quiz_2.Interface
{
    public interface IBookRepo
    {
        public List<BookDto> GetAll();
        public BookDto GetById(int id);
        public void Post(BookPostDto Book);
        public void Delete(int id);
        public void Update(BookDto BookDto);
    }
}
