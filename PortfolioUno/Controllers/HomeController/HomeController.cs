using Microsoft.AspNetCore.Mvc;

namespace PortfolioUNO
{
    public class HomeController : Controller{

        [HttpGet("")]
        public string Index(){
            return "This is my Index";
        }

        [HttpGet("projects")]
        public string Projects(){
            return "These are my Projects";
        }

        [HttpGet("{contact}")]
        public string Contacts(string contact){
            return $"This is my {contact}";
        }
    }
}