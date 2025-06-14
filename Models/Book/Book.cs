using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Quiz_2.Models;
using Quiz_2.Models.Author;
using Quiz_2.Models.Genre;
namespace Quiz_2.Models.Book
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public List<Authors> Authors { get; set; }
        public List<Genres> Genres { get; set; }
    }

}
