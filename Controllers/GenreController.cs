using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz_2.Interface;

namespace Quiz_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepo genreRepo;

        public GenreController(IGenreRepo genreRepo)
        {
            this.genreRepo = genreRepo;
        }
    }
}
