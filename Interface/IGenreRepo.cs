using Quiz_2.Models.Genre;

namespace Quiz_2.Interface
{
    public interface IGenreRepo
    {
        public List<GenreDto> GetAll();
        public GenreDto GetById(int id);
        public void Post(GenrePostDto Genre);
        public void Delete(int id);
        public void Update(GenreDto GenreDto);
    }
}
