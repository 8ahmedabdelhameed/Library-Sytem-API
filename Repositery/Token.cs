using Quiz_2.Interface;

namespace Quiz_2.Repositery
{
    public class Token : Itoken
    { 
        private readonly IConfiguration _configuration;

        public Token(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
