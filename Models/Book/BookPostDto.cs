using Quiz_2.Models.Author;
using Quiz_2.Models.Genre;

namespace Quiz_2.Models.Book
{
    public class BookPostDto
    { 
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public List<int> Authors { get; set; }
        public List<int> Genres { get; set; }
    }
}
