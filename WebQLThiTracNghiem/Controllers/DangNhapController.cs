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

        [HttpGet]
        public IActionResult DangNhap()
        {
            var maNguoiDung = HttpContext.Session.GetInt32("MaNguoiDung");
            var vaiTro = HttpContext.Session.GetInt32("RoleId");

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

        [HttpPost]
        public IActionResult DangNhap(DangNhapHocSinhViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            if (string.IsNullOrWhiteSpace(model.SoBaoDanh) || string.IsNullOrWhiteSpace(model.MatKhau))
            {
                ViewBag.LoiDangNhap = "Vui lòng nhập đầy đủ thông tin";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            HttpContext.Session.Clear();

            var hocSinh = (from hs in _context.HocSinh
                           join nd in _context.NguoiDung
                           on hs.MaNguoiDung equals nd.MaNguoiDung
                           where hs.SoBaoDanh == model.SoBaoDanh
                                 && hs.TrangThai == true
                                 && nd.MatKhau == model.MatKhau
                                 && nd.TrangThai == true
                                 && nd.MaVaiTro == 3
                           select new
                           {
                               hs.MaHocSinh,
                               hs.MaNguoiDung,
                               hs.SoBaoDanh,
                               nd.TenDangNhap,
                               nd.MaVaiTro
                           }).FirstOrDefault();

            if (hocSinh != null)
            {
                HttpContext.Session.SetInt32("UserId", hocSinh.MaNguoiDung);
                HttpContext.Session.SetInt32("RoleId", hocSinh.MaVaiTro);

                HttpContext.Session.SetInt32("MaHocSinh", hocSinh.MaHocSinh);
                HttpContext.Session.SetInt32("MaNguoiDung", hocSinh.MaNguoiDung);
                HttpContext.Session.SetString("SoBaoDanh", hocSinh.SoBaoDanh ?? "");
                HttpContext.Session.SetString("TenDangNhap", hocSinh.TenDangNhap ?? "");

                return RedirectToAction("DanhSachDotThi", "HocSinh");
            }

            var user = _context.NguoiDung
                .FirstOrDefault(x => x.TenDangNhap == model.SoBaoDanh && x.TrangThai);

            if (user == null)
            {
                ViewBag.LoiDangNhap = "Tài khoản không tồn tại hoặc mật khẩu không đúng";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            if (user.MatKhau != model.MatKhau)
            {
                ViewBag.LoiDangNhap = "Tài khoản không tồn tại hoặc mật khẩu không đúng";
                return View("~/Views/Home/DangNhap.cshtml", model);
            }

            HttpContext.Session.SetInt32("UserId", user.MaNguoiDung);
            HttpContext.Session.SetInt32("RoleId", user.MaVaiTro);
            HttpContext.Session.SetInt32("MaNguoiDung", user.MaNguoiDung);
            HttpContext.Session.SetString("TenDangNhap", user.TenDangNhap ?? "");

            if (user.MaVaiTro == 1)
            {
                var hoSo = _context.HoSoCaNhan
                    .FirstOrDefault(x => x.MaNguoiDung == user.MaNguoiDung);

                HttpContext.Session.SetString("TenNguoiDung", hoSo?.HoTen ?? user.TenDangNhap ?? "Admin");
                TempData["LoginSuccess"] = "Đăng nhập thành công!";

                return RedirectToAction("BangDieuKhien", "Admin");
            }

            if (user.MaVaiTro == 2)
            {
                var gv = _context.GiaoVien
                    .FirstOrDefault(x => x.MaNguoiDung == user.MaNguoiDung && x.TrangThai);

                if (gv == null)
                {
                    ViewBag.LoiDangNhap = "Không tìm thấy thông tin giáo viên";
                    return View("~/Views/Home/DangNhap.cshtml", model);
                }

                var hoSo = _context.HoSoCaNhan
                    .FirstOrDefault(x => x.MaNguoiDung == user.MaNguoiDung);

                var monDay = (from pc in _context.PhanCongGiangDays
                              join mh in _context.MonHoc on pc.MaMon equals mh.MaMonHoc
                              where pc.MaGiaoVien == gv.MaGiaoVien
                              select mh.TenMonHoc)
                              .Distinct()
                              .ToList();

                HttpContext.Session.SetInt32("MaGiaoVien", gv.MaGiaoVien);
                HttpContext.Session.SetString("TenNguoiDung", hoSo?.HoTen ?? user.TenDangNhap ?? "Giáo viên");
                HttpContext.Session.SetString("BoMonDay", monDay.Any() ? string.Join(", ", monDay) : "Chưa phân công môn dạy");

                TempData["LoginSuccess"] = "Đăng nhập thành công!";

                return RedirectToAction("BangDieuKhien", "GiaoVien");
            }

            if (user.MaVaiTro == 3)
            {
                var hs = _context.HocSinh
                    .FirstOrDefault(x => x.MaNguoiDung == user.MaNguoiDung && x.TrangThai);

                if (hs == null)
                {
                    ViewBag.LoiDangNhap = "Không tìm thấy thông tin học sinh";
                    return View("~/Views/Home/DangNhap.cshtml", model);
                }

                HttpContext.Session.SetInt32("MaHocSinh", hs.MaHocSinh);
                HttpContext.Session.SetString("SoBaoDanh", hs.SoBaoDanh ?? "");

                return RedirectToAction("DanhSachDotThi", "HocSinh");
            }

            ViewBag.LoiDangNhap = "Vai trò không hợp lệ";
            return View("~/Views/Home/DangNhap.cshtml", model);
        }

        public IActionResult DangXuat()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("DangNhap");
        }
    }
}