using Microsoft.AspNetCore.Mvc;

namespace Midterm_ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
