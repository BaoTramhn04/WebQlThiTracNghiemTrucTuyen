using Microsoft.AspNetCore.Mvc;
using WebQLThiTracNghiem.Data;

namespace WebQLThiTracNghiem.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        // =========================
        // TRANG ĐĂNG NHẬP
        // =========================

        public IActionResult DangNhap()
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId != null)
            {
                var role = HttpContext.Session.GetInt32("RoleId");

                if (role == 1)
                    return RedirectToAction("BangDieuKhien", "Admin");

                if (role == 2)
                    return RedirectToAction("BangDieuKhien", "GiaoVien");

                if (role == 3)
                    return RedirectToAction("TrangChu", "HocSinh");
            }

            return View();
        }

        // =========================
        // XỬ LÝ ĐĂNG NHẬP
        // =========================

        [HttpPost]
        public IActionResult DangNhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Vui lòng nhập đầy đủ thông tin";
                return View();
            }

            var user = _context.NguoiDung
                .FirstOrDefault(x => x.TenDangNhap == username && x.TrangThai);

            if (user == null)
            {
                ViewBag.Error = "Tài khoản không tồn tại hoặc đã bị khóa";
                return View();
            }

            if (user.MatKhau != password)
            {
                ViewBag.Error = "Sai mật khẩu";
                return View();
            }

            // =========================
            // LƯU SESSION
            // =========================

            HttpContext.Session.SetInt32("UserId", user.MaNguoiDung);
            HttpContext.Session.SetInt32("RoleId", user.MaVaiTro);

            // ================= ADMIN =================

            if (user.MaVaiTro == 1)
            {
                return RedirectToAction("BangDieuKhien", "Admin");
            }

            // ================= GIÁO VIÊN =================

            if (user.MaVaiTro == 2)
            {
                var gv = _context.GiaoVien
                    .FirstOrDefault(x => x.MaNguoiDung == user.MaNguoiDung);

                if (gv == null)
                {
                    ViewBag.Error = "Không tìm thấy thông tin giáo viên";
                    return View();
                }

                // lưu mã giáo viên
                HttpContext.Session.SetInt32("MaGiaoVien", gv.MaGiaoVien);

                return RedirectToAction("BangDieuKhien", "GiaoVien");
            }

            // ================= HỌC SINH =================

            if (user.MaVaiTro == 3)
            {
                var hs = _context.HocSinh
                    .FirstOrDefault(x => x.MaNguoiDung == user.MaNguoiDung);

                if (hs == null)
                {
                    ViewBag.Error = "Không tìm thấy thông tin học sinh";
                    return View();
                }

                HttpContext.Session.SetInt32("MaHocSinh", hs.MaHocSinh);

                return RedirectToAction("TrangChu", "HocSinh");
            }

            return View();
        }

        // =========================
        // ĐĂNG XUẤT
        // =========================

        public IActionResult DangXuat()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("DangNhap");
        }
    }
}