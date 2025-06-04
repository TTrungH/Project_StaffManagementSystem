using Microsoft.AspNetCore.Mvc;

namespace StaffManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
