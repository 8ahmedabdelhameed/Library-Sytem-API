using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Quiz_2.Models.Book;
namespace Quiz_2.Models.Genre
{
    public class Genres
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Books> books { get; set; }
    }
}
