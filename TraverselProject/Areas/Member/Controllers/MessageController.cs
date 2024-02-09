using Microsoft.AspNetCore.Mvc;

namespace TraverselProject.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
