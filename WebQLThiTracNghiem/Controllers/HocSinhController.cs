using Microsoft.AspNetCore.Mvc;

namespace WebQLThiTracNghiem.Controllers
{
    public class HocSinhController : Controller
    {
        public IActionResult DotThi() => View();
        public IActionResult LamBai() => View();
        public IActionResult KetQua() => View();
    }
}