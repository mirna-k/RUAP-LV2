using Microsoft.AspNetCore.Mvc;

namespace ContactMenager.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"
            };
        }
    }
}
