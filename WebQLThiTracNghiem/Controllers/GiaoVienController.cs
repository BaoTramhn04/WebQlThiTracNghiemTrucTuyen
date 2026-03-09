using Microsoft.AspNetCore.Mvc;

namespace WebQLThiTracNghiem.Controllers
{
    public class GiaoVienController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult HocSinh() => View();
        public IActionResult CauHoi() => View();
        public IActionResult DeThi() => View();
        public IActionResult DotThi() => View();
    }
}