using ControllersExample.Models;
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
        public JsonResult Anime()
        {
            Anime anime = new Anime() {
                Id = Guid.NewGuid(),
                Name = "Darwin's Game",
                Description = "One of The Greatest Anime's Of All Time"
            };

            return new JsonResult(anime);
        }
        [Route("/test")]
        public string Test()
        {
            return "Test Endpoint";
        }
        [Route("/docs/{id:int}")]
        public string Documents()
        {
            int id = Convert.ToInt32(Request.RouteValues["id"]);
            return $"Document {id}";
        }
    }
    
}