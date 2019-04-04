using Microsoft.AspNetCore.Mvc;
using System;


namespace TimeDisplay{

    
    public class HomeController : Controller{
        
        [HttpGet("")]
        public ViewResult Home(){
            DateTime adate = DateTime.Now;
            ViewBag.Example = adate.ToString("MMMM dd, yyyy");
            ViewBag.Time = adate.ToString("h:mm tt");
            return View();
        }
    }
}