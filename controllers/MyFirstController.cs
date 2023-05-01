using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
   public class MyFirstController : Controller
    {
        [Route("hello")]
        public string method1()
        {
            return "Hello From The Otherside";
        }
    }
    
}