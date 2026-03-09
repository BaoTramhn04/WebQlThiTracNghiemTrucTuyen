using Microsoft.AspNetCore.Mvc;

namespace WebQLThiTracNghiem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult DangNhap()
        {
            return View();
        }
    }
}