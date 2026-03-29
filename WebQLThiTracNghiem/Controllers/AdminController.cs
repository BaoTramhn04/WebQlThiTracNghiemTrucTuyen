using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebQLThiTracNghiem.Data;
using WebQLThiTracNghiem.Models;

namespace WebQLThiTracNghiem.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult BangDieuKhien()
        {
            ViewBag.SoNguoiDung = _context.NguoiDung.Count();
            ViewBag.SoVaiTro = _context.VaiTro.Count();
            ViewBag.SoNhatKy = _context.NhatKyHeThong.Count();

            ViewBag.SoGiaoVien = _context.GiaoVien.Count();
            ViewBag.SoHocSinh = _context.HocSinh.Count();
            ViewBag.SoLop = _context.Lop.Count();
            ViewBag.SoMon = _context.MonHoc.Count();

            ViewBag.SoHocSinhDangHoatDong = _context.HocSinh.Count(h => h.TrangThai);
            ViewBag.SoHocSinhNgungHoatDong = _context.HocSinh.Count(h => !h.TrangThai);

            ViewBag.SoGiaoVienDangHoatDong = _context.GiaoVien.Count(g => g.TrangThai);
            ViewBag.SoGiaoVienNgungHoatDong = _context.GiaoVien.Count(g => !g.TrangThai);

            return View();
        }

        // ===============================
        // DANH SÁCH GIÁO VIÊN
        // ===============================

        public IActionResult DanhSachGiaoVien(string keyword)
        {
            var query = _context.GiaoVien
                .Include(g => g.NguoiDung)
                .ThenInclude(n => n.HoSoCaNhan)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(g =>
                    g.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword));
            }

            return View(query.ToList());
        }

        // ===============================
        // THÊM / SỬA GIÁO VIÊN
        // ===============================

        [HttpPost]
        public IActionResult LuuGiaoVien(int? id, string username, string hoten)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hoten))
            {
                TempData["success"] = "Thiếu dữ liệu";
                return RedirectToAction("DanhSachGiaoVien");
            }

            if (id == null || id == 0)
            {
                var password = TaoMatKhauNgauNhien();

                var user = new NguoiDung
                {
                    TenDangNhap = username,
                    MatKhau = password,
                    TrangThai = true,
                    NgayTao = DateTime.Now,
                    MaVaiTro = 2
                };

                _context.NguoiDung.Add(user);
                _context.SaveChanges();

                var hs = new HoSoCaNhan
                {
                    MaNguoiDung = user.MaNguoiDung,
                    HoTen = hoten
                };

                _context.HoSoCaNhan.Add(hs);

                var gv = new GiaoVien
                {
                    MaNguoiDung = user.MaNguoiDung,
                    TrangThai = true
                };

                _context.GiaoVien.Add(gv);

                _context.SaveChanges();

                TempData["success"] = "Thêm giáo viên thành công. Mật khẩu: " + password;
            }
            else
            {
                var gv = _context.GiaoVien
                    .Include(g => g.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                    .FirstOrDefault(g => g.MaGiaoVien == id);

                if (gv != null)
                {
                    gv.NguoiDung.TenDangNhap = username;

                    if (gv.NguoiDung.HoSoCaNhan != null)
                    {
                        gv.NguoiDung.HoSoCaNhan.HoTen = hoten;
                    }

                    _context.SaveChanges();

                    TempData["success"] = "Cập nhật giáo viên thành công";
                }
            }

            return RedirectToAction("DanhSachGiaoVien");
        }

        // ===============================
        // XÓA GIÁO VIÊN
        // ===============================

        public IActionResult XoaGiaoVien(int id)
        {
            var gv = _context.GiaoVien
                .Include(x => x.NguoiDung)
                .FirstOrDefault(x => x.MaGiaoVien == id);

            if (gv != null)
            {
                _context.GiaoVien.Remove(gv);
                _context.SaveChanges();

                TempData["success"] = "Xóa giáo viên thành công";
            }

            return RedirectToAction("DanhSachGiaoVien");
        }

        // ===============================
        // DANH SÁCH HỌC SINH
        // ===============================

        public IActionResult DanhSachHocSinh(string keyword, int? lop)
        {
            var query = _context.HocSinh
                .Include(h => h.NguoiDung)
                .ThenInclude(n => n.HoSoCaNhan)
                .Include(h => h.Lop)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(h =>
                    h.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword));
            }

            if (lop.HasValue)
            {
                query = query.Where(h => h.MaLop == lop);
            }

            ViewBag.Lop = _context.Lop.ToList();

            return View(query.ToList());
        }

        // ===============================
        // THÊM / SỬA HỌC SINH
        // ===============================

        [HttpPost]
        public IActionResult LuuHocSinh(int? id, string username, string hoten, int malop)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hoten))
            {
                TempData["success"] = "Thiếu dữ liệu";
                return RedirectToAction("DanhSachHocSinh");
            }

            if (id == null || id == 0)
            {
                var password = TaoMatKhauNgauNhien();

                var user = new NguoiDung
                {
                    TenDangNhap = username,
                    MatKhau = password,
                    TrangThai = true,
                    NgayTao = DateTime.Now,
                    MaVaiTro = 3
                };

                _context.NguoiDung.Add(user);
                _context.SaveChanges();

                var hsCN = new HoSoCaNhan
                {
                    MaNguoiDung = user.MaNguoiDung,
                    HoTen = hoten
                };

                _context.HoSoCaNhan.Add(hsCN);

                var hs = new HocSinh
                {
                    MaNguoiDung = user.MaNguoiDung,
                    MaLop = malop,
                    SoBaoDanh = "SBD" + user.MaNguoiDung,
                    TrangThai = true
                };

                _context.HocSinh.Add(hs);

                _context.SaveChanges();

                TempData["success"] = "Thêm học sinh thành công. Mật khẩu: " + password;
            }
            else
            {
                var hs = _context.HocSinh
                    .Include(h => h.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                    .FirstOrDefault(h => h.MaHocSinh == id);

                if (hs != null)
                {
                    hs.NguoiDung.TenDangNhap = username;

                    if (hs.NguoiDung.HoSoCaNhan != null)
                    {
                        hs.NguoiDung.HoSoCaNhan.HoTen = hoten;
                    }

                    hs.MaLop = malop;

                    _context.SaveChanges();

                    TempData["success"] = "Cập nhật học sinh thành công";
                }
            }

            return RedirectToAction("DanhSachHocSinh");
        }

        // ===============================
        // PHÂN CÔNG GIẢNG DẠY + LỌC
        // ===============================

        public IActionResult PhanCongGiangDay(int? gv, int? lop, int? mon)
        {
            var query = _context.PhanCongGiangDays
                .Include(p => p.GiaoVien)
                .ThenInclude(g => g.NguoiDung)
                .ThenInclude(n => n.HoSoCaNhan)
                .Include(p => p.Lop)
                .Include(p => p.MonHoc)
                .AsQueryable();

            if (gv.HasValue)
                query = query.Where(p => p.MaGiaoVien == gv);

            if (lop.HasValue)
                query = query.Where(p => p.MaLop == lop);

            if (mon.HasValue)
                query = query.Where(p => p.MaMon == mon);

            ViewBag.GiaoVien = _context.GiaoVien
                .Include(g => g.NguoiDung)
                .ThenInclude(n => n.HoSoCaNhan)
                .ToList();

            ViewBag.Lop = _context.Lop.ToList();
            ViewBag.MonHoc = _context.MonHoc.ToList();

            return View(query.ToList());
        }

        // ===============================
        // THÊM PHÂN CÔNG
        // ===============================

        [HttpPost]
        public IActionResult TaoPhanCongGiangDay(int magv, int malop, int mamon)
        {
            bool daTonTai = _context.PhanCongGiangDays
                .Any(p => p.MaGiaoVien == magv && p.MaLop == malop && p.MaMon == mamon);

            if (daTonTai)
            {
                TempData["success"] = "Phân công này đã tồn tại";
                return RedirectToAction("PhanCongGiangDay");
            }

            _context.PhanCongGiangDays.Add(new PhanCongGiangDay
            {
                MaGiaoVien = magv,
                MaLop = malop,
                MaMon = mamon
            });

            _context.SaveChanges();

            TempData["success"] = "Phân công giảng dạy thành công";

            return RedirectToAction("PhanCongGiangDay");
        }

        // ===============================
        // XÓA PHÂN CÔNG
        // ===============================

        public IActionResult XoaPhanCong(int id)
        {
            var pc = _context.PhanCongGiangDays.Find(id);

            if (pc != null)
            {
                _context.PhanCongGiangDays.Remove(pc);
                _context.SaveChanges();
            }

            TempData["success"] = "Xóa phân công thành công";

            return RedirectToAction("PhanCongGiangDay");
        }

        // ===============================
        // RANDOM PASSWORD
        // ===============================

        private string TaoMatKhauNgauNhien(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();

            return new string(
                Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
        }
    }
}