using Microsoft.AspNetCore.Mvc;

namespace WebQLThiTracNghiem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult NguoiDung()
        {
            return View();
        }

        public IActionResult VaiTro()
        {
            return View();
        }

        public IActionResult NhatKy()
        {
            return View();
        }
    }
}