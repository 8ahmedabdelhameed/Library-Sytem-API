using Microsoft.EntityFrameworkCore;
using Quiz_2.Configuration;
using Quiz_2.Interface;
using Quiz_2.Models.Author;
using Quiz_2.Models.Book;
using Quiz_2.Models.Genre;

namespace Quiz_2.Repositery
{
    public class BookRepo : IBookRepo
    {
        private readonly AppDbContext _context;

        public BookRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
        }
        public List<BookDto> GetAll()
        {
            var books = _context.Books
                .Include(b => b.Authors) 
                .Include(b => b.Genres)  
                .Select(b => new BookDto
                {
                    BookId = b.BookId, 
                    Title = b.Title,
                    PublishedYear = b.PublishedYear,
                    Authors = b.Authors.Select(a => new AuthorDto
                    {
                        Id = a.Id,
                        Name = a.Name,
                        PhoneNumber = a.PhoneNumber,
                        EmailAddress = a.EmailAddress,
                        
                    }).ToList(),
                    Genres = b.Genres.Select(g => new GenreDto
                    {
                        Id = g.Id,
                        Name = g.Name
                    }).ToList()
                })
                .ToList(); 

            return books;
        }

        public BookDto GetById(int id)
        {
            var book = _context.Books
                .Include(b => b.Authors)  
                .Include(b => b.Genres)  
                .FirstOrDefault(b => b.BookId == id); 
            if (book == null)
            {
                return null;   
            }
            return new BookDto
            {
                BookId = book.BookId,  
                Title = book.Title,
                PublishedYear = book.PublishedYear,
                Authors = book.Authors.Select(a => new AuthorDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    PhoneNumber = a.PhoneNumber,
                    EmailAddress = a.EmailAddress
                }).ToList(),
                Genres = book.Genres.Select(g => new GenreDto
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList()
            };
        }
        public void Post(BookPostDto bookPostDto)
        {
            Books books = new Books();
            books.Authors = bookPostDto.Authors.ToList();
        }

        public void Update(BookDto BookDto)
        {
        }
    }
}
