using Quiz_2.Models.Book;
using System.ComponentModel.DataAnnotations;

namespace Quiz_2.Models.Author
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<BookDto> books { get; set; }
    }
}
