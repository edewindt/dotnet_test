using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
   public class MyFirstController : Controller
    {
        [Route("/")]
        public ContentResult Index()
        {
            return Content("<h1>Bruh</h1>","text/html");
            
        }
        [Route("/anime")]
        public string Anime()
        {
            return "Anime Endpoint";
        }
        [Route("/test")]
        public string Test()
        {
            return "Test Endpoint";
        }
        [Route("/docs/{id}")]
        public string Documents()
        {
            int id = Convert.ToInt32(Request.RouteValues["id"]);
            return $"Document {id}";
        }
    }
    
}