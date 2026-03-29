using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebQLThiTracNghiem.Data;
using WebQLThiTracNghiem.Models.ViewModels;

namespace WebQLThiTracNghiem.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ===========================
        // GET: ĐĂNG NHẬP
        // ===========================
        [HttpGet]
        public IActionResult DangNhap()
        {
            var maNguoiDung = HttpContext.Session.GetInt32("MaNguoiDung");
            var vaiTro = HttpContext.Session.GetInt32("VaiTro");

            if (maNguoiDung != null && vaiTro != null)
            {
                if (vaiTro == 1)
                    return RedirectToAction("BangDieuKhien", "Admin");

                if (vaiTro == 2)
                    return RedirectToAction("BangDieuKhien", "GiaoVien");

                if (vaiTro == 3)
                    return RedirectToAction("DanhSachDotThi", "HocSinh");
            }

            return View("~/Views/Home/DangNhap.cshtml");
        }

        // ===========================
        // POST: ĐĂNG NHẬP
        // ===========================
        [HttpPost]
        public IActionResult DangNhap(DangNhapHocSinhViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            if (model.MaHocSinh <= 0 || string.IsNullOrWhiteSpace(model.MatKhau))
            {
                ViewBag.LoiDangNhap = "Vui lòng nhập đầy đủ thông tin";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            // Tìm học sinh theo MaHocSinh (int)
            var hs = _context.HocSinh
                .FirstOrDefault(x => x.MaHocSinh == model.MaHocSinh && x.TrangThai);

            if (hs == null)
            {
                ViewBag.LoiDangNhap = "Mã học sinh không tồn tại";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            var user = _context.NguoiDung
                .FirstOrDefault(x => x.MaNguoiDung == hs.MaNguoiDung && x.TrangThai);

            if (user == null || user.MatKhau.Trim() != model.MatKhau.Trim())
            {
                ViewBag.LoiDangNhap = "Sai mật khẩu";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            // ✅ LƯU SESSION ĐÚNG KIỂU INT
            HttpContext.Session.SetInt32("VaiTro", 3);
            HttpContext.Session.SetInt32("MaNguoiDung", user.MaNguoiDung);
            HttpContext.Session.SetInt32("MaHocSinh", hs.MaHocSinh);

            HttpContext.Session.SetString("TenDangNhap", user.TenDangNhap ?? "");
            HttpContext.Session.SetString("SoBaoDanh", hs.SoBaoDanh ?? "");

            var hoSo = _context.HoSoCaNhan
                .FirstOrDefault(x => x.MaNguoiDung == user.MaNguoiDung);

            HttpContext.Session.SetString("TenNguoiDung", hoSo?.HoTen ?? "Học sinh");

            return RedirectToAction("DanhSachDotThi", "HocSinh");
        }

        public IActionResult DangXuat()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("DangNhap");
        }
    }
}