using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    //Dependanct injection
    {
        // Reqyests
        //localhost:5000
        [Route("")]
        [HttpGet]
        public string index(){
            return "hello from controller";
        }

        //localhost:5000/hello
        [Route("hello")]
        [HttpGet]
        public string Hello(){
            return "hi Again";
        }


        [HttpGet("user/{username}")]
        public string HelloUser(string username){
            return $"Hello {username}";
        }
    }
}