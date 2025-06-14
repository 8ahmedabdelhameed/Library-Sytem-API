using Quiz_2.Models.Book;
using System.ComponentModel.DataAnnotations;

namespace Quiz_2.Models.Genre
{
    public class GenreDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<BookDto> books { get; set; }
    }
}
