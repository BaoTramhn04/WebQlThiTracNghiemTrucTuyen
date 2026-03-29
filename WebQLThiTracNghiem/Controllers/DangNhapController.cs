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
            var vaiTro = HttpContext.Session.GetInt32("VaiTro");

            // 👉 Tránh vòng lặp redirect
            if (vaiTro == 1)
                return RedirectToAction("BangDieuKhien", "Admin");

            if (vaiTro == 2)
                return RedirectToAction("BangDieuKhien", "GiaoVien");

            if (vaiTro == 3)
                return RedirectToAction("DanhSachDotThi", "HocSinh");

            return View("~/Views/Home/DangNhap.cshtml");
        }

        // ===========================
        // POST: ĐĂNG NHẬP
        // ===========================
        [HttpPost]
        public IActionResult DangNhap(DangNhapHocSinhViewModel model)
        {
            var input = Request.Form["ThongTinDangNhap"].ToString();

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(model.MatKhau))
            {
                ViewBag.LoiDangNhap = "Vui lòng nhập đầy đủ thông tin";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            // =========================
            // 1. HỌC SINH (NHẬP SỐ)
            // =========================
            if (int.TryParse(input, out int maHocSinh))
            {
                var hs = _context.HocSinh
                    .FirstOrDefault(x => x.MaHocSinh == maHocSinh && x.TrangThai);

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

                // ✅ Session học sinh
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

            // =========================
            // 2. GIÁO VIÊN / ADMIN (NHẬP CHỮ)
            // =========================
            var userLogin = _context.NguoiDung
                .FirstOrDefault(x => x.TenDangNhap == input && x.TrangThai);

            if (userLogin == null || userLogin.MatKhau.Trim() != model.MatKhau.Trim())
            {
                ViewBag.LoiDangNhap = "Sai tên đăng nhập hoặc mật khẩu";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            // 🔥 FIX QUAN TRỌNG: map role chuẩn
            int vaiTro = userLogin.MaVaiTro;

            // Nếu DB bạn không đúng chuẩn → ép lại
            if (vaiTro != 1 && vaiTro != 2)
                vaiTro = 2; // mặc định giáo viên

            HttpContext.Session.SetInt32("VaiTro", vaiTro);
            HttpContext.Session.SetInt32("MaNguoiDung", userLogin.MaNguoiDung);

            HttpContext.Session.SetString("TenDangNhap", userLogin.TenDangNhap ?? "");
            // 🔥 LẤY TÊN MÔN GIÁO VIÊN DẠY
            var boMons = (from pc in _context.PhanCongGiangDays
                          join mh in _context.MonHoc on pc.MaMon equals mh.MaMonHoc
                          where pc.MaGiaoVien == _context.GiaoVien
                                .Where(gv => gv.MaNguoiDung == userLogin.MaNguoiDung)
                                .Select(gv => gv.MaGiaoVien)
                                .FirstOrDefault()
                          select mh.TenMonHoc)
                          .Distinct()
                          .ToList();

            // 👉 lưu vào session
            HttpContext.Session.SetString("BoMonDay", string.Join(", ", boMons));
            var hoSoGV = _context.HoSoCaNhan
                .FirstOrDefault(x => x.MaNguoiDung == userLogin.MaNguoiDung);

            HttpContext.Session.SetString("TenNguoiDung", hoSoGV?.HoTen ?? "Người dùng");

            // =========================
            // ĐIỀU HƯỚNG
            // =========================
            if (vaiTro == 1)
                return RedirectToAction("BangDieuKhien", "Admin");

            if (vaiTro == 2)
                return RedirectToAction("BangDieuKhien", "GiaoVien");

            return RedirectToAction("DangNhap");
        }

        // ===========================
        // ĐĂNG XUẤT
        // ===========================
        public IActionResult DangXuat()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("DangNhap");
        }
    }
}