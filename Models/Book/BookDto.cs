using Quiz_2.Models.Author;
using Quiz_2.Models.Genre;

namespace Quiz_2.Models.Book
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public List<AuthorDto> Authors { get; set; }
        public List<GenreDto> Genres { get; set; }
    }
}
