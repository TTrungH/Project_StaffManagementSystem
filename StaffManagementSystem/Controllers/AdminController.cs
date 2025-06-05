using Microsoft.AspNetCore.Mvc;

namespace StaffManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
