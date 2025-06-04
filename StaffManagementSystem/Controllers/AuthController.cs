using Microsoft.AspNetCore.Mvc;

namespace StaffManagementSystem.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
