using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.IO;
using WebQLThiTracNghiem.Data;
using WebQLThiTracNghiem.Models;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
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
            // 🔥 TỔNG QUAN
            ViewBag.SoNguoiDung = _context.NguoiDung.Count();
            ViewBag.SoVaiTro = _context.VaiTro.Count();
            ViewBag.SoNhatKy = _context.NhatKyHeThongs.Count();

            ViewBag.SoGiaoVien = _context.GiaoVien.Count();
            ViewBag.SoHocSinh = _context.HocSinh.Count();
            ViewBag.SoLop = _context.Lop.Count();
            ViewBag.SoMon = _context.MonHoc.Count();

            // 🔥 TRẠNG THÁI HOẠT ĐỘNG
            ViewBag.SoHocSinhDangHoatDong = _context.HocSinh.Count(h => h.TrangThai);
            ViewBag.SoHocSinhNgungHoatDong = _context.HocSinh.Count(h => !h.TrangThai);

            ViewBag.SoGiaoVienDangHoatDong = _context.GiaoVien.Count(g => g.TrangThai);
            ViewBag.SoGiaoVienNgungHoatDong = _context.GiaoVien.Count(g => !g.TrangThai);

            // 🔥 LIÊN KẾT LOGIC HỆ THỐNG
            ViewBag.SoChuyenDe = _context.ChuyenDe.Count();
            ViewBag.SoCauHoi = _context.CauHoi.Count();

            // 🔥 CẢNH BÁO QUẢN TRỊ (RẤT QUAN TRỌNG)
            ViewBag.LopChuaPhanCong = _context.Lop.Count(l =>
                !_context.PhanCongGiangDays.Any(p => p.MaLop == l.MaLop));

            ViewBag.MonChuaCoChuyenDe = _context.MonHoc.Count(m =>
                !_context.ChuyenDe.Any(cd => cd.MaMonHoc == m.MaMonHoc));

            ViewBag.GiaoVienChuaDuocPhanCong = _context.GiaoVien.Count(g =>
                !_context.PhanCongGiangDays.Any(p => p.MaGiaoVien == g.MaGiaoVien));

            // 🔥 LOG GẦN NHẤT
            ViewBag.Logs = _context.NhatKyHeThongs
                .OrderByDescending(x => x.ThoiGianThucHien)
                .Take(5)
                .ToList();

            return View();
        }



        // ===============================
        // DANH SÁCH GIÁO VIÊN
        // ===============================

        public IActionResult DanhSachGiaoVien(string keyword, int page = 1)
        {
            int pageSize = 20;

            var query = _context.GiaoVien
                .Include(g => g.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x =>
                    x.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword));
            }

            int totalItems = query.Count();

            var data = query
                .OrderBy(x => x.MaGiaoVien)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            ViewBag.Keyword = keyword;

            return View(data);
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
                GhiLog("Thêm giáo viên", "Giáo viên", user.MaNguoiDung.ToString());

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
                    GhiLog("Cập nhật giáo viên", "Giáo viên", gv.MaGiaoVien.ToString());

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
                gv.TrangThai = false;
                gv.NguoiDung.TrangThai = false;

                _context.SaveChanges();
                GhiLog("Khóa giáo viên", "Giáo viên", id.ToString());
            }

            TempData["success"] = "Đã khóa giáo viên";

            return RedirectToAction("DanhSachGiaoVien");
        }

        // ===============================
        // DANH SÁCH HỌC SINH
        // ===============================

        public IActionResult DanhSachHocSinh(string keyword, int? lop, int page = 1)
        {
            int pageSize = 30;

            var query = _context.HocSinh
                .Include(h => h.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                .Include(h => h.Lop)
                .AsQueryable();

            // 🔍 tìm kiếm
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x =>
                    x.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword));
            }

            // 🔥 LỌC LỚP (CÁI BẠN ĐANG THIẾU)
            if (lop.HasValue)
            {
                query = query.Where(x => x.MaLop == lop.Value);
            }

            int totalItems = query.Count();

            var data = query
                .OrderBy(x => x.MaHocSinh)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.Lop = _context.Lop.ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            ViewBag.Keyword = keyword;
            ViewBag.SelectedLop = lop;

            return View(data);
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
                GhiLog("Thêm học sinh", "Học sinh", user.MaNguoiDung.ToString());

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
        // DANH SÁCH LỚP
        // ===============================
        public IActionResult Lop(string keyword)
        {
            var list = _context.Lop.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(x =>
                    x.KyHieuLop.Contains(keyword) ||
                    x.TenLop.Contains(keyword) ||
                    x.MaLop.ToString().Contains(keyword)
                );
            }

            return View(list.ToList());
        }
        public IActionResult SuaLop(int id)
        {
            var lop = _context.Lop.Find(id);
            return View(lop);
        }
        [HttpPost]
        public IActionResult ThemLop(string kyHieu, string tenLop, string namHoc)
        {
            if (string.IsNullOrEmpty(kyHieu) || string.IsNullOrEmpty(tenLop))
            {
                TempData["error"] = "Vui lòng nhập đầy đủ!";
                return RedirectToAction("Lop");
            }

            if (_context.Lop.Any(x => x.KyHieuLop == kyHieu))
            {
                TempData["error"] = "Ký hiệu lớp đã tồn tại!";
                return RedirectToAction("Lop");
            }
            if (string.IsNullOrWhiteSpace(kyHieu) || string.IsNullOrWhiteSpace(tenLop))
            {
                TempData["error"] = "Không được để trống!";
                return RedirectToAction("Lop");
            }
            if (_context.Lop.Any(x => x.KyHieuLop == kyHieu && x.NamHoc == namHoc))
            {
                TempData["error"] = "Lớp đã tồn tại trong năm học!";
                return RedirectToAction("Lop");
            }

            _context.Lop.Add(new Lop
            {
                KyHieuLop = kyHieu,
                TenLop = tenLop,
                NamHoc = namHoc
            });

            _context.SaveChanges();
            GhiLog("Thêm lớp", "Lớp", kyHieu);
            TempData["success"] = "Thêm lớp thành công!";
            return RedirectToAction("Lop");
        }
        [HttpPost]
        public IActionResult SuaLop(Lop model)
        {
            var lop = _context.Lop.Find(model.MaLop);

            if (lop != null)
            {
                lop.KyHieuLop = model.KyHieuLop;
                lop.TenLop = model.TenLop;
                lop.NamHoc = model.NamHoc;

                _context.SaveChanges();
                GhiLog("Sửa lớp", "Lớp", model.MaLop.ToString());
            }

            return RedirectToAction("Lop");
        }
        public IActionResult XoaLop(int id)
        {
            if (_context.HocSinh.Any(x => x.MaLop == id))
            {
                TempData["error"] = "Không thể xóa lớp đã có học sinh!";
                return RedirectToAction("Lop");
            }

            var lop = _context.Lop.Find(id);
            if (lop != null)
            {
                _context.Lop.Remove(lop);
                _context.SaveChanges();
                GhiLog("Xóa lớp", "Lớp", id.ToString());
            }

            TempData["success"] = "Xóa lớp thành công!";
            return RedirectToAction("Lop");
        }
        // ===============================
        // DANH SÁCH MÔN
        // ===============================
        public IActionResult MonHoc(string keyword, int page = 1)
        {
            int pageSize = 20; // 🔥 số dòng mỗi trang

            var query = _context.MonHoc
                .Include(m => m.PhanCongGiangDays)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.TenMonHoc.Contains(keyword));
            }

            int totalItems = query.Count();

            var data = query
                .OrderBy(x => x.MaMonHoc)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            ViewBag.Keyword = keyword;

            return View(data);
        }
        // ===============================
        // THÊM MÔN
        // ===============================
        [HttpPost]
        public IActionResult ThemMon(string tenMon)
        {
            if (string.IsNullOrWhiteSpace(tenMon))
            {
                TempData["error"] = "Không được để trống!";
                return RedirectToAction("MonHoc");
            }

            if (_context.MonHoc.Any(x => x.TenMonHoc == tenMon))
            {
                TempData["error"] = "Môn đã tồn tại!";
                return RedirectToAction("MonHoc");
            }

            var mon = new MonHoc
            {
                TenMonHoc = tenMon
              
            };

            _context.MonHoc.Add(mon);
            _context.SaveChanges();

            GhiLog("Thêm môn", "Môn học", mon.MaMonHoc.ToString());

            TempData["success"] = "Thêm môn thành công!";
            return RedirectToAction("MonHoc");
        }

        [HttpPost]
        public IActionResult SuaMon(int id, string tenMon)
        {
            var mon = _context.MonHoc.Find(id);

            if (mon == null)
                return NotFound();

            mon.TenMonHoc = tenMon;

            _context.SaveChanges();

            GhiLog("Sửa môn", "Môn học", id.ToString());

            TempData["success"] = "Cập nhật thành công!";
            return RedirectToAction("MonHoc");
        }
        // ===============================
        // XÓA MÔN
        // ===============================
        public IActionResult XoaMon(int id)
        {
            var mon = _context.MonHoc.Find(id);

            if (mon == null)
                return RedirectToAction("MonHoc");

            // ❌ check liên kết
            if (_context.PhanCongGiangDays.Any(x => x.MaMon == id))
            {
                TempData["error"] = "Môn đang được phân công, không thể xóa!";
                return RedirectToAction("MonHoc");
            }

            // 🔥 DELETE THẬT
            _context.MonHoc.Remove(mon);
            _context.SaveChanges();

            GhiLog("Xóa môn", "Môn học", id.ToString());

            TempData["success"] = "Xóa môn thành công!";
            return RedirectToAction("MonHoc");
        }

        public IActionResult ChiTiet(int id)
        {
            var mon = _context.MonHoc
                .Include(m => m.PhanCongGiangDays)
                    .ThenInclude(p => p.GiaoVien)
                        .ThenInclude(g => g.NguoiDung)
                            .ThenInclude(n => n.HoSoCaNhan)
                .Include(m => m.PhanCongGiangDays)
                    .ThenInclude(p => p.Lop)
                .FirstOrDefault(m => m.MaMonHoc == id);

            return View(mon);
        }
        // ===============================
        // DANH SÁCH CHUYÊN ĐỀ
        // ===============================
        public IActionResult ChuyenDe(string keyword, int? mon)
        {
            var query = _context.ChuyenDe
                .Include(x => x.MonHoc)
                .Include(x => x.CauHois)
                .AsQueryable();

            // 🔍 search
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.TenChuyenDe.Contains(keyword));
            }

            // 🔥 lọc theo môn
            if (mon != null)
            {
                query = query.Where(x => x.MaMonHoc == mon);
            }

            ViewBag.MonHoc = _context.MonHoc.ToList();
            ViewBag.SelectedMon = mon;
            ViewBag.Keyword = keyword;

            return View(query.ToList());
        }

        // ===============================
        // THÊM CHUYÊN ĐỀ
        // ===============================
        [HttpPost]
        public IActionResult ThemChuyenDe(string tenChuyenDe, int maMonHoc)
        {
            if (string.IsNullOrWhiteSpace(tenChuyenDe))
            {
                TempData["error"] = "Không được để trống!";
                return RedirectToAction("ChuyenDe");
            }

            if (_context.ChuyenDe.Any(x => x.TenChuyenDe == tenChuyenDe && x.MaMonHoc == maMonHoc))
            {
                TempData["error"] = "Chuyên đề đã tồn tại!";
                return RedirectToAction("ChuyenDe");
            }

            _context.ChuyenDe.Add(new ChuyenDe
            {
                TenChuyenDe = tenChuyenDe,
                MaMonHoc = maMonHoc
            });

            _context.SaveChanges();

            TempData["success"] = "Thêm chuyên đề thành công!";
            return RedirectToAction("ChuyenDe");
        }
        // SỬA CHUYÊN ĐỀ
        public IActionResult SuaChuyenDe(int id, string tenChuyenDe, int maMonHoc)
        {
            var cd = _context.ChuyenDe.Find(id);

            if (cd == null)
                return RedirectToAction("ChuyenDe");

            tenChuyenDe = tenChuyenDe.Trim();

            // 🔥 check trùng
            if (_context.ChuyenDe.Any(x =>
                x.TenChuyenDe == tenChuyenDe &&
                x.MaMonHoc == maMonHoc &&
                x.MaChuyenDe != id))
            {
                TempData["error"] = "Chuyên đề đã tồn tại!";
                return RedirectToAction("ChuyenDe");
            }

            cd.TenChuyenDe = tenChuyenDe;
            cd.MaMonHoc = maMonHoc;

            _context.SaveChanges();

            TempData["success"] = "Cập nhật thành công!";
            return RedirectToAction("ChuyenDe");
        }
        // ===============================
        // XÓA CHUYÊN ĐỀ
        // ===============================
        public IActionResult XoaChuyenDe(int id)
        {
            var cd = _context.ChuyenDe.Find(id);

            if (cd != null)
            {
                _context.ChuyenDe.Remove(cd);
                _context.SaveChanges();
            }

            return RedirectToAction("ChuyenDe");
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
        public IActionResult PhanCongGiangDays(int? gv, int? lop, int? mon)
        {
            var query = _context.PhanCongGiangDays
                .Include(p => p.GiaoVien)
                    .ThenInclude(g => g.NguoiDung)
                .Include(p => p.Lop)
                .Include(p => p.MonHoc)
                .AsQueryable();

            // 🔍 lọc
            if (gv.HasValue)
                query = query.Where(p => p.MaGiaoVien == gv.Value);

            if (lop.HasValue)
                query = query.Where(p => p.MaLop == lop.Value);

            if (mon.HasValue)
                query = query.Where(p => p.MaMon == mon.Value);

            // 🔥 dropdown
            ViewBag.GiaoVien = _context.GiaoVien
                .Include(g => g.NguoiDung)
                .ToList();

            ViewBag.Lop = _context.Lop.ToList();
            ViewBag.MonHoc = _context.MonHoc.ToList();

            // 🔥 giữ trạng thái filter
            ViewBag.SelectedGV = gv;
            ViewBag.SelectedLop = lop;
            ViewBag.SelectedMon = mon;

            return View(query.ToList());
        }
        [HttpPost]
        public IActionResult TaoPhanCongGiangDay(int magv, int malop, int mamon)
        {
            // 🔥 CHẶN TRÙNG CHUẨN
            bool daTonTai = _context.PhanCongGiangDays
            .Any(p => p.MaLop == malop && p.MaMon == mamon);

            if (daTonTai)
            {
                TempData["error"] = "Lớp này đã có giáo viên dạy môn này!";
                return RedirectToAction("PhanCongGiangDay");
            }

            var pc = new PhanCongGiangDay
            {
                MaGiaoVien = magv,
                MaLop = malop,
                MaMon = mamon
            };

            _context.PhanCongGiangDays.Add(pc);
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

            if (pc == null)
            {
                TempData["error"] = "Không tìm thấy phân công!";
                return RedirectToAction("PhanCongGiangDay");
            }

            _context.PhanCongGiangDays.Remove(pc);
            _context.SaveChanges();

            TempData["success"] = "Xóa phân công thành công";

            return RedirectToAction("PhanCongGiangDay");
        }
        // ===============================
        // DANH SÁCH TÀI KHOẢN
        // ===============================
        public IActionResult NguoiDung(string keyword)
        {
            var list = _context.NguoiDung
                .Include(x => x.HoSoCaNhan) // 🔥 QUAN TRỌNG
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(x =>
                    x.TenDangNhap.Contains(keyword) ||
                    x.MaNguoiDung.ToString().Contains(keyword) ||
                    x.HoSoCaNhan.HoTen.Contains(keyword)
                );
            }

            return View(list.ToList());
        }
        public IActionResult MoKhoaUser(int id)
        {
            var user = _context.NguoiDung.Find(id);

            if (user != null)
            {
                user.TrangThai = true;
                _context.SaveChanges();
            }

            return RedirectToAction("NguoiDung");
        }
        public IActionResult ResetMatKhau(int id)
        {
            var user = _context.NguoiDung.Find(id);

            if (user != null)
            {
                user.MatKhau = "1111"; 
                _context.SaveChanges();

                GhiLog("Reset mật khẩu", "Người dùng", id.ToString());
            }

            return RedirectToAction("NguoiDung");
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


        private void GhiLog(string hanhDong, string? doiTuong = null, string? maBanGhi = null)
        {
            // ✅ PHẢI ĐỂ Ở ĐÂY (ngoài object)
            int maNguoiDung = 0;
            var sessionValue = HttpContext.Session.GetString("MaNguoiDung");

            if (!string.IsNullOrEmpty(sessionValue) && int.TryParse(sessionValue, out int result))
            {
                maNguoiDung = result;
            }

            var log = new NhatKyHeThong
            {
                MaNguoiDung = maNguoiDung, 
                HanhDong = hanhDong,
                DoiTuongTacDong = doiTuong,
                MaBanGhiTacDong = maBanGhi,
                ThoiGianThucHien = DateTime.Now,
                DiaChiIP = HttpContext.Connection.RemoteIpAddress?.ToString()
            };

            _context.NhatKyHeThongs.Add(log);
            _context.SaveChanges();
        }


        // XUẤT EXCEL GIAO  VIÊN 
        public IActionResult XuatGiaoVienExcel()
        {
            ExcelPackage.License.SetNonCommercialPersonal("Admin");

            var list = _context.GiaoVien
                .Include(g => g.NguoiDung)
                .ThenInclude(n => n.HoSoCaNhan)
                .ToList();

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("GiaoVien");

                ws.Cells[1, 1].Value = "Tên giáo viên";
                ws.Cells[1, 2].Value = "Tên đăng nhập";
                ws.Cells[1, 3].Value = "Mật khẩu";

                int row = 2;

                foreach (var gv in list)
                {
                    ws.Cells[row, 1].Value = gv.NguoiDung?.HoSoCaNhan?.HoTen;
                    ws.Cells[row, 2].Value = gv.NguoiDung?.TenDangNhap;
                    ws.Cells[row, 3].Value = gv.NguoiDung?.MatKhau;
                    row++;
                }

                ws.Cells.AutoFitColumns();

                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                return File(stream,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "DanhSachGiaoVien.xlsx");
            }

        }
        // ===============================
        // XUẤT EXCEL HỌC SINH
        public IActionResult XuatHocSinhExcel()
        {
            ExcelPackage.License.SetNonCommercialPersonal("Admin");

            var list = _context.HocSinh
                .Include(h => h.NguoiDung)
                .ThenInclude(n => n.HoSoCaNhan)
                .Include(h => h.Lop)
                .ToList();

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("HocSinh");

                // Header
                ws.Cells[1, 1].Value = "Tên học sinh";
                ws.Cells[1, 2].Value = "Tên đăng nhập";
                ws.Cells[1, 3].Value = "Mật khẩu";
                ws.Cells[1, 4].Value = "Lớp";

                int row = 2;

                foreach (var hs in list)
                {
                    ws.Cells[row, 1].Value = hs.NguoiDung?.HoSoCaNhan?.HoTen;
                    ws.Cells[row, 2].Value = hs.NguoiDung?.TenDangNhap;
                    ws.Cells[row, 3].Value = hs.NguoiDung?.MatKhau;
                    ws.Cells[row, 4].Value = hs.Lop?.TenLop;
                    row++;
                }

                ws.Cells.AutoFitColumns();

                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                return File(stream,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "DanhSachHocSinh.xlsx");
            }
        }

    }
    }

    
