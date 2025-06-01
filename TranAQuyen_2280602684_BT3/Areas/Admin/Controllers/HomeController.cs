using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TranAQuyen_2280602684_BT3.Areas.Admin.Models;

namespace TranAQuyen_2280602684_BT3.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
