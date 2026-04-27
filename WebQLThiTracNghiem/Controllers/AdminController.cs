using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using WebQLThiTracNghiem.Data;
using WebQLThiTracNghiem.Models;
using WebQLThiTracNghiem.Models.ViewModels;
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
            // TỔNG QUAN
            ViewBag.SoNguoiDung = _context.NguoiDung.Count();
            ViewBag.SoVaiTro = _context.VaiTro.Count();
            ViewBag.SoNhatKy = _context.NhatKyHeThongs.Count();

            ViewBag.SoGiaoVien = _context.GiaoVien.Count();
            ViewBag.SoHocSinh = _context.HocSinh.Count();
            ViewBag.SoLop = _context.Lop.Count();
            ViewBag.SoMon = _context.MonHoc.Count();

            // TRẠNG THÁI HOẠT ĐỘNG
            ViewBag.SoHocSinhDangHoatDong = _context.HocSinh.Count(h => h.TrangThai);
            ViewBag.SoHocSinhNgungHoatDong = _context.HocSinh.Count(h => !h.TrangThai);

            ViewBag.SoGiaoVienDangHoatDong = _context.GiaoVien.Count(g => g.TrangThai);
            ViewBag.SoGiaoVienNgungHoatDong = _context.GiaoVien.Count(g => !g.TrangThai);

            // LIÊN KẾT LOGIC HỆ THỐNG
            ViewBag.SoChuyenDe = _context.ChuyenDe.Count();
            ViewBag.SoCauHoi = _context.CauHoi.Count();
            ViewBag.SoDotThi = (from dt in _context.DotThi
                                join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                                where de.LoaiDe == "Chung"
                                select dt.MaDotThi).Count();
            // CẢNH BÁO QUẢN TRỊ (RẤT QUAN TRỌNG)
            ViewBag.LopChuaPhanCong = _context.Lop.Count(l =>
                !_context.PhanCongGiangDays.Any(p => p.MaLop == l.MaLop));

            ViewBag.MonChuaCoChuyenDe = _context.MonHoc.Count(m =>
                !_context.ChuyenDe.Any(cd => cd.MaMonHoc == m.MaMonHoc));

            ViewBag.GiaoVienChuaDuocPhanCong = _context.GiaoVien.Count(g =>
                !_context.PhanCongGiangDays.Any(p => p.MaGiaoVien == g.MaGiaoVien));
            // THỜI GIAN
            var now = DateTime.Now;
            var last7Days = now.AddDays(-7);
            var prev7Days = now.AddDays(-14);

            // ========================
            // HỌC SINH
            // ========================
            var hs_now = _context.NguoiDung
                .Count(x => x.MaVaiTro == 3 && x.NgayTao >= last7Days);

            var hs_prev = _context.NguoiDung
                .Count(x => x.MaVaiTro == 3 && x.NgayTao >= prev7Days && x.NgayTao < last7Days);

            ViewBag.HocSinhTang = hs_now - hs_prev;

            // ========================
            // GIÁO VIÊN
            // ========================
            var gv_now = _context.NguoiDung
                .Count(x => x.MaVaiTro == 2 && x.NgayTao >= last7Days);

            var gv_prev = _context.NguoiDung
                .Count(x => x.MaVaiTro == 2 && x.NgayTao >= prev7Days && x.NgayTao < last7Days);

            ViewBag.GiaoVienTang = gv_now - gv_prev;

            // ========================
            // CHUYÊN ĐỀ
            // ========================
            var cd_now = _context.ChuyenDe.Count();
            ViewBag.ChuyenDeTang = cd_now;

            // ========================
            // ĐỢT THI
            // ========================
            var dt_now = _context.DotThi
                .Count(x => x.ThoiGianBatDau >= last7Days);

            var dt_prev = _context.DotThi
                .Count(x => x.ThoiGianBatDau >= prev7Days && x.ThoiGianBatDau < last7Days);

            ViewBag.DotThiTang = dt_now - dt_prev;
            // LOG GẦN NHẤT
            ViewBag.Logs = _context.NhatKyHeThongs
                .OrderByDescending(x => x.ThoiGianThucHien)
                .Take(5)
                .ToList();

            return View();
        }

        public IActionResult NhatKy(DateTime? fromDate, DateTime? toDate, string doiTuong)
        {
            var logs = _context.NhatKyHeThongs.AsQueryable();

            if (fromDate.HasValue)
            {
                logs = logs.Where(x => x.ThoiGianThucHien >= fromDate.Value);
            }

            if (toDate.HasValue)
            {
                logs = logs.Where(x => x.ThoiGianThucHien <= toDate.Value);
            }

            if (!string.IsNullOrEmpty(doiTuong))
            {
                logs = logs.Where(x => x.DoiTuongTacDong.Contains(doiTuong));
            }

            ViewBag.FromDate = fromDate?.ToString("yyyy-MM-dd");
            ViewBag.ToDate = toDate?.ToString("yyyy-MM-dd");

            return View(logs
                .OrderByDescending(x => x.ThoiGianThucHien)
                .ToList());
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
         .Include(g => g.PhanCongs) // 🔥 THÊM DÒNG NÀY
         .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x =>
     x.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword) ||
     x.NguoiDung.TenDangNhap.Contains(keyword));
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
        public IActionResult LuuGiaoVien(int? id, string username, string hoten, bool? laDaiDien, IFormFile avatar)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hoten))
            {
                TempData["error"] = "Thiếu dữ liệu";
                return RedirectToAction("DanhSachGiaoVien");
            }

            // =========================
            // THÊM MỚI
            // =========================
            if (id == null || id == 0)
            {
                if (_context.NguoiDung.Any(x => x.TenDangNhap == username))
                {
                    TempData["error"] = "Tên đăng nhập đã tồn tại!";
                    return RedirectToAction("DanhSachGiaoVien");
                }

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

                string fileName = null;

                if (avatar != null && avatar.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatar");

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    fileName = Guid.NewGuid().ToString() + Path.GetExtension(avatar.FileName);

                    var filePath = Path.Combine(path, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        avatar.CopyTo(stream);
                    }
                }

                var hs = new HoSoCaNhan
                {
                    MaNguoiDung = user.MaNguoiDung,
                    HoTen = hoten,
                    AnhDaiDien = fileName
                };

                _context.HoSoCaNhan.Add(hs);

                var gv = new GiaoVien
                {
                    MaNguoiDung = user.MaNguoiDung,
                    TrangThai = true,
                    LaDaiDien = laDaiDien ?? false // ✅ FIX
                };

                _context.GiaoVien.Add(gv);

                _context.SaveChanges();

                TempData["success"] = "Thêm giáo viên thành công. Mật khẩu: " + password;
            }

            // =========================
            // CẬP NHẬT
            // =========================
            else
            {
                var gv = _context.GiaoVien
                    .Include(g => g.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                    .FirstOrDefault(g => g.MaGiaoVien == id);

                if (gv != null)
                {
                    if (_context.NguoiDung.Any(x => x.TenDangNhap == username && x.MaNguoiDung != gv.MaNguoiDung))
                    {
                        TempData["error"] = "Tên đăng nhập đã tồn tại!";
                        return RedirectToAction("DanhSachGiaoVien");
                    }

                    gv.NguoiDung.TenDangNhap = username;

                    if (gv.NguoiDung.HoSoCaNhan != null)
                    {
                        gv.NguoiDung.HoSoCaNhan.HoTen = hoten;

                      
                       gv.LaDaiDien = laDaiDien ?? false;
                                                      
                        var phanCongs = _context.PhanCongGiangDays
                            .Where(x => x.MaGiaoVien == gv.MaGiaoVien)
                            .ToList();

                        foreach (var pc in phanCongs)
                        {
                            pc.LaDaiDien = laDaiDien ?? false;
                        }
                        if (avatar != null && avatar.Length > 0)
                        {
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatar");

                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);

                            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(avatar.FileName);

                            var filePath = Path.Combine(path, fileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                avatar.CopyTo(stream);
                            }

                            gv.NguoiDung.HoSoCaNhan.AnhDaiDien = fileName;
                        }
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
                .ThenInclude(n => n.HoSoCaNhan)
                .FirstOrDefault(x => x.MaGiaoVien == id);

            if (gv != null)
            {
                // xóa hồ sơ
                if (gv.NguoiDung.HoSoCaNhan != null)
                {
                    _context.HoSoCaNhan.Remove(gv.NguoiDung.HoSoCaNhan);
                }

                // xóa user
                _context.NguoiDung.Remove(gv.NguoiDung);

                // xóa giáo viên
                _context.GiaoVien.Remove(gv);

                _context.SaveChanges();

                GhiLog("Xóa giáo viên", "Giáo viên", id.ToString());
            }

            TempData["success"] = "Đã xóa giáo viên";
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

            // tìm kiếm
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x =>
      x.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword) ||
      x.NguoiDung.TenDangNhap.Contains(keyword));
            }

            // LỌC LỚP
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
        public IActionResult LuuHocSinh(int? id, string username, string hoten, int malop, IFormFile avatar)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hoten))
            {
                TempData["error"] = "Thiếu dữ liệu";
                return RedirectToAction("DanhSachHocSinh");
            }

            // =========================
            //THÊM MỚI
            // =========================
            if (id == null || id == 0)
            {
                // CHECK TRÙNG USERNAME
                if (_context.NguoiDung.Any(x => x.TenDangNhap == username))
                {
                    TempData["error"] = "Tên đăng nhập đã tồn tại!";
                    return RedirectToAction("DanhSachHocSinh");
                }

                // CHECK TRÙNG HỌC SINH TRONG LỚP
                bool isExist = _context.HocSinh
                    .Include(x => x.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                    .Any(x => x.NguoiDung.HoSoCaNhan.HoTen == hoten && x.MaLop == malop);

                if (isExist)
                {
                    TempData["error"] = "Học sinh đã tồn tại trong lớp!";
                    return RedirectToAction("DanhSachHocSinh");
                }

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

                // =========================
                // UP ẢNH
                // =========================
                string fileName = null;

                if (avatar != null && avatar.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatar");

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    fileName = Guid.NewGuid().ToString() + Path.GetExtension(avatar.FileName);

                    var filePath = Path.Combine(path, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        avatar.CopyTo(stream);
                    }
                }

                var hsCN = new HoSoCaNhan
                {
                    MaNguoiDung = user.MaNguoiDung,
                    HoTen = hoten,
                    AnhDaiDien = fileName
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

                GhiLog("Thêm học sinh", "Học sinh", user.MaNguoiDung.ToString());

                TempData["success"] = "Thêm học sinh thành công. Mật khẩu: " + password;
            }
            // =========================
            // CẬP NHẬT
            // =========================
            else
            {
                var hs = _context.HocSinh
                    .Include(h => h.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                    .FirstOrDefault(h => h.MaHocSinh == id);

                if (hs != null)
                {
                    // CHECK TRÙNG USERNAME
                    if (_context.NguoiDung.Any(x => x.TenDangNhap == username && x.MaNguoiDung != hs.MaNguoiDung))
                    {
                        TempData["error"] = "Tên đăng nhập đã tồn tại!";
                        return RedirectToAction("DanhSachHocSinh");
                    }

                    hs.NguoiDung.TenDangNhap = username;

                    if (hs.NguoiDung.HoSoCaNhan != null)
                    {
                        hs.NguoiDung.HoSoCaNhan.HoTen = hoten;

                        // UPDATE ẢNH
                        if (avatar != null && avatar.Length > 0)
                        {
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatar");

                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);

                            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(avatar.FileName);

                            var filePath = Path.Combine(path, fileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                avatar.CopyTo(stream);
                            }

                            hs.NguoiDung.HoSoCaNhan.AnhDaiDien = fileName;
                        }
                    }

                    hs.MaLop = malop;

                    _context.SaveChanges();

                    GhiLog("Cập nhật học sinh", "Học sinh", id.ToString());

                    TempData["success"] = "Cập nhật học sinh thành công";
                }
            }

            return RedirectToAction("DanhSachHocSinh");
        }
        public IActionResult XoaHocSinh(int id)
        {
            var hs = _context.HocSinh
                .Include(x => x.NguoiDung)
                .ThenInclude(n => n.HoSoCaNhan)
                .FirstOrDefault(x => x.MaHocSinh == id);

            if (hs != null)
            {
                // xóa hồ sơ
                if (hs.NguoiDung.HoSoCaNhan != null)
                {
                    _context.HoSoCaNhan.Remove(hs.NguoiDung.HoSoCaNhan);
                }

                // xóa user
                _context.NguoiDung.Remove(hs.NguoiDung);

                // xóa học sinh
                _context.HocSinh.Remove(hs);

                _context.SaveChanges();

                GhiLog("Xóa học sinh", "Học sinh", id.ToString());
            }

            TempData["success"] = "Đã xóa học sinh";
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
            int pageSize = 20; 

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
          
            if (_context.PhanCongGiangDays.Any(x => x.MaMon == id))
            {
                TempData["error"] = "Môn đang được phân công, không thể xóa!";
                return RedirectToAction("MonHoc");
            }
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
        public IActionResult ChuyenDe(string keyword, int? mon, int? khoi, int page = 1)
        {
            int pageSize = 5;

            var query = _context.ChuyenDe
                .Include(x => x.MonHoc)
                .Include(x => x.CauHois)
                .AsQueryable();

            // TÌM KIẾM
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.TenChuyenDe.Contains(keyword));
            }

            // LỌC MÔN
            if (mon.HasValue)
            {
                query = query.Where(x => x.MaMonHoc == mon.Value);
            }

            // LỌC KHỐI
            if (khoi.HasValue)
            {
                query = query.Where(cd =>
                    _context.CauHoi.Any(c =>
                        c.MaChuyenDe == cd.MaChuyenDe &&
                        _context.HocSinh.Any(h =>
                            h.Lop.KyHieuLop.StartsWith(khoi.ToString())
                        )
                    )
                );
            }

            // TỔNG SAU FILTER (QUAN TRỌNG)
            int totalItems = query.Count();

            var data = query
                .OrderBy(x => x.MaChuyenDe)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // PHÂN TRANG
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = (int)Math.Ceiling((double)totalItems / pageSize);
            ViewBag.TongChuyenDe = totalItems;
            ViewBag.SoMon = _context.MonHoc.Count();
            ViewBag.MonHoc = _context.MonHoc.ToList();
            ViewBag.SelectedMon = mon;
            ViewBag.SelectedKhoi = khoi;
            ViewBag.Keyword = keyword;

            return View(data);
        }

        // ===============================
        // THÊM CHUYÊN ĐỀ
        // ===============================
        [HttpPost]
        public IActionResult ThemChuyenDe(string tenChuyenDe, int maMonHoc, int khoi)
        {
            // validate tên
            if (string.IsNullOrWhiteSpace(tenChuyenDe))
            {
                TempData["error"] = "Không được để trống tên chuyên đề!";
                return RedirectToAction("ChuyenDe");
            }

            // validate khối
            if (khoi != 10 && khoi != 11 && khoi != 12)
            {
                TempData["error"] = "Vui lòng chọn khối hợp lệ!";
                return RedirectToAction("ChuyenDe");
            }
            bool isExist = _context.ChuyenDe.Any(x =>
                x.TenChuyenDe == tenChuyenDe &&
                x.MaMonHoc == maMonHoc &&
                x.Khoi == khoi
            );

            if (isExist)
            {
                TempData["error"] = "Chuyên đề đã tồn tại!";
                return RedirectToAction("ChuyenDe");
            }

            // thêm mới
            var cd = new ChuyenDe
            {
                TenChuyenDe = tenChuyenDe,
                MaMonHoc = maMonHoc,
                Khoi = khoi
            };

            _context.ChuyenDe.Add(cd);
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

            // check trùng
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

        public IActionResult PhanCongGiangDay(int? gv, int? lop, int? mon, int page = 1)
        {
            int pageSize = 10;

            var query = _context.PhanCongGiangDays
                .Include(p => p.GiaoVien)
                    .ThenInclude(g => g.NguoiDung)
                        .ThenInclude(n => n.HoSoCaNhan)
                .Include(p => p.Lop)
                .Include(p => p.MonHoc)
                .AsQueryable();

            // lọc
            if (gv.HasValue)
                query = query.Where(p => p.MaGiaoVien == gv);

            if (lop.HasValue)
                query = query.Where(p => p.MaLop == lop);

            if (mon.HasValue)
                query = query.Where(p => p.MaMon == mon);

            int totalItems = query.Count();

            var data = query
                .OrderBy(p => p.MaPhanCong)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = (int)Math.Ceiling((double)totalItems / pageSize);

            // dropdown
            ViewBag.GiaoVien = _context.GiaoVien
                .Include(g => g.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                .ToList();

            ViewBag.Lop = _context.Lop.ToList();
            ViewBag.MonHoc = _context.MonHoc.ToList();

            // giữ filter
            ViewBag.SelectedGV = gv;
            ViewBag.SelectedLop = lop;
            ViewBag.SelectedMon = mon;

            return View(data);
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

            // lọc
            if (gv.HasValue)
                query = query.Where(p => p.MaGiaoVien == gv.Value);

            if (lop.HasValue)
                query = query.Where(p => p.MaLop == lop.Value);

            if (mon.HasValue)
                query = query.Where(p => p.MaMon == mon.Value);

            // dropdown
            ViewBag.GiaoVien = _context.GiaoVien
                .Include(g => g.NguoiDung)
                .ToList();

            ViewBag.Lop = _context.Lop.ToList();
            ViewBag.MonHoc = _context.MonHoc.ToList();

            // giữ trạng thái filter
            ViewBag.SelectedGV = gv;
            ViewBag.SelectedLop = lop;
            ViewBag.SelectedMon = mon;

            return View(query.ToList());
        }
        [HttpPost]
        public IActionResult TaoPhanCongGiangDay(int magv, int malop, int mamon)
        {
            // CHẶN TRÙNG 
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
        public IActionResult NguoiDung(string keyword, int page = 1)
        {
            int pageSize = 10;

            var list = _context.NguoiDung
                .Include(x => x.HoSoCaNhan)
                .OrderByDescending(x => x.MaNguoiDung)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(x =>
                    x.TenDangNhap.Contains(keyword) ||
                    x.MaNguoiDung.ToString().Contains(keyword) ||
                    x.HoSoCaNhan.HoTen.Contains(keyword)
                );
            }

            int totalItems = list.Count();

            var data = list
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            ViewBag.Keyword = keyword;

            return View(data);
        }
        // ===== HỒ SƠ NGƯỜI DÙNG =====

        public IActionResult ChiTietNguoiDung(int id)
        {
            var user = _context.NguoiDung
                .Include(x => x.HoSoCaNhan)
                .FirstOrDefault(x => x.MaNguoiDung == id);

            if (user == null)
                return NotFound();

            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChiTietNguoiDung(NguoiDung model, IFormFile avatar, string returnUrl)
        {

            if (model == null || model.MaNguoiDung == 0)
                return BadRequest("Thiếu MaNguoiDung");

            var user = _context.NguoiDung
                .FirstOrDefault(x => x.MaNguoiDung == model.MaNguoiDung);

            if (user == null)
                return NotFound();

            var hoSo = _context.HoSoCaNhan
                .FirstOrDefault(x => x.MaNguoiDung == model.MaNguoiDung);

            // =========================
            // CHECK TRÙNG USERNAME
            // =========================
            if (!string.IsNullOrEmpty(model.TenDangNhap) &&
                _context.NguoiDung.Any(x =>
                    x.TenDangNhap == model.TenDangNhap &&
                    x.MaNguoiDung != user.MaNguoiDung))
            {
                TempData["error"] = "Tên đăng nhập đã tồn tại!";
                return Redirect(returnUrl ?? "/Admin/NguoiDung");
            }

            // =========================
            // UPDATE USER
            // =========================
            user.TenDangNhap = model.TenDangNhap;

            // =========================
            // UPDATE HỒ SƠ
            // =========================
            if (hoSo != null && model.HoSoCaNhan != null)
            {
                hoSo.HoTen = model.HoSoCaNhan.HoTen;
                hoSo.SoDienThoai = model.HoSoCaNhan.SoDienThoai;
                hoSo.NgaySinh = model.HoSoCaNhan.NgaySinh;
                hoSo.GioiTinh = model.HoSoCaNhan.GioiTinh;
                hoSo.DiaChi = model.HoSoCaNhan.DiaChi;

                // =========================
                //UP ẢNH
                // =========================
                if (avatar != null && avatar.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatar");

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    // XÓA ẢNH CŨ
                    if (!string.IsNullOrEmpty(hoSo.AnhDaiDien))
                    {
                        var oldPath = Path.Combine(path, hoSo.AnhDaiDien);
                        if (System.IO.File.Exists(oldPath))
                            System.IO.File.Delete(oldPath);
                    }

                    // LƯU ẢNH MỚI
                    var fileName = Guid.NewGuid() + Path.GetExtension(avatar.FileName);
                    var filePath = Path.Combine(path, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        avatar.CopyTo(stream);
                    }

                    hoSo.AnhDaiDien = fileName;
                }
            }

            _context.SaveChanges();

            // LOG
            GhiLog("Cập nhật hồ sơ", "Người dùng", model.MaNguoiDung.ToString());

            TempData["success"] = "Cập nhật thành công!";

            //quay lại
            if (!string.IsNullOrEmpty(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction("NguoiDung");
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
            try
            {
                int? maNguoiDung = null;

                var sessionValue = HttpContext?.Session?.GetString("MaNguoiDung");

                if (!string.IsNullOrEmpty(sessionValue) && int.TryParse(sessionValue, out int result))
                {
                    // check tồn tại trong DB
                    bool tonTai = _context.NguoiDung.Any(x => x.MaNguoiDung == result);

                    if (tonTai)
                    {
                        maNguoiDung = result;
                    }
                }

                var log = new NhatKyHeThong
                {
                    MaNguoiDung = maNguoiDung ?? 1,
                    HanhDong = hanhDong,
                    DoiTuongTacDong = doiTuong,
                    MaBanGhiTacDong = maBanGhi,
                    ThoiGianThucHien = DateTime.Now,
                    DiaChiIP = HttpContext?.Connection?.RemoteIpAddress?.ToString()
                };

                _context.NhatKyHeThongs.Add(log);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ghi log: " + ex.Message);
            }
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

        [HttpGet]
        public IActionResult TaoDotThi()
        {
            var model = new TaoDotThiViewModel
            {
                DanhSachDeThi = _context.DeThi
                    .Where(d => d.LoaiDe == "Chung")
                    .Select(d => new SelectListItem
                    {
                        Value = d.MaDeThi.ToString(),
                        Text = d.TenDeThi
                    })
                    .ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult TaoDotThi(TaoDotThiViewModel model)
        {
            // VALIDATE
            if (string.IsNullOrWhiteSpace(model.TenDotThi))
                ModelState.AddModelError("", "Tên đợt thi không được để trống");

            if (model.MaDeThi == 0)
                ModelState.AddModelError("", "Bạn chưa chọn đề thi");

            if (model.ThoiGianBatDau >= model.ThoiGianKetThuc)
                ModelState.AddModelError("", "Thời gian không hợp lệ");

            if (model.ThoiGianKetThuc <= DateTime.Now)
                ModelState.AddModelError("", "Phải chọn thời gian trong tương lai");

            if (!ModelState.IsValid)
            {
                model.DanhSachDeThi = _context.DeThi
                    .Where(d => d.LoaiDe == "Chung")
                    .Select(d => new SelectListItem
                    {
                        Value = d.MaDeThi.ToString(),
                        Text = d.TenDeThi
                    })
                    .ToList();

                return View(model);
            }

            // TẠO ĐỢT THI (THÊM KHỐI)
            var dotThi = new DotThi
            {
                TenDotThi = model.TenDotThi,
                MaDeThi = model.MaDeThi,
                ThoiGianBatDau = model.ThoiGianBatDau,
                ThoiGianKetThuc = model.ThoiGianKetThuc,
                SoLanThiToiDa = model.SoLanThiToiDa,
                TrangThai = true,
                Khoi = model.Khoi ?? 0 
            };

            _context.DotThi.Add(dotThi);
            _context.SaveChanges();

            GhiLog("Tạo đợt thi", "Đợt thi", dotThi.MaDotThi.ToString());

            // LỌC HỌC SINH THEO KHỐI
            var hocSinhsQuery = _context.HocSinh
                .Include(h => h.Lop)
                .AsQueryable();

            if (model.Khoi.HasValue)
            {
                string khoiStr = model.Khoi.Value.ToString();

                hocSinhsQuery = hocSinhsQuery
                    .Where(h => h.Lop != null &&
                                h.Lop.KyHieuLop != null &&
                                h.Lop.KyHieuLop.StartsWith(khoiStr));
            }

            var hocSinhs = hocSinhsQuery
                .Select(x => x.MaHocSinh)
                .ToList();

            // KHÔNG CÓ HỌC SINH → BÁO LỖI
            if (!hocSinhs.Any())
            {
                TempData["error"] = "Không có học sinh thuộc khối này!";
                return RedirectToAction("TaoDotThi");
            }

            // GÁN DANH SÁCH DỰ THI
            var danhSach = hocSinhs.Select(hs => new DanhSachDuThi
            {
                MaDotThi = dotThi.MaDotThi,
                MaHocSinh = hs
            }).ToList();

            _context.DanhSachDuThi.AddRange(danhSach);
            _context.SaveChanges();

            TempData["success"] = $"Tạo đợt thi thành công! ({hocSinhs.Count} học sinh)";
            return RedirectToAction("DanhSachDotThi");
        }
        public IActionResult DotThi(string? keyword, string? trangThai, int? khoi)
        {
            var query = from dt in _context.DotThi
                        join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                        join mh in _context.MonHoc on de.MaMonHoc equals mh.MaMonHoc
                        where de.LoaiDe == "Chung" 
                        select new
                        {
                            dt.MaDotThi,
                            dt.TenDotThi,
                            mh.TenMonHoc,
                            de.Khoi,
                            dt.ThoiGianBatDau,
                            dt.ThoiGianKetThuc,

                            TrangThaiText =
                                dt.ThoiGianBatDau > DateTime.Now ? "Sắp diễn ra" :
                                dt.ThoiGianKetThuc < DateTime.Now ? "Đã kết thúc" :
                                "Đang mở"
                        };

            // SEARCH
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.TenDotThi.Contains(keyword));
            }

            //  LỌC KHỐI
            if (khoi != null)
            {
                query = query.Where(x => x.Khoi == khoi);
            }

            //  LỌC TRẠNG THÁI
            if (!string.IsNullOrEmpty(trangThai))
            {
                if (trangThai == "sapdienra")
                    query = query.Where(x => x.ThoiGianBatDau > DateTime.Now);

                else if (trangThai == "dangmo")
                    query = query.Where(x => x.ThoiGianBatDau <= DateTime.Now && x.ThoiGianKetThuc >= DateTime.Now);

                else if (trangThai == "ketthuc")
                    query = query.Where(x => x.ThoiGianKetThuc < DateTime.Now);
            }

            return View(query
                .OrderByDescending(x => x.ThoiGianBatDau)
                .ToList());
        }
        public IActionResult SuaDotThi(int id)
        {
            var dotThi = _context.DotThi.Find(id);
            if (dotThi == null) return NotFound();

            return View(dotThi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaDotThi(DotThi model)
        {
            var dotThi = _context.DotThi.Find(model.MaDotThi);
            if (dotThi == null) return NotFound();

            dotThi.TenDotThi = model.TenDotThi;
            dotThi.ThoiGianBatDau = model.ThoiGianBatDau;
            dotThi.ThoiGianKetThuc = model.ThoiGianKetThuc;
            dotThi.SoLanThiToiDa = model.SoLanThiToiDa;

            _context.SaveChanges();

            TempData["success"] = "Cập nhật thành công!";
            return RedirectToAction("ChiTietDotThi", new { id = model.MaDotThi });
        }
        public IActionResult ChiTietDotThi(int id, int? lop, string? trangThai)
        {
            var dotThi = _context.DotThi
                .Include(x => x.DeThi)
                    .ThenInclude(d => d.MonHoc)
                .FirstOrDefault(x => x.MaDotThi == id);

            if (dotThi == null || dotThi.DeThi == null || dotThi.DeThi.LoaiDe != "Chung")
                return NotFound();
            ViewBag.DotThi = new
            {
                dotThi.MaDotThi,
                dotThi.TenDotThi,
                TenMonHoc = dotThi.DeThi?.MonHoc?.TenMonHoc,
                TenDeThi = dotThi.DeThi?.TenDeThi,
                dotThi.ThoiGianBatDau,
                dotThi.ThoiGianKetThuc
            };

            GhiLog("Xem chi tiết đợt thi", "Đợt thi", id.ToString());

            var query = from ds in _context.DanhSachDuThi
                        join hs in _context.HocSinh on ds.MaHocSinh equals hs.MaHocSinh
                        join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                        join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung

                        join lopHoc in _context.Lop on hs.MaLop equals lopHoc.MaLop into lopJoin
                        from lopHoc in lopJoin.DefaultIfEmpty()

                        join lt in _context.LuotThi
                            on new { ds.MaHocSinh, ds.MaDotThi }
                            equals new { lt.MaHocSinh, lt.MaDotThi }
                            into ltJoin
                        from lt in ltJoin.DefaultIfEmpty()

                        where ds.MaDotThi == id

                        select new
                        {
                            MaHocSinh = hs.MaHocSinh,
                            Ten = hoso.HoTen,
                            Lop = lopHoc != null ? lopHoc.TenLop : "Chưa có lớp",

                            ThoiGianVao = lt != null ? (DateTime?)lt.ThoiDiemBatDau : null,
                            ThoiGianNop = lt != null ? (DateTime?)lt.ThoiDiemNopBai : null,
                            Diem = lt != null ? (double?)lt.Diem : null,

                            TrangThai =
                                lt == null ? "Chưa thi" :
                                lt.ThoiDiemNopBai == null ? "Chưa nộp" :
                                "Đã nộp"
                        };

            // LỌC LỚP 
            if (lop.HasValue)
            {
                var tenLop = _context.Lop
                    .Where(l => l.MaLop == lop.Value)
                    .Select(l => l.TenLop)
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(tenLop))
                {
                    query = query.Where(x => x.Lop == tenLop);
                }
            }

            // LỌC TRẠNG THÁI
            if (!string.IsNullOrEmpty(trangThai))
            {
                if (trangThai == "dathi")
                    query = query.Where(x => x.TrangThai == "Đã nộp");

                else if (trangThai == "chuathi")
                    query = query.Where(x => x.TrangThai != "Đã nộp");
            }

            var list = query
                .OrderByDescending(x => x.ThoiGianNop)
                .ToList();

            ViewBag.Lop = _context.Lop.ToList();
            ViewBag.SelectedLop = lop;
            ViewBag.TrangThai = trangThai;
            ViewBag.MaDotThi = id;

            return View(list);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult XoaDotThi(int id)
        {
            var dotThi = _context.DotThi.FirstOrDefault(x => x.MaDotThi == id);

            if (dotThi == null)
                return NotFound();

            // XÓA LUOTTHI TRƯỚC
            var luotThi = _context.LuotThi.Where(x => x.MaDotThi == id).ToList();
            _context.LuotThi.RemoveRange(luotThi);

            //XÓA DANHSACHDUTHI
            var ds = _context.DanhSachDuThi.Where(x => x.MaDotThi == id).ToList();
            _context.DanhSachDuThi.RemoveRange(ds);
            //XÓA ĐỢT THI
            _context.DotThi.Remove(dotThi);

            _context.SaveChanges();

            TempData["success"] = "Đã xóa đợt thi!";
            return RedirectToAction("DanhSachDotThi");
        }
        [HttpPost]
        public IActionResult ToggleDotThi(int id)
        {
            var dotThi = _context.DotThi.Find(id);

            if (dotThi != null)
            {
                dotThi.TrangThai = !dotThi.TrangThai;
                _context.SaveChanges();
            }

            return RedirectToAction("DotThi");
        }
        public IActionResult XuatExcelDotThi()
        {
            var data = _context.DotThi
       .Include(d => d.DeThi)
       .Where(d => d.DeThi.LoaiDe == "Chung")
       .Select(d => new
       {
           d.TenDotThi,
           TenDe = d.DeThi.TenDeThi,
           d.ThoiGianBatDau,
           d.ThoiGianKetThuc,
           d.Khoi
       })
       .ToList(); 

            using (var package = new OfficeOpenXml.ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("DotThi");

                // HEADER
                ws.Cells[1, 1].Value = "Tên đợt thi";
                ws.Cells[1, 2].Value = "Đề";
                ws.Cells[1, 3].Value = "Bắt đầu";
                ws.Cells[1, 4].Value = "Kết thúc";
                ws.Cells[1, 5].Value = "Khối";

                // FORMAT NGÀY
                ws.Column(3).Style.Numberformat.Format = "dd/MM/yyyy HH:mm";
                ws.Column(4).Style.Numberformat.Format = "dd/MM/yyyy HH:mm";

                int row = 2;

                foreach (var item in data)
                {
                    ws.Cells[row, 1].Value = item.TenDotThi;
                    ws.Cells[row, 2].Value = item.TenDe;              
                    ws.Cells[row, 3].Value = item.ThoiGianBatDau;
                    ws.Cells[row, 4].Value = item.ThoiGianKetThuc;
                    ws.Cells[row, 5].Value = item.Khoi;
                    row++;
                }

                ws.Cells.AutoFitColumns();

                var file = package.GetAsByteArray();

                return File(file,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "DanhSachDotThi.xlsx");
            }
        }
        public IActionResult ToggleTrangThaiDotThi(int id)
        {
            var dotThi = _context.DotThi.Find(id);

            if (dotThi != null)
            {
                dotThi.TrangThai = !dotThi.TrangThai;
                _context.SaveChanges();
                GhiLog("Đổi trạng thái đợt thi", "Đợt thi", id.ToString());
            }

            TempData["success"] = "Cập nhật trạng thái thành công!";
            return RedirectToAction("DanhSachDotThi");
        }
        public IActionResult KhoaUser(int id)
        {
            var user = _context.NguoiDung.Find(id);

            if (user != null)
            {
                user.TrangThai = false; 
                _context.SaveChanges();

                GhiLog("Khóa tài khoản", "Người dùng", id.ToString());
            }

            return RedirectToAction("NguoiDung");
        }
        public IActionResult DanhSachDotThi(string keyword, string fromDate, string toDate, int? khoi, int page = 1)
        {
            int pageSize = 10;

            // LOAD DỮ LIỆU 
            var query = _context.DotThi
      .Include(d => d.DeThi)
      .Where(d => d.DeThi != null && d.DeThi.LoaiDe == "Chung")
      .ToList();

            // LỌC TÊN
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.TenDotThi.Contains(keyword)).ToList();
            }

            // LỌC NGÀY
            if (!string.IsNullOrEmpty(fromDate))
            {
                DateTime from = DateTime.Parse(fromDate);
                query = query.Where(x => x.ThoiGianBatDau >= from).ToList();
            }

            if (!string.IsNullOrEmpty(toDate))
            {
                DateTime to = DateTime.Parse(toDate);
                query = query.Where(x => x.ThoiGianKetThuc <= to).ToList();
            }
            var dsDuThi = _context.DanhSachDuThi.ToList();
            var hocSinh = _context.HocSinh.Include(h => h.Lop).ToList();
            // LỌC KHỐI
            if (khoi.HasValue)
            {
                query = query.Where(x =>
                    dsDuThi.Any(ds =>
                        ds.MaDotThi == x.MaDotThi &&
                        hocSinh.Any(h =>
                            h.MaHocSinh == ds.MaHocSinh &&
                            h.Lop.KyHieuLop.Substring(0, 2) == khoi.ToString()
                        )
                    )
                ).ToList();
            }

            int totalItems = query.Count;

            var danhSach = query
                .OrderByDescending(d => d.ThoiGianBatDau)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(d => new
                {
                    d.MaDotThi,
                    d.TenDotThi,
                    TenDe = d.DeThi?.TenDeThi ?? "",
                    d.ThoiGianBatDau,
                    d.ThoiGianKetThuc,
                    d.Khoi,

                    TrangThai = d.TrangThai && d.ThoiGianKetThuc > DateTime.Now,

                    SoThiSinhDaThi = _context.LuotThi
                        .Count(l => l.MaDotThi == d.MaDotThi),

                    TongHocSinh = _context.DanhSachDuThi
                        .Count(x => x.MaDotThi == d.MaDotThi)
                })
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            return View(danhSach);
        }
        public IActionResult ChiTietBaiLam(int maHocSinh, int maDotThi)
        {
            var luotThi = _context.LuotThi
                .FirstOrDefault(x => x.MaHocSinh == maHocSinh && x.MaDotThi == maDotThi);

            if (luotThi == null)
                return Content("Không tìm thấy bài làm");

            var model = new KetQuaThiViewModel();

            // HỌC SINH
            var hocSinh = _context.HocSinh
                .Include(h => h.NguoiDung)
                    .ThenInclude(n => n.HoSoCaNhan)
                .FirstOrDefault(h => h.MaHocSinh == maHocSinh);

            ViewBag.HoTen = hocSinh?.NguoiDung?.HoSoCaNhan?.HoTen;
            ViewBag.MaHocSinh = hocSinh?.MaHocSinh;

            // THÊM DÒNG NÀY 
            ViewBag.Avatar = hocSinh?.NguoiDung?.HoSoCaNhan?.AnhDaiDien;

            model.MaLuotThi = luotThi.MaLuotThi;

            // ĐỢT THI
            var dotThi = _context.DotThi
                .Include(d => d.DeThi)
                    .ThenInclude(dt => dt.MonHoc)
                .FirstOrDefault(d => d.MaDotThi == maDotThi);

            model.TenDotThi = dotThi?.TenDotThi ?? "";
            model.TenDeThi = dotThi?.DeThi?.TenDeThi ?? "";
            model.MonThi = dotThi?.DeThi?.MonHoc?.TenMonHoc ?? "";

            model.ThoiDiemBatDau = luotThi.ThoiDiemBatDau;
            model.ThoiDiemNopBai = luotThi.ThoiDiemNopBai;

            // CHI TIẾT CÂU HỎI
            model.ChiTietCauHoi = (from ct in _context.ChiTietBaiLam
                                   join ch in _context.CauHoi on ct.MaCauHoi equals ch.MaCauHoi
                                   where ct.MaLuotThi == luotThi.MaLuotThi
                                   select new ChiTietKetQuaThiViewModel
                                   {
                                       MaCauHoi = ch.MaCauHoi,
                                       NoiDungCauHoi = ch.NoiDung,

                                       MaDapAnChon = ct.MaDapAnChon,

                                       NoiDungDapAnChon = _context.DapAn
                                           .Where(x => x.MaDapAn == ct.MaDapAnChon)
                                           .Select(x => x.NoiDung)
                                           .FirstOrDefault() ?? "",

                                       MaDapAnDung = _context.DapAn
                                           .Where(x => x.MaCauHoi == ct.MaCauHoi && x.LaDapAnDung)
                                           .Select(x => x.MaDapAn)
                                           .FirstOrDefault(),

                                       NoiDungDapAnDung = _context.DapAn
                                           .Where(x => x.MaCauHoi == ct.MaCauHoi && x.LaDapAnDung)
                                           .Select(x => x.NoiDung)
                                           .FirstOrDefault() ?? "",

                                       DungSai = ct.DungSai,
                                       DiemCau = ct.DiemCau,

                                       DanhSachDapAn = _context.DapAn
                                           .Where(x => x.MaCauHoi == ct.MaCauHoi)
                                           .Select(x => new DapAnThiViewModel
                                           {
                                               NoiDung = x.NoiDung
                                           }).ToList()
                                   }).ToList();

            model.TongSoCau = model.ChiTietCauHoi.Count;
            model.SoCauDung = model.ChiTietCauHoi.Count(x => x.DungSai);
            model.SoCauSai = model.TongSoCau - model.SoCauDung;
            model.TongDiem = luotThi.Diem ?? 0;

            return View(model);
        }
        public IActionResult ThongKeTong(int? maDotThi, int? khoi)
        {
            ViewBag.DotThiList = _context.DotThi
                .Include(d => d.DeThi)
                    .ThenInclude(dt => dt.MonHoc)
                .ToList();

            ViewBag.SelectedDotThi = maDotThi;
            ViewBag.SelectedKhoi = khoi;

            // LẤY LỚP
            var lops = _context.Lop
                .Where(l => !khoi.HasValue || l.KyHieuLop.StartsWith(khoi.ToString()))
                .ToList();

            var result = new List<ThongKeLopVM>();

            foreach (var lop in lops)
            {
                // =========================
                // HỌC SINH
                // =========================
                var hocSinhIds = _context.HocSinh
                    .Where(h => h.MaLop == lop.MaLop)
                    .Select(h => h.MaHocSinh)
                    .ToList();

                // =========================
                // LƯỢT THI
                // =========================
                var luotThis = _context.LuotThi
                    .Where(lt => hocSinhIds.Contains(lt.MaHocSinh) &&
                                (!maDotThi.HasValue || lt.MaDotThi == maDotThi))
                    .ToList();

                // =========================
                // SỐ ĐỢT THI 
                // =========================
                var soDotThi = _context.DanhSachDuThi
                    .Where(ds => hocSinhIds.Contains(ds.MaHocSinh))
                    .Select(ds => ds.MaDotThi)
                    .Distinct()
                    .Count();

                // =========================
                //THỐNG KÊ THEO MÔN
                // =========================
                var thongKeMon = (from lt in _context.LuotThi
                                  join dt in _context.DotThi on lt.MaDotThi equals dt.MaDotThi
                                  join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                                  join mh in _context.MonHoc on de.MaMonHoc equals mh.MaMonHoc
                                  where hocSinhIds.Contains(lt.MaHocSinh)
                                  group lt by mh.TenMonHoc into g
                                  select new ThongKeMonVM
                                  {
                                      Mon = g.Key,
                                      SoLuot = g.Count(),
                                      DiemTB = g.Average(x => x.Diem) ?? 0
                                  }).ToList();

                // =========================
                // CHẤT LƯỢNG
                // =========================
                int tongLuot = luotThis.Count;

                int gioi = luotThis.Count(x => x.Diem >= 8);
                int kha = luotThis.Count(x => x.Diem >= 6.5 && x.Diem < 8);
                int tb = luotThis.Count(x => x.Diem >= 5 && x.Diem < 6.5);
                int yeu = luotThis.Count(x => x.Diem < 5);

                int dat = luotThis.Count(x => x.Diem >= 5);

                double diemTB = tongLuot > 0
                    ? (luotThis.Average(x => x.Diem) ?? 0)
                    : 0;

                double tyLeDat = tongLuot > 0
                    ? (dat * 100.0 / tongLuot)
                    : 0;

                result.Add(new ThongKeLopVM
                {
                    TenLop = lop.TenLop,
                    SoHocSinh = hocSinhIds.Count,

                    // QUAN TRỌNG
                    SoDotThi = soDotThi,

                    // CHẤT LƯỢNG
                    DiemTB = Math.Round(diemTB, 2),
                    TyLeDat = Math.Round(tyLeDat, 2),

                    SoGioi = gioi,
                    SoKha = kha,
                    SoTB = tb,
                    SoYeu = yeu,

                    //THEO MÔN
                    ThongKeMon = thongKeMon
                });
            }

            // =========================
            // XẾP HẠNG
            // =========================
            var sorted = result.OrderByDescending(x => x.DiemTB).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                sorted[i].Rank = i + 1;
            }

            ViewBag.TopLop = sorted.FirstOrDefault();
            ViewBag.LopYeu = sorted.LastOrDefault();

            return View(sorted);
        }

        public IActionResult XuatExcelChiTietDotThi(int id)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Admin");

            var data = (from ds in _context.DanhSachDuThi
                        join hs in _context.HocSinh on ds.MaHocSinh equals hs.MaHocSinh
                        join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                        join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung

                        join lop in _context.Lop on hs.MaLop equals lop.MaLop into lopJoin
                        from lop in lopJoin.DefaultIfEmpty()

                        join lt in _context.LuotThi
                            on new { ds.MaHocSinh, ds.MaDotThi }
                            equals new { lt.MaHocSinh, lt.MaDotThi }
                            into ltJoin
                        from lt in ltJoin.DefaultIfEmpty()

                        where ds.MaDotThi == id

                        select new
                        {
                            Ten = hoso.HoTen,
                            Lop = lop != null ? lop.TenLop : "",

                            ThoiGianVao = lt != null ? (DateTime?)lt.ThoiDiemBatDau : null,
                            ThoiGianNop = lt != null ? (DateTime?)lt.ThoiDiemNopBai : null,
                            Diem = lt != null ? (double?)lt.Diem : null,

                            TrangThai =
                                lt == null ? "Chưa thi" :
                                lt.ThoiDiemNopBai == null ? "Chưa nộp" :
                                "Đã nộp"
                        }).ToList();

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("ChiTietDotThi");

                // HEADER
                ws.Cells[1, 1].Value = "Họ tên";
                ws.Cells[1, 2].Value = "Lớp";
                ws.Cells[1, 3].Value = "Thời gian vào";
                ws.Cells[1, 4].Value = "Thời gian nộp";
                ws.Cells[1, 5].Value = "Điểm";
                ws.Cells[1, 6].Value = "Trạng thái";

                // STYLE HEADER
                using (var range = ws.Cells[1, 1, 1, 6])
                {
                    range.Style.Font.Bold = true;
                }

                //FORMAT DATE
                ws.Column(3).Style.Numberformat.Format = "dd/MM/yyyy HH:mm";
                ws.Column(4).Style.Numberformat.Format = "dd/MM/yyyy HH:mm";

                int row = 2;

                foreach (var item in data)
                {
                    ws.Cells[row, 1].Value = item.Ten;
                    ws.Cells[row, 2].Value = item.Lop;
             
                    if (item.ThoiGianVao.HasValue)
                        ws.Cells[row, 3].Value = item.ThoiGianVao.Value;
                    else
                        ws.Cells[row, 3].Value = "";

                    if (item.ThoiGianNop.HasValue)
                        ws.Cells[row, 4].Value = item.ThoiGianNop.Value;
                    else
                        ws.Cells[row, 4].Value = "";

                    ws.Cells[row, 5].Value = item.Diem ?? 0;
                    ws.Cells[row, 6].Value = item.TrangThai;

                    if (item.TrangThai == "Đã nộp")
                        ws.Cells[row, 6].Style.Font.Color.SetColor(System.Drawing.Color.Green);
                    else if (item.TrangThai == "Chưa nộp")
                        ws.Cells[row, 6].Style.Font.Color.SetColor(System.Drawing.Color.Orange);
                    else
                        ws.Cells[row, 6].Style.Font.Color.SetColor(System.Drawing.Color.Red);

                    row++;
                }

                ws.Cells.AutoFitColumns();

                var file = package.GetAsByteArray();

                return File(file,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "ChiTietDotThi.xlsx");
            }
        

    }
    }
}



