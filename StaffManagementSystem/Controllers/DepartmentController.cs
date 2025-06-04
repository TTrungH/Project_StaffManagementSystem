using Microsoft.AspNetCore.Mvc;

namespace StaffManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
