using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.ComponentModel.DataAnnotations;
using Quiz_2.Models.Book;
namespace Quiz_2.Models.Author
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public List<Books> books { get; set; }
    }
}
