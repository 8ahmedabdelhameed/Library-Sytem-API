using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz_2.Interface;

namespace Quiz_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepo _bookRepo;

        public BookController(IBookRepo bookRepo)
        {
            this._bookRepo = bookRepo;
        }
    }
}
