using ControllersExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
   public class MyFirstController : Controller
    {
        [Route("/")]
        public ContentResult Index(string? value)
        {
            return Content($"<h1>{value}</h1>","text/html");
            
        }
        [Route("/anime")]
        public IActionResult Anime()
        {
            Anime anime = new Anime() {
                Id = Guid.NewGuid(),
                Name = "Darwin's Game",
                Description = "One of The Greatest Anime's Of All Time"
            };

            return Json(anime);
        }
        [Route("/test")]
        public string Test()
        {
            return "Test Endpoint";
        }
        [Route("/docs/{id:int}")]
        public IActionResult Documents(int? id)
        {
            if (id == 4)
            {
                return BadRequest("You gave a ID of 4");
            }
            
            return Content($"Document {id}", "text/plain");
        }
    }
    
}