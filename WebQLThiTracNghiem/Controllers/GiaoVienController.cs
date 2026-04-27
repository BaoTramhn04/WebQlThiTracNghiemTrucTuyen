using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebQLThiTracNghiem.Data;
using WebQLThiTracNghiem.Models;

namespace WebQLThiTracNghiem.Controllers
{
    public class GiaoVienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GiaoVienController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ===============================
        // HÀM DÙNG CHUNG
        // ===============================

        private int? GetMaGiaoVien()
        {
            var maGV = HttpContext.Session.GetInt32("MaGiaoVien");

            if (maGV == null)
            {
                var maNguoiDung = HttpContext.Session.GetInt32("MaNguoiDung");

                if (maNguoiDung != null)
                {
                    var gv = _context.GiaoVien
                        .FirstOrDefault(x => x.MaNguoiDung == maNguoiDung);

                    if (gv != null)
                    {
                        HttpContext.Session.SetInt32("MaGiaoVien", gv.MaGiaoVien);
                        return gv.MaGiaoVien;
                    }
                }
            }

            return maGV;
        }
        private IActionResult? KiemTraDangNhap()
        {
            var vaiTro = HttpContext.Session.GetInt32("VaiTro");

            // chưa login
            if (vaiTro == null)
            {
                return RedirectToAction("DangNhap", "Auth");
            }

            // không phải giáo viên
            if (vaiTro != 2)
            {
                return Content("Bạn không có quyền truy cập trang giáo viên");
            }

            // thiếu MaGiaoVien
            var maGV = GetMaGiaoVien();
            if (maGV == null)
            {
                return RedirectToAction("DangNhap", "Auth");
            }

            return null;
        }

        private List<int> GetDanhSachMonCuaGiaoVien(int maGV)
        {
            return _context.PhanCongGiangDays
                .Where(x => x.MaGiaoVien == maGV)
                .Select(x => x.MaMon)
                .Distinct()
                .ToList();
        }
        private List<string> GetTenMonCuaGiaoVien(int maGV)
        {
            return (from pc in _context.PhanCongGiangDays
                    join mh in _context.MonHoc on pc.MaMon equals mh.MaMonHoc
                    where pc.MaGiaoVien == maGV
                    select mh.TenMonHoc)
                    .Distinct()
                    .ToList();
        }
        private List<int> GetDanhSachLopCuaGiaoVien(int maGV)
        {
            return _context.PhanCongGiangDays
                .Where(x => x.MaGiaoVien == maGV)
                .Select(x => x.MaLop)
                .Distinct()
                .ToList();
        }

        // ===============================
        // DASHBOARD
        // ===============================

        public IActionResult BangDieuKhien()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var lopIds = GetDanhSachLopCuaGiaoVien(maGV);
            var monIds = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Bảng điều khiển";

            // Số lớp đang quản lý
            ViewBag.SoLop = lopIds.Count;

            // Số học sinh thuộc các lớp giáo viên phụ trách
            ViewBag.SoHocSinh = _context.HocSinh
     .Count(x => x.MaLop != null && lopIds.Contains(x.MaLop.Value));

            // Số câu hỏi thuộc các môn giáo viên dạy
            ViewBag.SoCauHoi = (from ch in _context.CauHoi
                                join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                                where monIds.Contains(cd.MaMonHoc)
                                select ch.MaCauHoi)
                                .Count();

            // Số đề thi thuộc các môn giáo viên dạy
            ViewBag.SoDeThi = _context.DeThi
                .Count(x => monIds.Contains(x.MaMonHoc));

            // Số đợt thi thuộc các môn giáo viên dạy
            ViewBag.SoDotThi = (from dotThi in _context.DotThi
                                join deThi in _context.DeThi on dotThi.MaDeThi equals deThi.MaDeThi
                                where monIds.Contains(deThi.MaMonHoc)
                                select dotThi.MaDotThi)
                                .Count();

            // Đợt thi gần đây
            var dotThiGanDay = (from dt in _context.DotThi
                                join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                                join mh in _context.MonHoc on d.MaMonHoc equals mh.MaMonHoc
                                where monIds.Contains(mh.MaMonHoc)
                                orderby dt.ThoiGianBatDau descending
                                select new
                                {
                                    dt.MaDotThi,
                                    dt.TenDotThi,
                                    TenMonHoc = mh.TenMonHoc,
                                    dt.ThoiGianBatDau,
                                    dt.ThoiGianKetThuc,
                                    TrangThaiText =
                                        dt.ThoiGianBatDau > DateTime.Now ? "Sắp diễn ra" :
                                        dt.ThoiGianKetThuc < DateTime.Now ? "Đã kết thúc" :
                                        "Đang mở"
                                })
                                .Take(5)
                                .ToList();

            return View(dotThiGanDay);
        }

        // ===============================
        // DANH SÁCH HỌC SINH
        // ===============================

        public IActionResult HocSinh(string? keyword, int? lopId, int page = 1)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var lopGV = GetDanhSachLopCuaGiaoVien(maGV);

            if (lopGV == null || !lopGV.Any())
            {
                lopGV = _context.Lop.Select(l => l.MaLop).ToList();
            }

            ViewData["Title"] = "Quản lý học sinh";

            var query = _context.HocSinh
                .Include(h => h.NguoiDung)
                    .ThenInclude(nd => nd.HoSoCaNhan)
                .Include(h => h.Lop)
                .Where(h => h.MaLop != null && lopGV.Contains(h.MaLop.Value))
                .AsQueryable();

            // SEARCH
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(h =>
                    h.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword) ||
                    h.SoBaoDanh.Contains(keyword));
            }

            // FILTER LỚP
            if (lopId != null)
            {
                query = query.Where(h => h.MaLop == lopId);
            }

            // PHÂN TRANG
            int pageSize = 10;
            int total = query.Count();

            var data = query
                .OrderBy(h => h.Lop!.TenLop)
                .ThenBy(h => h.SoBaoDanh)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // ===== VIEWBAG =====
            ViewBag.Page = page;
            ViewBag.TotalPage = (int)Math.Ceiling((double)total / pageSize);

            ViewBag.DanhSachLop = _context.Lop
                .Where(l => lopGV.Contains(l.MaLop))
                .ToList();

            ViewBag.Keyword = keyword;
            ViewBag.LopId = lopId;

            var soLuongTheoLop = _context.HocSinh
                .Where(h => h.MaLop != null && lopGV.Contains(h.MaLop.Value))
                .GroupBy(h => h.MaLop.Value)
                .Select(g => new
                {
                    MaLop = g.Key,
                    Count = g.Count()
                })
                .ToDictionary(x => x.MaLop, x => x.Count);

            ViewBag.SoLuongTheoLop = soLuongTheoLop;

            ViewBag.TongHocSinh = soLuongTheoLop.Values.Sum();

            return View(data);
        }
        // ===============================
        // HỌC SINH - XÓA
        // ===============================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult XoaHocSinh(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var lopGV = GetDanhSachLopCuaGiaoVien(maGV);

            var hocSinh = _context.HocSinh
                .FirstOrDefault(x => x.MaHocSinh == id);

            if (hocSinh == null)
            {
                return NotFound();
            }

            if (hocSinh.MaLop == null || !lopGV.Contains(hocSinh.MaLop.Value))
            {
                return Content("Bạn không có quyền xóa học sinh này");
            }

            var dsDuThi = _context.DanhSachDuThi
                .Where(x => x.MaHocSinh == id);
            _context.DanhSachDuThi.RemoveRange(dsDuThi);

            var luotThi = _context.LuotThi
                .Where(x => x.MaHocSinh == id);
            _context.LuotThi.RemoveRange(luotThi);

            _context.HocSinh.Remove(hocSinh);
            _context.SaveChanges();

            TempData["success"] = "Đã xóa học sinh thành công.";

            return RedirectToAction("HocSinh");
        }

        // ===============================
        // CÂU HỎI - DANH SÁCH
        // ===============================

        public IActionResult CauHoi(string? keyword, int? monId, int? chuyenDeId,
    int? mucDo, bool? trangThai, string? loai, int? khoi, int page = 1)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            ViewBag.MaGV = maGV;
            ViewBag.Loai = loai;

            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Ngân hàng câu hỏi";

            var query = from ch in _context.CauHoi
                        join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                        join mh in _context.MonHoc on cd.MaMonHoc equals mh.MaMonHoc
                        where monGV.Contains(mh.MaMonHoc)
                        select new
                        {
                            ch.MaCauHoi,
                            ch.NoiDung,
                            ch.MucDo,
                            ch.TrangThai,
                            ch.NgayTao,
                            ch.NguoiTao,
                            cd.MaChuyenDe,
                            cd.TenChuyenDe,
                            mh.MaMonHoc,
                            mh.TenMonHoc,
                            Khoi = cd.Khoi

                        };

            // ===== FILTER =====
            if (!string.IsNullOrWhiteSpace(keyword))
                query = query.Where(x => x.NoiDung.Contains(keyword));

            if (monId != null)
                query = query.Where(x => x.MaMonHoc == monId);

            if (chuyenDeId != null)
                query = query.Where(x => x.MaChuyenDe == chuyenDeId);

            if (mucDo != null)
                query = query.Where(x => x.MucDo == mucDo);

            if (trangThai != null)
                query = query.Where(x => x.TrangThai == trangThai);
            if (khoi != null)
            {
                query = query.Where(x => x.Khoi == khoi);
            }
            if (!string.IsNullOrEmpty(loai))
            {
                if (loai == "mine")
                    query = query.Where(x => x.NguoiTao == maGV);
                else if (loai == "other")
                    query = query.Where(x => x.NguoiTao != maGV);
            }

            // ===== PHÂN TRANG =====
            int pageSize = 10;
            int total = query.Count();

            var data = query
                .OrderByDescending(x => x.NgayTao)
                .ThenByDescending(x => x.MaCauHoi)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // ===== VIEWBAG =====
            ViewBag.Page = page;
            ViewBag.TotalPage = (int)Math.Ceiling((double)total / pageSize);
            ViewBag.Khoi = khoi;
            ViewBag.Keyword = keyword;
            ViewBag.MonId = monId;
            ViewBag.ChuyenDeId = chuyenDeId;
            ViewBag.MucDo = mucDo;
            ViewBag.TrangThai = trangThai;
           
            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            ViewBag.ChuyenDe = _context.ChuyenDe
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenChuyenDe)
                .ToList();

            return View(data);
        }

        // ===============================
        // CÂU HỎI - THÊM
        // ===============================

        public IActionResult TaoCauHoi()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Thêm câu hỏi";

            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            ViewBag.ChuyenDe = _context.ChuyenDe
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenChuyenDe)
                .ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TaoCauHoi(CauHoi cauHoi, List<string> dapAn, int dapAnDung)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var chuyenDeHopLe = _context.ChuyenDe
                .Any(x => x.MaChuyenDe == cauHoi.MaChuyenDe && monGV.Contains(x.MaMonHoc));

            if (!chuyenDeHopLe)
            {
                ModelState.AddModelError("", "Chuyên đề không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(cauHoi.NoiDung) ||
       cauHoi.NoiDung.Trim() == "<br>" ||
       cauHoi.NoiDung.Trim() == "<div><br></div>")
            {
                ModelState.AddModelError("", "Nội dung câu hỏi không được để trống.");
            }

            if (dapAn == null || dapAn.Count == 0)
            {
                ModelState.AddModelError("", "Phải có ít nhất 1 đáp án.");
            }

            if (dapAnDung < 0 || dapAnDung > 3)
            {
                ModelState.AddModelError("", "Bạn phải chọn một đáp án đúng.");
            }

            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Thêm câu hỏi";

                ViewBag.MonHoc = _context.MonHoc
                    .Where(x => monGV.Contains(x.MaMonHoc))
                    .OrderBy(x => x.TenMonHoc)
                    .ToList();

                ViewBag.ChuyenDe = _context.ChuyenDe
                    .Where(x => monGV.Contains(x.MaMonHoc))
                    .OrderBy(x => x.TenChuyenDe)
                    .ToList();

                return View(cauHoi);
            }

            cauHoi.NgayTao = DateTime.Now;
            cauHoi.TrangThai = true;
            cauHoi.NguoiTao = maGV;

            _context.CauHoi.Add(cauHoi);
            _context.SaveChanges();

            for (int i = 0; i < dapAn.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(dapAn[i])) continue;

                _context.DapAn.Add(new DapAn
                {
                    MaCauHoi = cauHoi.MaCauHoi,
                    NoiDung = dapAn[i].Trim(),
                    LaDapAnDung = (i == dapAnDung)
                });
            }

            _context.SaveChanges();

            TempData["success"] = "Thêm câu hỏi thành công.";
            return RedirectToAction("CauHoi");
        }

        // ===============================
        // CÂU HỎI - CHI TIẾT
        // ===============================

        public IActionResult ChiTietCauHoi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var cauHoi = (from ch in _context.CauHoi
                          join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                          join mh in _context.MonHoc on cd.MaMonHoc equals mh.MaMonHoc
                          where ch.MaCauHoi == id && monGV.Contains(mh.MaMonHoc)
                          select new
                          {
                              ch.MaCauHoi,
                              ch.NoiDung,
                              ch.MucDo,
                              ch.TrangThai,
                              ch.NgayTao,
                              cd.TenChuyenDe,
                              mh.TenMonHoc
                          }).FirstOrDefault();

            if (cauHoi == null)
            {
                return NotFound();
            }

            var dapAn = _context.DapAn
                .Where(x => x.MaCauHoi == id)
                .OrderBy(x => x.MaDapAn)
                .ToList();

            ViewData["Title"] = "Chi tiết câu hỏi";
            ViewBag.CauHoi = cauHoi;
            ViewBag.DapAn = dapAn;

            return View();
        }

        // ===============================
        // CÂU HỎI - SỬA
        // ===============================

        public IActionResult SuaCauHoi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var cauHoi = _context.CauHoi.FirstOrDefault(x => x.MaCauHoi == id);
            if (cauHoi == null)
            {
                return NotFound();
            }

            // LẤY CHUYÊN ĐỀ THEO ID 
            var chuyenDe = _context.ChuyenDe
                .FirstOrDefault(x => x.MaChuyenDe == cauHoi.MaChuyenDe);

            // CHECK QUYỀN
            if (chuyenDe == null || !monGV.Contains(chuyenDe.MaMonHoc))
            {
                return NotFound();
            }

            var dapAn = _context.DapAn
                .Where(x => x.MaCauHoi == id)
                .OrderBy(x => x.MaDapAn)
                .ToList();

            ViewData["Title"] = "Sửa câu hỏi";

            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            ViewBag.ChuyenDe = _context.ChuyenDe
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenChuyenDe)
                .ToList();

            ViewBag.DapAn = dapAn;

            return View(cauHoi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaCauHoi(int id, CauHoi model, List<string> dapAn, int dapAnDung)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var cauHoi = _context.CauHoi.FirstOrDefault(x => x.MaCauHoi == id);
            if (cauHoi == null)
            {
                return NotFound();
            }

            var chuyenDeHopLe = _context.ChuyenDe
                .Any(x => x.MaChuyenDe == model.MaChuyenDe && monGV.Contains(x.MaMonHoc));

            if (!chuyenDeHopLe)
            {
                ModelState.AddModelError("", "Chuyên đề không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(model.NoiDung) ||
      model.NoiDung.Trim() == "<br>" ||
      model.NoiDung.Trim() == "<div><br></div>")
            {
                ModelState.AddModelError("", "Nội dung câu hỏi không được để trống.");
            }
            int soDapAn = dapAn.Count(x => !string.IsNullOrWhiteSpace(x));

            if (soDapAn < 2)
            {
                ModelState.AddModelError("", "Phải có ít nhất 2 đáp án.");
            }
            if (dapAnDung < 0 || dapAnDung > 3)
            {
                ModelState.AddModelError("", "Bạn phải chọn một đáp án đúng.");
            }

            var dsDapAn = _context.DapAn
                .Where(x => x.MaCauHoi == id)
                .OrderBy(x => x.MaDapAn)
                .ToList();

            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Sửa câu hỏi";

                ViewBag.MonHoc = _context.MonHoc
                    .Where(x => monGV.Contains(x.MaMonHoc))
                    .OrderBy(x => x.TenMonHoc)
                    .ToList();

                ViewBag.ChuyenDe = _context.ChuyenDe
                    .Where(x => monGV.Contains(x.MaMonHoc))
                    .OrderBy(x => x.TenChuyenDe)
                    .ToList();

                ViewBag.DapAn = dsDapAn;
                return View(model);
            }

            cauHoi.NoiDung = model.NoiDung.Trim();
            cauHoi.MaChuyenDe = model.MaChuyenDe;
            cauHoi.MucDo = model.MucDo;
            cauHoi.TrangThai = model.TrangThai;

            for (int i = 0; i < dsDapAn.Count && i < dapAn.Count; i++)
            {
                dsDapAn[i].NoiDung = dapAn[i].Trim();
                dsDapAn[i].LaDapAnDung = (i == dapAnDung);
            }

            _context.SaveChanges();

            TempData["success"] = "Cập nhật câu hỏi thành công.";
            return RedirectToAction("CauHoi");
        }

        // ===============================
        // CÂU HỎI - ẨN / HIỆN
        // ===============================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DoiTrangThaiCauHoi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var cauHoi = (from ch in _context.CauHoi
                          join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                          where ch.MaCauHoi == id && monGV.Contains(cd.MaMonHoc)
                          select ch).FirstOrDefault();

            if (cauHoi == null)
            {
                return NotFound();
            }

            cauHoi.TrangThai = !cauHoi.TrangThai;
            _context.SaveChanges();

            TempData["success"] = cauHoi.TrangThai
                ? "Đã bật lại câu hỏi."
                : "Đã ẩn câu hỏi.";

            return RedirectToAction("CauHoi");
        }

        // ===============================
        // ĐỀ THI - DANH SÁCH
        // ===============================

        public IActionResult DeThi(string? keyword, int? monId, int? khoi, int page = 1)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            int pageSize = 5;

            var query = from dt in _context.DeThi
                        join mh in _context.MonHoc on dt.MaMonHoc equals mh.MaMonHoc
                        where monGV.Contains(mh.MaMonHoc)
                        select new
                        {
                            dt.MaDeThi,
                            dt.TenDeThi,
                            mh.MaMonHoc,
                            mh.TenMonHoc,
                            dt.ThoiGianLamBai,
                            dt.TrangThai,

                            SoCau = _context.ChiTietDeThi.Count(x => x.MaDeThi == dt.MaDeThi),
                            DaSuDung = _context.DotThi.Any(x => x.MaDeThi == dt.MaDeThi),

                            dt.NguoiTao,
                            dt.Khoi 
                        };

            // SEARCH
            if (!string.IsNullOrWhiteSpace(keyword))
                query = query.Where(x => x.TenDeThi.Contains(keyword));

            // FILTER MÔN
            if (monId != null)
                query = query.Where(x => x.MaMonHoc == monId);

            // FILTER KHỐI
            if (khoi != null)
                query = query.Where(x => x.Khoi == khoi);
            int total = query.Count();

            var data = query
                .OrderByDescending(x => x.MaDeThi)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // ===== VIEW =====
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)total / pageSize);
            ViewBag.Khoi = khoi;
            ViewBag.Keyword = keyword;
            ViewBag.MonId = monId;
            

            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            return View(data);
        }

        // ===============================
        // HÀM CHECK GIÁO VIÊN ĐẠI DIỆN
        // ===============================
        private bool LaGiaoVienDaiDien(int maGV, int maMon)
        {
            return _context.PhanCongGiangDays
                .Any(x => x.MaMon == maMon
                       && x.MaGiaoVien == maGV
                       && x.LaDaiDien == true);
        }

        // ===============================
        // ĐỀ THI - TẠO (GET)
        // ===============================
        public IActionResult TaoDeThi()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Tạo đề thi";

            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            // truyền thông tin đại diện theo từng môn
            var allMon = _context.MonHoc.Select(x => x.MaMonHoc).ToList();

            ViewBag.LaDaiDienTheoMon = allMon.ToDictionary(
                mon => mon.ToString(),
                mon => _context.PhanCongGiangDays
                    .Any(x => x.MaMon == mon
                           && x.MaGiaoVien == maGV
                           && x.LaDaiDien == true)
            );

            return View();
        }

        // ===============================
        // ĐỀ THI - TẠO (POST)
        // ===============================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TaoDeThi(DeThi deThi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            ModelState.Remove("MonHoc");

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            // Môn không hợp lệ
            if (!monGV.Contains(deThi.MaMonHoc))
            {
                ModelState.AddModelError("", "Môn học không hợp lệ.");
            }

            // Tên rỗng
            if (string.IsNullOrWhiteSpace(deThi.TenDeThi))
            {
                ModelState.AddModelError("", "Tên đề thi không được để trống.");
            }

            // Thời gian
            if (deThi.ThoiGianLamBai <= 0)
            {
                ModelState.AddModelError("", "Thời gian làm bài phải lớn hơn 0.");
            }
            if (deThi.Khoi == 0)
            {
                ModelState.AddModelError("", "Bạn phải chọn khối.");
            }
            //CHẶN ĐỀ CHUNG 
            if (deThi.LoaiDe == "Chung")
            {
                if (!LaGiaoVienDaiDien(maGV, deThi.MaMonHoc))
                {
                    ModelState.AddModelError("", "Chỉ giáo viên đại diện mới được tạo đề chung!");
                }
              
            }

            // Nếu lỗi → trả lại view
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Tạo đề thi";

                ViewBag.MonHoc = _context.MonHoc
                    .Where(x => monGV.Contains(x.MaMonHoc))
                    .OrderBy(x => x.TenMonHoc)
                    .ToList();
                var allMon = _context.MonHoc.Select(x => x.MaMonHoc).ToList();

                ViewBag.LaDaiDienTheoMon = allMon.ToDictionary(
                    mon => mon.ToString(),
                    mon => _context.PhanCongGiangDays
                        .Any(x => x.MaMon == mon
                               && x.MaGiaoVien == maGV
                               && x.LaDaiDien == true)
                );
                return View(deThi);
            }
            deThi.TrangThai = true;
            deThi.NguoiTao = maGV;

            if (deThi.LoaiDe == "Chung")
            {
                if (!LaGiaoVienDaiDien(maGV, deThi.MaMonHoc))
                {
                    ModelState.AddModelError("", "Bạn không phải giáo viên đại diện!");
                    return View(deThi);
                }
            }
            else
            {
                deThi.LoaiDe = "Rieng";
            }

            _context.DeThi.Add(deThi);
            _context.SaveChanges();

            TempData["success"] = "Tạo đề thi thành công 🎉";

            return RedirectToAction("ChiTietDeThi", new { id = deThi.MaDeThi });
        }

        // ===============================
        // ĐỀ THI - CHI TIẾT
        // ===============================

        public IActionResult ChiTietDeThi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var deThi = (from dt in _context.DeThi
                         join mh in _context.MonHoc on dt.MaMonHoc equals mh.MaMonHoc
                         where dt.MaDeThi == id && monGV.Contains(mh.MaMonHoc)
                         select new
                         {
                             dt.MaDeThi,
                             dt.TenDeThi,
                             dt.ThoiGianLamBai,
                             dt.TrangThai,
                             mh.MaMonHoc,
                             mh.TenMonHoc
                         }).FirstOrDefault();

            if (deThi == null)
            {
                return NotFound();
            }

            var dsCauHoi = (from ct in _context.ChiTietDeThi
                            join ch in _context.CauHoi on ct.MaCauHoi equals ch.MaCauHoi
                            join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                            where ct.MaDeThi == id
                            orderby ct.ThuTu
                            select new
                            {
                                ch.MaCauHoi,
                                ch.NoiDung,
                                cd.TenChuyenDe,
                                ch.MucDo,

                                DapAns = _context.DapAn
                                    .Where(x => x.MaCauHoi == ch.MaCauHoi)
                                    .OrderBy(x => x.MaDapAn)
                                    .Select(x => new
                                    {
                                        x.NoiDung,
                                        x.LaDapAnDung
                                    })
                                    .ToList()
                            }).ToList();
            ViewData["Title"] = "Chi tiết đề thi";
            ViewBag.DeThi = deThi;
            ViewBag.DanhSachCauHoi = dsCauHoi.ToList();

            return View();
        }

        // ===============================
        // ĐỀ THI - THÊM CÂU HỎI VÀO ĐỀ (GET)
        // ===============================

        public IActionResult ThemCauHoiVaoDe(int id, string? keyword, int? chuyenDeId, int? mucDo, int? khoi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var deThi = _context.DeThi.FirstOrDefault(x => x.MaDeThi == id);
            if (deThi == null || !monGV.Contains(deThi.MaMonHoc))
            {
                return NotFound();
            }

            var cauHoiDaCo = _context.ChiTietDeThi
                .Where(x => x.MaDeThi == id)
                .Select(x => x.MaCauHoi)
                .ToList();

            var query = from ch in _context.CauHoi
                        join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                        where cd.MaMonHoc == deThi.MaMonHoc
                              && ch.TrangThai
                              && !cauHoiDaCo.Contains(ch.MaCauHoi)
                              && cd.Khoi == deThi.Khoi  

                        select new
                        {
                            ch.MaCauHoi,
                            ch.NoiDung,
                            cd.MaChuyenDe,
                            cd.TenChuyenDe,
                            ch.MucDo,
                            Khoi = cd.Khoi

                        };

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.NoiDung.Contains(keyword));
            }

            if (chuyenDeId != null)
            {
                query = query.Where(x => x.MaChuyenDe == chuyenDeId);
            }

            if (mucDo != null)
            {
                query = query.Where(x => x.MucDo == mucDo);
            }
            if (khoi != null)
            {
                query = query.Where(x => x.Khoi == khoi);
            }

            ViewData["Title"] = "Thêm câu hỏi vào đề";
            ViewBag.DeThi = deThi;
            ViewBag.Keyword = keyword;
            ViewBag.ChuyenDeId = chuyenDeId;
            ViewBag.MucDo = mucDo;
            ViewBag.ChuyenDe = _context.ChuyenDe
                .Where(x => x.MaMonHoc == deThi.MaMonHoc)
                .OrderBy(x => x.TenChuyenDe)
                .ToList();
            ViewBag.Khoi = khoi;
            ViewBag.DanhSachKhoi = new List<int> { 10, 11, 12 };
            return View(query.OrderBy(x => x.MaCauHoi).ToList());
        }

        // ===============================
        // ĐỀ THI - THÊM CÂU HỎI VÀO ĐỀ (POST)
        // ===============================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemCauHoiVaoDe(int id, List<int> cauHoiIds)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var deThi = _context.DeThi.FirstOrDefault(x => x.MaDeThi == id);
            if (deThi == null || !monGV.Contains(deThi.MaMonHoc))
            {
                return NotFound();
            }

            if (cauHoiIds == null || !cauHoiIds.Any())
            {
                TempData["error"] = "Bạn chưa chọn câu hỏi nào.";
                return RedirectToAction("ThemCauHoiVaoDe", new { id });
            }

            var cauHoiHopLe = (from ch in _context.CauHoi
                               join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                               where cauHoiIds.Contains(ch.MaCauHoi)
                                     && cd.MaMonHoc == deThi.MaMonHoc
                               select ch.MaCauHoi).ToList();

            var daTonTai = _context.ChiTietDeThi
                .Where(x => x.MaDeThi == id)
                .Select(x => x.MaCauHoi)
                .ToList();

            foreach (var maCauHoi in cauHoiHopLe)
            {
                if (!daTonTai.Contains(maCauHoi))
                {
                    _context.ChiTietDeThi.Add(new ChiTietDeThi
                    {
                        MaDeThi = id,
                        MaCauHoi = maCauHoi
                    });
                }
            }

            _context.SaveChanges();

            TempData["success"] = "Đã thêm câu hỏi vào đề thi.";
            return RedirectToAction("ChiTietDeThi", new { id });
        }

        // ===============================
        // ĐỀ THI - XÓA CÂU HỎI KHỎI ĐỀ
        // ===============================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult XoaCauHoiKhoiDe(int maDeThi, int maCauHoi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var deThi = _context.DeThi.FirstOrDefault(x => x.MaDeThi == maDeThi);
            if (deThi == null || !monGV.Contains(deThi.MaMonHoc))
            {
                return NotFound();
            }

            var chiTiet = _context.ChiTietDeThi
                .FirstOrDefault(x => x.MaDeThi == maDeThi && x.MaCauHoi == maCauHoi);

            if (chiTiet == null)
            {
                return NotFound();
            }

            _context.ChiTietDeThi.Remove(chiTiet);
            _context.SaveChanges();

            TempData["success"] = "Đã xóa câu hỏi khỏi đề thi.";
            return RedirectToAction("ChiTietDeThi", new { id = maDeThi });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult XoaDeThi(int id)
        {
            var de = _context.DeThi.Find(id);
            var maGV = GetMaGiaoVien()!.Value; 

            if (de != null)
            {
                if (_context.DotThi.Any(x => x.MaDeThi == id))
                {
                    TempData["error"] = "Không thể xóa vì đề đã được sử dụng!";
                    return RedirectToAction("DeThi");
                }

                if (de.NguoiTao != maGV)
                {
                    return Content("Không có quyền");
                }
                var ct = _context.ChiTietDeThi.Where(x => x.MaDeThi == id);
                _context.ChiTietDeThi.RemoveRange(ct);

                _context.DeThi.Remove(de);
                _context.SaveChanges();
            }

            return RedirectToAction("DeThi");
        }
        public IActionResult SuaDeThi(int id)
        {
            var de = _context.DeThi.Find(id);
            if (de == null) return NotFound();
            return View(de);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult SuaDeThi(DeThi model)
        {
            var de = _context.DeThi.Find(model.MaDeThi);

            if (de != null)
            {
                de.TenDeThi = model.TenDeThi;
                de.ThoiGianLamBai = model.ThoiGianLamBai;
                _context.SaveChanges();
            }

            return RedirectToAction("DeThi");
        }
        public IActionResult CopyDeThi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var de = _context.DeThi.FirstOrDefault(x => x.MaDeThi == id);
            if (de == null) return NotFound();

            // TẠO ĐỀ MỚI
            var newDe = new DeThi
            {
                TenDeThi = de.TenDeThi + " (Copy)",
                MaMonHoc = de.MaMonHoc,
                ThoiGianLamBai = de.ThoiGianLamBai,
                TrangThai = true,
                Khoi = de.Khoi,

                // QUAN TRỌNG
                NguoiTao = maGV,
                LoaiDe = "Rieng" 
            };

            _context.DeThi.Add(newDe);
            _context.SaveChanges();

            // COPY CÂU HỎI
            var list = _context.ChiTietDeThi
                .Where(x => x.MaDeThi == id)
                .ToList();

            foreach (var item in list)
            {
                _context.ChiTietDeThi.Add(new ChiTietDeThi
                {
                    MaDeThi = newDe.MaDeThi,
                    MaCauHoi = item.MaCauHoi
                });
            }

            _context.SaveChanges();

            TempData["success"] = "Copy đề thành công 🎉";

            return RedirectToAction("DeThi");
        }
        // ===============================
        // ĐỢT THI - DANH SÁCH
        // ===============================

        public IActionResult DotThi(string? keyword, string? trangThai, int? khoi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Quản lý đợt thi";

            //  LẤY DATA TRƯỚC 
            var dotThiList = (from dt in _context.DotThi
                              join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                              join mh in _context.MonHoc on d.MaMonHoc equals mh.MaMonHoc
                              where monGV.Contains(mh.MaMonHoc)
                                    && dt.NguoiTao == maGV
                              select new
                              {
                                  dt.MaDotThi,
                                  dt.TenDotThi,
                                  mh.TenMonHoc,
                                  d.Khoi,
                                  dt.IsKhoa,
                                  dt.ThoiGianBatDau,
                                  dt.ThoiGianKetThuc
                              })
                              .ToList(); 

            var result = dotThiList.Select(dt => new
            {
                dt.MaDotThi,
                dt.TenDotThi,
                dt.TenMonHoc,
                dt.Khoi,
                IsKhoa = dt.IsKhoa,

                dt.ThoiGianBatDau,
                dt.ThoiGianKetThuc,

                TrangThai =
                    DateTime.Now < dt.ThoiGianBatDau ? "SapDienRa" :
                    DateTime.Now > dt.ThoiGianKetThuc ? "DaKetThuc" :
                    "DangDienRa",

                // chỉ đếm học sinh đã gán
                SoHocSinh = _context.DanhSachDuThi
                    .Count(x => x.MaDotThi == dt.MaDotThi),

                SoDaThi = _context.LuotThi
                    .Count(x => x.MaDotThi == dt.MaDotThi),

                CoTheSua = DateTime.Now < dt.ThoiGianBatDau,

                CoTheXoa =
    !_context.LuotThi.Any(x => x.MaDotThi == dt.MaDotThi)
    && DateTime.Now < dt.ThoiGianKetThuc,

                LyDoKhoa =
                    DateTime.Now >= dt.ThoiGianBatDau && DateTime.Now <= dt.ThoiGianKetThuc
                        ? "Đợt thi đang diễn ra"
                        : DateTime.Now > dt.ThoiGianKetThuc
                            ? "Đợt thi đã kết thúc"
                            : _context.LuotThi.Any(x => x.MaDotThi == dt.MaDotThi)
                                ? "Đã có học sinh làm bài"
                                : ""
            });

            //SEARCH
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                result = result.Where(x => x.TenDotThi.Contains(keyword));
            }

            ViewBag.Keyword = keyword;

            //FILTER TRẠNG THÁI
            if (!string.IsNullOrEmpty(trangThai))
            {
                result = result.Where(x => x.TrangThai == trangThai);
            }

            //FILTER KHỐI (chỉ để lọc UI)
            if (khoi != null)
            {
                result = result.Where(x => x.Khoi == khoi);
            }

            ViewBag.TrangThai = trangThai;
            ViewBag.Khoi = khoi;
            ViewBag.DanhSachKhoi = new List<int> { 10, 11, 12 };

            return View(result
                .OrderByDescending(x => x.ThoiGianBatDau)
                .ToList());
        }
        // ===============================
        // ĐỢT THI - TẠO
        // ===============================

        public IActionResult TaoDotThi(int? khoi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Tạo đợt thi";

            var deThi = _context.DeThi
                .Where(x => monGV.Contains(x.MaMonHoc));

            if (khoi != null)
            {
                deThi = deThi.Where(x => x.Khoi == khoi);
            }

            ViewBag.DeThi = deThi
                .OrderByDescending(x => x.MaDeThi)
                .ToList();

            ViewBag.Khoi = khoi;
            ViewBag.DanhSachKhoi = new List<int> { 10, 11, 12 };

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TaoDotThi(DotThi dotThi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            ModelState.Remove("DeThi");

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var deThi = _context.DeThi.FirstOrDefault(x => x.MaDeThi == dotThi.MaDeThi);

            // đề không hợp lệ
            if (deThi == null || !monGV.Contains(deThi.MaMonHoc))
            {
                TempData["error"] = "Đề thi không hợp lệ.";
                return RedirectToAction("TaoDotThi");
            }

            // KHÔNG gán khối nữa 

            // số lần thi mặc định
            dotThi.SoLanThiToiDa = dotThi.SoLanThiToiDa > 0 ? dotThi.SoLanThiToiDa : 1;

            //VALIDATE THỜI GIAN
            if (dotThi.ThoiGianBatDau >= dotThi.ThoiGianKetThuc)
            {
                TempData["error"] = "Thời gian kết thúc phải lớn hơn thời gian bắt đầu.";
                return RedirectToAction("TaoDotThi");
            }

            if (dotThi.ThoiGianBatDau <= DateTime.Now)
            {
                TempData["error"] = "Thời gian bắt đầu phải lớn hơn hiện tại.";
                return RedirectToAction("TaoDotThi");
            }

            if (dotThi.ThoiGianKetThuc <= DateTime.Now)
            {
                TempData["error"] = "Đợt thi phải nằm trong tương lai.";
                return RedirectToAction("TaoDotThi");
            }

            // trạng thái + người tạo
            dotThi.TrangThai = true;
            dotThi.NguoiTao = maGV;

            _context.DotThi.Add(dotThi);
            _context.SaveChanges();

            TempData["success"] = "Tạo đợt thi thành công.";
            return RedirectToAction("DotThi");
        }

        public IActionResult ChiTietDotThi(int id, int? lopId, string? trangThai)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            // ===== THÔNG TIN ĐỢT THI =====
            var dotThi = (from dt in _context.DotThi
                          join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                          join mh in _context.MonHoc on de.MaMonHoc equals mh.MaMonHoc
                          where dt.MaDotThi == id && monGV.Contains(mh.MaMonHoc)
                          select new
                          {
                              dt.MaDotThi,
                              dt.TenDotThi,
                              dt.MaDeThi,
                              de.TenDeThi,
                              mh.TenMonHoc,
                              dt.ThoiGianBatDau,
                              dt.ThoiGianKetThuc,
                              de.Khoi
                          }).FirstOrDefault();

            if (dotThi == null)
                return NotFound();

            // CHECK: đã gán lớp chưa
            var daGan = _context.DanhSachDuThi.Any(x => x.MaDotThi == id);

            var data = new List<object>();

            if (daGan)
            {
                var query = from ds in _context.DanhSachDuThi
                            join hs in _context.HocSinh on ds.MaHocSinh equals hs.MaHocSinh
                            join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                            join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung
                            join lop in _context.Lop on hs.MaLop equals lop.MaLop

                            join lt in _context.LuotThi
                            on new { ds.MaDotThi, hs.MaHocSinh }
                            equals new { lt.MaDotThi, lt.MaHocSinh }
                            into gj
                            from lt in gj.DefaultIfEmpty()

                            where ds.MaDotThi == id

                            select new
                            {
                                hs.MaHocSinh,
                                hs.SoBaoDanh,
                                hoso.HoTen,
                                lop.MaLop,
                                lop.TenLop,

                                ThoiDiemVao = lt != null ? lt.ThoiDiemBatDau : (DateTime?)null,
                                ThoiDiemNop = lt != null ? lt.ThoiDiemNopBai : (DateTime?)null,
                                Diem = lt != null ? lt.Diem : (double?)null
                            };

                // filter lớp
                if (lopId != null)
                {
                    query = query.Where(x => x.MaLop == lopId);
                }

                // filter trạng thái
                if (!string.IsNullOrEmpty(trangThai))
                {
                    if (trangThai == "danop")
                        query = query.Where(x => x.ThoiDiemNop != null);

                    if (trangThai == "chuanop")
                        query = query.Where(x => x.ThoiDiemNop == null);
                }

                data = query
                    .OrderBy(x => x.TenLop)
                    .ThenBy(x => x.HoTen)
                    .ToList<object>();
            }

            // ===== DANH SÁCH LỚP =====
           var lopList = daGan
    ? (from ds in _context.DanhSachDuThi
       join hs in _context.HocSinh on ds.MaHocSinh equals hs.MaHocSinh
       join lop in _context.Lop on hs.MaLop equals lop.MaLop
       where ds.MaDotThi == id
       select lop)
      .Distinct()
      .OrderBy(x => x.TenLop)
      .ToList()
    : new List<Lop>();

            // ===== VIEW =====
            ViewData["Title"] = "Chi tiết đợt thi";
            ViewBag.DotThi = dotThi;
            ViewBag.DanhSachDuThi = data;
            ViewBag.Lop = lopList;
            ViewBag.LopId = lopId;
            ViewBag.TrangThai = trangThai;
            ViewBag.ChuaGan = !daGan; 

            return View();
        }

        // ===============================
        // ĐỢT THI - GÁN LỚP (GET)
        // ===============================

        public IActionResult GanLopVaoDotThi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var lopGV = GetDanhSachLopCuaGiaoVien(maGV);
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var dotThi = (from dt in _context.DotThi
                          join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                          where dt.MaDotThi == id && monGV.Contains(de.MaMonHoc)
                          select new
                          {
                              dt.MaDotThi,
                              dt.TenDotThi,
                              dt.ThoiGianBatDau,
                              Khoi = de.Khoi
                          }).FirstOrDefault();

            if (dotThi == null)
                return NotFound();

            ViewBag.DotThi = dotThi;

            // lọc theo GV + KHỐI
            var dsLop = _context.Lop
                .Where(x => lopGV.Contains(x.MaLop))
                .ToList() 
                .Where(x => x.TenLop.Contains(dotThi.Khoi.ToString()))
                .OrderBy(x => x.TenLop)
                .ToList();

            ViewBag.DanhSachLop = dsLop;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GanLopVaoDotThi(int id, List<int> lopIds)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var lopGV = GetDanhSachLopCuaGiaoVien(maGV);
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var dotThi = (from dt in _context.DotThi
                          join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                          where dt.MaDotThi == id && monGV.Contains(de.MaMonHoc)
                          select new
                          {
                              dt.MaDotThi,
                              dt.ThoiGianBatDau,
                              Khoi = de.Khoi
                          }).FirstOrDefault();

            if (dotThi == null)
                return NotFound();

            // chưa chọn lớp
            if (lopIds == null || !lopIds.Any())
            {
                TempData["error"] = "Bạn chưa chọn lớp nào.";
                return RedirectToAction("GanLopVaoDotThi", new { id });
            }

            // đã bắt đầu
            if (DateTime.Now >= dotThi.ThoiGianBatDau)
            {
                TempData["error"] = "Đợt thi đã bắt đầu, không thể gán lớp!";
                return RedirectToAction("DotThi");
            }

            // lọc lớp hợp lệ (GV + KHỐI)
            var lopHopLe = _context.Lop
                .Where(x => lopIds.Contains(x.MaLop) && lopGV.Contains(x.MaLop))
                .ToList()
                .Where(x => x.TenLop.Contains(dotThi.Khoi.ToString()))
                .Select(x => x.MaLop)
                .ToList();

            // lấy học sinh
            var hocSinhCanThem = _context.HocSinh
                .Where(x => x.MaLop != null && lopHopLe.Contains(x.MaLop.Value))
                .Select(x => x.MaHocSinh)
                .ToList();

            // tránh trùng
            var daTonTai = _context.DanhSachDuThi
                .Where(x => x.MaDotThi == id)
                .Select(x => x.MaHocSinh)
                .ToList();

            foreach (var maHocSinh in hocSinhCanThem)
            {
                if (!daTonTai.Contains(maHocSinh))
                {
                    _context.DanhSachDuThi.Add(new DanhSachDuThi
                    {
                        MaDotThi = id,
                        MaHocSinh = maHocSinh,
                        DuocPhepThi = true,
                        GhiChu = ""
                    });
                }
            }

            _context.SaveChanges();

            TempData["success"] = "Đã gán lớp vào đợt thi thành công 🎉";
            return RedirectToAction("ChiTietDotThi", new { id });
        }
        // ===============================
        // ĐỢT THI - XÓA HỌC SINH KHỎI ĐỢT THI
        // ===============================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult XoaHocSinhKhoiDotThi(int maDotThi, int maHocSinh)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var item = _context.DanhSachDuThi
                .FirstOrDefault(x => x.MaDotThi == maDotThi && x.MaHocSinh == maHocSinh);

            if (item == null)
            {
                return NotFound();
            }

            _context.DanhSachDuThi.Remove(item);
            _context.SaveChanges();

            TempData["success"] = "Đã xóa học sinh khỏi đợt thi.";
            return RedirectToAction("ChiTietDotThi", new { id = maDotThi });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult KhoaDotThi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var dotThi = _context.DotThi
                .FirstOrDefault(x => x.MaDotThi == id && x.NguoiTao == maGV);

            if (dotThi == null)
                return NotFound();

            // Không cho mở lại nếu đã kết thúc
            if (dotThi.IsKhoa && DateTime.Now > dotThi.ThoiGianKetThuc)
            {
                TempData["error"] = "Đợt thi đã kết thúc, không thể mở lại!";
                return RedirectToAction("DotThi");
            }

           

            // TOGGLE
            dotThi.IsKhoa = !dotThi.IsKhoa;

            _context.SaveChanges();

            TempData["success"] = dotThi.IsKhoa
                ? "🔒 Đã khóa đợt thi"
                : "🔓 Đã mở khóa đợt thi";

            return RedirectToAction("DotThi");
        }
        // ===============================
        // THÔNG TIN CÁ NHÂN + ĐỔI MẬT KHẨU
        // ===============================

        public IActionResult ThongTinCaNhan()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            ViewData["Title"] = "Thông tin cá nhân";

            var gv = _context.GiaoVien
                .Include(x => x.NguoiDung)
                .ThenInclude(x => x.HoSoCaNhan)
                .FirstOrDefault(x => x.MaGiaoVien == maGV);

            if (gv == null)
            {
                return NotFound();
            }

            return View(gv);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThongTinCaNhan(
    string matKhauCu,
    string matKhauMoi,
    string soDienThoai,
    string diaChi,
    DateTime? ngaySinh,
    IFormFile avatarFile)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var gv = _context.GiaoVien
                .Include(x => x.NguoiDung)
                .ThenInclude(x => x.HoSoCaNhan)
                .FirstOrDefault(x => x.MaGiaoVien == maGV);

            if (gv == null) return NotFound();

            var hoSo = gv.NguoiDung.HoSoCaNhan;

            // ===== CẬP NHẬT THÔNG TIN =====
            hoSo.SoDienThoai = soDienThoai;
            hoSo.DiaChi = diaChi;

            if (ngaySinh.HasValue)
                hoSo.NgaySinh = ngaySinh.Value.Date; 

          

            // ===== ĐỔI MẬT KHẨU =====
            if (!string.IsNullOrWhiteSpace(matKhauCu) && !string.IsNullOrWhiteSpace(matKhauMoi))
            {
                if (gv.NguoiDung.MatKhau != matKhauCu)
                {
                    ViewBag.Loi = "Mật khẩu cũ không đúng.";
                    return View(gv);
                }

                if (matKhauMoi.Length < 6)
                {
                    ViewBag.Loi = "Mật khẩu mới phải >= 6 ký tự.";
                    return View(gv);
                }

                gv.NguoiDung.MatKhau = matKhauMoi;
            }
            // ===== UPLOAD AVATAR =====
            if (avatarFile != null && avatarFile.Length > 0)
            {
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatar");

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(avatarFile.FileName);

                var filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    avatarFile.CopyTo(stream);
                }

                // LƯU DB
                hoSo.AnhDaiDien = fileName;

                // UPDATE SESSION 
                HttpContext.Session.SetString("Avatar", fileName);
            }
            _context.SaveChanges();

            ViewBag.ThongBao = "Cập nhật thành công 🎉";
            return View(gv);
        }

        public IActionResult ThongKe(string? keyword, int? monId, int? dotThiId, int? khoi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Thống kê";

            var query = from ds in _context.DanhSachDuThi
                        join dt in _context.DotThi on ds.MaDotThi equals dt.MaDotThi
                        join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                        join mh in _context.MonHoc on d.MaMonHoc equals mh.MaMonHoc
                        join hs in _context.HocSinh on ds.MaHocSinh equals hs.MaHocSinh
                        join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                        join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung
                        join lop in _context.Lop on hs.MaLop equals lop.MaLop

                        // LEFT JOIN
                        join lt in _context.LuotThi
                        on new { ds.MaDotThi, ds.MaHocSinh }
                        equals new { lt.MaDotThi, lt.MaHocSinh }
                        into gj
                        from lt in gj.DefaultIfEmpty()

                        where monGV.Contains(mh.MaMonHoc)
                              && dt.NguoiTao == maGV

                        select new
                        {
                            MaLuotThi = lt != null ? lt.MaLuotThi : 0,

                            hoso.HoTen,
                            hs.SoBaoDanh,
                            lop.TenLop,

                            dt.MaDotThi,
                            dt.TenDotThi,

                            mh.MaMonHoc,
                            mh.TenMonHoc,

                            ThoiDiemNopBai = lt != null ? lt.ThoiDiemNopBai : null,
                            Diem = lt != null ? lt.Diem : null,

                            d.Khoi
                        };

            // SEARCH
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    x.HoTen.Contains(keyword) ||
                    x.SoBaoDanh.Contains(keyword) ||
                    x.TenDotThi.Contains(keyword));
            }

            if (monId != null)
                query = query.Where(x => x.MaMonHoc == monId);

            if (dotThiId != null)
                query = query.Where(x => x.MaDotThi == dotThiId);

            if (khoi != null)
                query = query.Where(x => x.Khoi == khoi);

            var data = query.ToList();

            // ================= THỐNG KÊ =================

            ViewBag.TongLuotThi = data.Count;

            ViewBag.TongHocSinhDaThi = data
                .Where(x => x.ThoiDiemNopBai != null)
                .Select(x => x.SoBaoDanh)
                .Distinct()
                .Count();

            ViewBag.SoDaNop = data.Count(x => x.ThoiDiemNopBai != null);

            ViewBag.SoChuaNop = data.Count(x => x.ThoiDiemNopBai == null);

            ViewBag.ChartDaNop = ViewBag.SoDaNop;
            ViewBag.ChartChuaNop = ViewBag.SoChuaNop;

            // ================= CHART LỚP =================

            ViewBag.LabelLop = data
                .GroupBy(x => x.TenLop)
                .Select(g => g.Key)
                .ToList();

            ViewBag.DataLop = data
                .GroupBy(x => x.TenLop)
                .Select(g => g.Count())
                .ToList();

            // ================= CHART NGÀY =================

            ViewBag.LabelNgay = data
                .Where(x => x.ThoiDiemNopBai != null)
                .GroupBy(x => ((DateTime)x.ThoiDiemNopBai!).Date)
                .Select(g => g.Key.ToString("dd/MM"))
                .ToList();

            ViewBag.DataNgay = data
                .Where(x => x.ThoiDiemNopBai != null)
                .GroupBy(x => ((DateTime)x.ThoiDiemNopBai!).Date)
                .Select(g => g.Count())
                .ToList();

            // ================= TOP HỌC SINH =================

            ViewBag.TopHocSinh = data
                .Where(x => x.Diem != null)
                .OrderByDescending(x => x.Diem)
                .Take(5)
                .ToList();

            // ================= DROPDOWN =================

            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            ViewBag.DotThi = (from dt in _context.DotThi
                              join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                              where monGV.Contains(d.MaMonHoc)
                                    && dt.NguoiTao == maGV
                              orderby dt.ThoiGianBatDau descending
                              select new
                              {
                                  dt.MaDotThi,
                                  dt.TenDotThi
                              }).ToList();

            ViewBag.Keyword = keyword;
            ViewBag.MonId = monId;
            ViewBag.DotThiId = dotThiId;

            ViewBag.Khoi = khoi;
            ViewBag.DanhSachKhoi = new List<int> { 10, 11, 12 };

            return View(data);
        }
        public IActionResult ChiTietBaiLam(int maHocSinh, int maDotThi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            // LƯỢT THI
            var luotThi = (from lt in _context.LuotThi
                           join dt in _context.DotThi on lt.MaDotThi equals dt.MaDotThi
                           join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                           join mh in _context.MonHoc on de.MaMonHoc equals mh.MaMonHoc
                           where lt.MaHocSinh == maHocSinh
                                 && lt.MaDotThi == maDotThi
                                 && monGV.Contains(mh.MaMonHoc)
                           select new
                           {
                               lt.MaLuotThi,
                               lt.Diem,
                               dt.TenDotThi,
                               de.TenDeThi,
                               mh.TenMonHoc
                           }).FirstOrDefault();

            if (luotThi == null) return NotFound();

            // HỌC SINH
            var hocSinh = (from hs in _context.HocSinh
                           join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                           join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung
                           where hs.MaHocSinh == maHocSinh
                           select new
                           {
                               hs.MaHocSinh,
                               hoso.HoTen,
                               Avatar = hoso.AnhDaiDien
                           }).FirstOrDefault();

            // CHI TIẾT BÀI LÀM
            var chiTiet = (from ct in _context.ChiTietBaiLam
                           join ch in _context.CauHoi on ct.MaCauHoi equals ch.MaCauHoi
                           where ct.MaLuotThi == luotThi.MaLuotThi
                           select new
                           {
                               ch.NoiDung,
                               DungSai = ct.DungSai,
                               DapAns = _context.DapAn
                                   .Where(x => x.MaCauHoi == ch.MaCauHoi)
                                    .OrderBy(x => Guid.NewGuid())
                                   .Select(x => new
                                   {
                                       x.NoiDung,
                                       x.LaDapAnDung,
                                       DuocChon = x.MaDapAn == ct.MaDapAnChon
                                   }).ToList()
                           }).ToList();

            // =====================================
            // TÍNH SỐ CÂU ĐÚNG 
            // =====================================
            int tongSoCau = chiTiet.Count;
            int soCauDung = chiTiet.Count(x => x.DungSai == true);

            // =====================================
            //TRUYỀN VIEW
            // =====================================
            ViewBag.HocSinh = hocSinh;
            ViewBag.LuotThi = luotThi;
            ViewBag.ChiTiet = chiTiet;
            ViewBag.SoCauDung = soCauDung;
            ViewBag.TongSoCau = tongSoCau;
            ViewBag.Avatar = hocSinh?.Avatar;
            ViewBag.Diem = luotThi.Diem;

            return View();
        }
        public IActionResult TatCaHoatDong(DateTime? tuNgay, DateTime? denNgay, int page = 1)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monIds = GetDanhSachMonCuaGiaoVien(maGV);

            int pageSize = 8;

            var query = (from dt in _context.DotThi
                         join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                         join mh in _context.MonHoc on d.MaMonHoc equals mh.MaMonHoc
                         where monIds.Contains(mh.MaMonHoc)
                         select new
                         {
                             dt.MaDotThi,
                             dt.TenDotThi,
                             TenMonHoc = mh.TenMonHoc,
                             dt.ThoiGianBatDau,
                             dt.ThoiGianKetThuc,
                             TrangThaiText =
                                dt.ThoiGianBatDau > DateTime.Now ? "Sắp diễn ra" :
                                dt.ThoiGianKetThuc < DateTime.Now ? "Đã kết thúc" :
                                "Đang mở"
                         });

            // LỌC NGÀY
            if (tuNgay.HasValue)
                query = query.Where(x => x.ThoiGianBatDau >= tuNgay.Value);

            if (denNgay.HasValue)
                query = query.Where(x => x.ThoiGianKetThuc <= denNgay.Value);

            int total = query.Count();

            var data = query
                .OrderByDescending(x => x.ThoiGianBatDau)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.Page = page;
            ViewBag.TotalPage = (int)Math.Ceiling((double)total / pageSize);

            ViewBag.TuNgay = tuNgay;
            ViewBag.DenNgay = denNgay;

            return View(data);
        }
        [HttpPost]
        public IActionResult ImportExcel(IFormFile file, int khoi)
        {
            var maGV = GetMaGiaoVien();

            if (file == null || file.Length == 0)
            {
                TempData["error"] = "Chưa chọn file!";
                return RedirectToAction("ImportCauHoi");
            }

            int demThem = 0;
            int demTrung = 0;

            string normalize(string s)
            {
                return s.Trim().ToLower().Replace("  ", " ");
            }

            using var stream = new MemoryStream();
            file.CopyTo(stream);

            using var package = new OfficeOpenXml.ExcelPackage(stream);
            var sheet = package.Workbook.Worksheets[0];

            int rowCount = sheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(sheet.Cells[row, 1].Text))
                        continue;

                    // ===== CHUYÊN ĐỀ =====
                    var tenChuyenDe = sheet.Cells[row, 8].Text.Trim();
                    var ten = tenChuyenDe.ToLower().Trim();

                    var chuyenDe = _context.ChuyenDe
                        .AsEnumerable()
                        .FirstOrDefault(x => x.TenChuyenDe.Trim().ToLower().Contains(ten));

                    if (chuyenDe == null) continue;

                    // ===== NỘI DUNG =====
                    var noiDung = sheet.Cells[row, 1].Text.Trim();
                    if (string.IsNullOrEmpty(noiDung)) continue;

                    // CHECK TRÙNG
                    bool daTonTai = _context.CauHoi
                        .AsEnumerable()
                        .Any(x => normalize(x.NoiDung) == normalize(noiDung)
                               && x.MaChuyenDe == chuyenDe.MaChuyenDe);

                    if (daTonTai)
                    {
                        demTrung++; 
                        continue;
                    }

                    // ===== ĐÁP ÁN =====
                    var dapAns = new[]
                    {
                sheet.Cells[row,2].Text.Trim(),
                sheet.Cells[row,3].Text.Trim(),
                sheet.Cells[row,4].Text.Trim(),
                sheet.Cells[row,5].Text.Trim()
            };

                    int soDapAn = dapAns.Count(x => !string.IsNullOrWhiteSpace(x));
                    if (soDapAn < 2) continue;

                    // ===== ĐÁP ÁN ĐÚNG =====
                    string dapAnDungText = sheet.Cells[row, 6].Text.Trim().ToUpper();
                    if (string.IsNullOrEmpty(dapAnDungText)) continue;

                    int dung = dapAnDungText[0] - 'A';
                    if (dung < 0 || dung > 3) continue;

                    // ===== MỨC ĐỘ =====
                    int mucDo = 1;
                    int.TryParse(sheet.Cells[row, 7].Text, out mucDo);

                    // ===== LƯU CÂU HỎI =====
                    var cauHoi = new CauHoi
                    {
                        NoiDung = noiDung,
                        MaChuyenDe = chuyenDe.MaChuyenDe,
                        MucDo = mucDo,
                        TrangThai = true,
                        NguoiTao = maGV.Value,
                        NgayTao = DateTime.Now,
                        Khoi = khoi
                    };

                    _context.CauHoi.Add(cauHoi);
                    _context.SaveChanges();

                    // ===== LƯU ĐÁP ÁN =====
                    for (int i = 0; i < 4; i++)
                    {
                        if (string.IsNullOrWhiteSpace(dapAns[i])) continue;

                        _context.DapAn.Add(new DapAn
                        {
                            MaCauHoi = cauHoi.MaCauHoi,
                            NoiDung = dapAns[i],
                            LaDapAnDung = (i == dung)
                        });
                    }

                    _context.SaveChanges();

                    demThem++; 
                }
                catch
                {
                    continue;
                }
            }

            TempData["success"] = $"Thêm {demThem} câu, bỏ qua {demTrung} câu trùng 🎉";

            return RedirectToAction("ImportCauHoi");
        }
        [HttpPost]
        public IActionResult ImportWord(IFormFile file, int khoi)
        {
            var maGV = GetMaGiaoVien();

            if (file == null || file.Length == 0)
            {
                TempData["error"] = "Chưa chọn file!";
                return RedirectToAction("ImportCauHoi");
            }

            int count = 0;

            string normalize(string s)
            {
                return s.Trim().ToLower().Replace("  ", " ");
            }

            string text = "";

            using (var doc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(file.OpenReadStream(), false))
            {
                var body = doc.MainDocumentPart.Document.Body;

                foreach (var para in body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>())
                {
                    text += para.InnerText + "\n";
                }
            }

            text = text.Replace("===CÂU HỎI===", "\n===CÂU HỎI===\n");

            var blocks = text
                .Split("===CÂU HỎI===", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToList();

            foreach (var block in blocks)
            {
                try
                {
                    var lines = block
                        .Split('\n')
                        .Select(x => x.Trim())
                        .Where(x => !string.IsNullOrEmpty(x))
                        .ToList();

                    if (lines.Count < 3) continue;

                    // ===== CHUYÊN ĐỀ =====
                    var tenChuyenDe = lines
                        .FirstOrDefault(x => x.ToLower().StartsWith("chuyên đề"))
                        ?.Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(tenChuyenDe)) continue;

                    var chuyenDe = _context.ChuyenDe
                        .AsEnumerable()
                        .FirstOrDefault(x => normalize(x.TenChuyenDe) == normalize(tenChuyenDe));

                    if (chuyenDe == null) continue;

                    // ===== NỘI DUNG =====
                    var noiDung = lines
                        .FirstOrDefault(x => x.ToLower().StartsWith("nội dung"))
                        ?.Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(noiDung)) continue;

                    // CHECK TRÙNG
                    bool daTonTai = _context.CauHoi
                        .AsEnumerable()
                        .Any(x => normalize(x.NoiDung) == normalize(noiDung)
                               && x.MaChuyenDe == chuyenDe.MaChuyenDe);

                    if (daTonTai) continue;

                    // ===== ĐÁP ÁN =====
                    var dapAns = new string[4];

                    dapAns[0] = lines.FirstOrDefault(x => x.StartsWith("A."))?.Substring(2).Trim();
                    dapAns[1] = lines.FirstOrDefault(x => x.StartsWith("B."))?.Substring(2).Trim();
                    dapAns[2] = lines.FirstOrDefault(x => x.StartsWith("C."))?.Substring(2).Trim();
                    dapAns[3] = lines.FirstOrDefault(x => x.StartsWith("D."))?.Substring(2).Trim();

                    if (dapAns.Count(x => !string.IsNullOrWhiteSpace(x)) < 2) continue;

                    // ===== ĐÁP ÁN ĐÚNG =====
                    var dapAnDungText = lines
                        .FirstOrDefault(x => x.ToLower().StartsWith("đáp án"))
                        ?.Split(':').Last().Trim().ToUpper();

                    if (string.IsNullOrEmpty(dapAnDungText)) continue;

                    int dung = dapAnDungText[0] - 'A';
                    if (dung < 0 || dung > 3) continue;

                    // ===== LƯU =====
                    var cauHoi = new CauHoi
                    {
                        NoiDung = noiDung,
                        TrangThai = true,
                        NguoiTao = maGV.Value,
                        MucDo = 1,
                        MaChuyenDe = chuyenDe.MaChuyenDe,
                        NgayTao = DateTime.Now,
                        Khoi = khoi
                    };

                    _context.CauHoi.Add(cauHoi);
                    _context.SaveChanges();

                    for (int i = 0; i < 4; i++)
                    {
                        if (string.IsNullOrWhiteSpace(dapAns[i])) continue;

                        _context.DapAn.Add(new DapAn
                        {
                            MaCauHoi = cauHoi.MaCauHoi,
                            NoiDung = dapAns[i],
                            LaDapAnDung = (i == dung)
                        });
                    }

                    _context.SaveChanges();

                    count++;
                }
                catch
                {
                    continue;
                }
            }

            TempData["success"] = $"Import thành công {count} câu 🎉";
            return RedirectToAction("ImportCauHoi");
        }
        public IActionResult ImportCauHoi()
        {
            return View();
        }

        public IActionResult ImportDeThi()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            // CHECK giáo viên đại diện
            ViewBag.LaDaiDien = _context.PhanCongGiangDays
                .Any(x => x.MaGiaoVien == maGV && x.LaDaiDien == true);

            // load môn
            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .ToList();

            return View();
        }


        [HttpPost]
        public IActionResult ImportDeThi(
       string tenDeThi,
       int? maMonHoc,
       int khoi,
       string? loaiDe,
       int? thoiGianLamBai,
       IFormFile file)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien();
            if (maGV == null)
            {
                TempData["error"] = "Không xác định được giáo viên!";
                return RedirectToAction("ImportDeThi");
            }

            if (file == null || file.Length == 0)
            {
                TempData["error"] = "Chưa chọn file!";
                return RedirectToAction("ImportDeThi");
            }

            if (string.IsNullOrWhiteSpace(tenDeThi))
            {
                TempData["error"] = "Tên đề thi không được để trống!";
                return RedirectToAction("ImportDeThi");
            }

            if (maMonHoc == null)
            {
                TempData["error"] = "Bạn chưa chọn môn học!";
                return RedirectToAction("ImportDeThi");
            }

            // ===== LOẠI ĐỀ =====
            loaiDe = string.IsNullOrWhiteSpace(loaiDe) ? "Rieng" : loaiDe.Trim();

            if (loaiDe == "Chung")
            {
                bool laDaiDien = _context.PhanCongGiangDays
                    .Any(x => x.MaGiaoVien == maGV.Value
                           && x.MaMon == maMonHoc.Value
                           && x.LaDaiDien);

                if (!laDaiDien)
                {
                    TempData["error"] = "Chỉ giáo viên đại diện mới được tạo đề chung!";
                    return RedirectToAction("ImportDeThi");
                }
            }

            thoiGianLamBai = (thoiGianLamBai == null || thoiGianLamBai <= 0) ? 15 : thoiGianLamBai;

            using var stream = new MemoryStream();
            file.CopyTo(stream);
            stream.Position = 0;

            using var package = new OfficeOpenXml.ExcelPackage(stream);
            var sheet = package.Workbook.Worksheets[0];

            if (sheet.Dimension == null)
            {
                TempData["error"] = "File Excel rỗng!";
                return RedirectToAction("ImportDeThi");
            }

            // ===== TẠO ĐỀ =====
            var deThi = new DeThi
            {
                TenDeThi = tenDeThi.Trim(),
                TrangThai = true,
                NguoiTao = maGV.Value,
                MaMonHoc = maMonHoc.Value,
                ThoiGianLamBai = thoiGianLamBai.Value,
                Khoi = khoi,
                LoaiDe = loaiDe
            };

            _context.DeThi.Add(deThi);
            _context.SaveChanges();

            int count = 0;
            int loi = 0;

            for (int row = 2; row <= sheet.Dimension.Rows; row++)
            {
                try
                {
                    var noiDung = sheet.Cells[row, 1].Text.Trim();
                    if (string.IsNullOrWhiteSpace(noiDung)) continue;

                    var dapAns = new[]
                    {
                sheet.Cells[row,2].Text.Trim(),
                sheet.Cells[row,3].Text.Trim(),
                sheet.Cells[row,4].Text.Trim(),
                sheet.Cells[row,5].Text.Trim()
            };

                    string dapAnDungText = sheet.Cells[row, 6].Text.Trim().ToUpper();

                    if (string.IsNullOrWhiteSpace(dapAnDungText))
                    {
                        loi++; continue;
                    }

                    int dung = dapAnDungText[0] - 'A';
                    if (dung < 0 || dung > 3)
                    {
                        loi++; continue;
                    }

                    // CHO PHÉP TRỐNG NHƯNG PHẢI CÓ ÍT NHẤT 1 ĐÁP ÁN
                    if (dapAns.All(x => string.IsNullOrWhiteSpace(x)))
                    {
                        loi++; continue;
                    }

                    // ĐÁP ÁN ĐÚNG KHÔNG ĐƯỢC TRỐNG
                    if (string.IsNullOrWhiteSpace(dapAns[dung]))
                    {
                        loi++; continue;
                    }

                    // ===== CHUYÊN ĐỀ =====
                    var tenChuyenDe = sheet.Cells[row, 7].Text.Trim().ToLower();

                    var chuyenDe = _context.ChuyenDe
                        .FirstOrDefault(x =>
                            x.MaMonHoc == maMonHoc.Value &&
                            x.Khoi == khoi &&
                            x.TenChuyenDe.ToLower().Contains(tenChuyenDe)
                        );

                    if (chuyenDe == null)
                    {
                        loi++; continue;
                    }

                    // ===== MỨC ĐỘ =====
                    var mucDoText = sheet.Cells[row, 8].Text.Trim().ToLower();

                    int mucDo = mucDoText switch
                    {
                        "1" or "nhận biết" => 1,
                        "2" or "thông hiểu" => 2,
                        "3" or "vận dụng" => 3,
                        _ => 1
                    };

                    // ===== TẠO CÂU HỎI =====
                    var cauHoi = new CauHoi
                    {
                        NoiDung = noiDung,
                        MaChuyenDe = chuyenDe.MaChuyenDe,
                        MucDo = mucDo,
                        TrangThai = true,
                        NguoiTao = maGV.Value,
                        NgayTao = DateTime.Now
                    };

                    _context.CauHoi.Add(cauHoi);
                    _context.SaveChanges();

                    for (int i = 0; i < 4; i++)
                    {
                        if (string.IsNullOrWhiteSpace(dapAns[i])) continue;

                        _context.DapAn.Add(new DapAn
                        {
                            MaCauHoi = cauHoi.MaCauHoi,
                            NoiDung = dapAns[i],
                            LaDapAnDung = (i == dung)
                        });
                    }

                    _context.SaveChanges();

                    // ===== GẮN VÀO ĐỀ =====
                    _context.ChiTietDeThi.Add(new ChiTietDeThi
                    {
                        MaDeThi = deThi.MaDeThi,
                        MaCauHoi = cauHoi.MaCauHoi
                    });

                    count++;
                }
                catch (Exception ex)
                {
                    loi++;
                    Console.WriteLine($"Lỗi dòng {row}: {ex.Message}");
                }
            }

            _context.SaveChanges();

            TempData["success"] = $"✔ Import {count} câu | ❌ lỗi {loi} dòng";
            return RedirectToAction("DeThi");
        }
        public IActionResult InDeThi(int id)
        {
            return LoadDeThi(id, false);
        }

        public IActionResult InDeThiCoDapAn(int id)
        {
            return LoadDeThi(id, true);
        }

        // ===============================
        // HÀM DÙNG CHUNG
        // ===============================
        private IActionResult LoadDeThi(int id, bool showAnswer)
        {
            var deThi = _context.DeThi
                .Include(x => x.MonHoc)
                .FirstOrDefault(x => x.MaDeThi == id);

            if (deThi == null) return NotFound();

            var cauHoi = (from ct in _context.ChiTietDeThi
                          join ch in _context.CauHoi on ct.MaCauHoi equals ch.MaCauHoi
                          where ct.MaDeThi == id
                          orderby ch.MaCauHoi
                          select new
                          {
                              NoiDung = ch.NoiDung,
                              DapAns = _context.DapAn
                                  .Where(x => x.MaCauHoi == ch.MaCauHoi)
                                  .OrderBy(x => x.MaDapAn)
                                  .ToList()
                          }).ToList();

            // truyền thông tin đề
            ViewBag.TenDe = deThi.TenDeThi;
            ViewBag.MonHoc = deThi.MonHoc?.TenMonHoc;
            ViewBag.ThoiGian = deThi.ThoiGianLamBai;
            ViewBag.MaDe = deThi.MaDeThi.ToString("D3");

            ViewBag.ShowAnswer = showAnswer;

            return View("InDeThi", cauHoi);
        }
        // ===============================
        // ĐỢT THI - SỬA
        // ===============================


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaDotThi(DotThi model)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            if (model == null)
                return NotFound();

            var maGV = GetMaGiaoVien()!.Value;

            var dotThi = _context.DotThi
                .FirstOrDefault(x => x.MaDotThi == model.MaDotThi && x.NguoiTao == maGV);

            if (dotThi == null)
                return NotFound();

            // không cho sửa nếu đã bắt đầu
            if (DateTime.Now >= dotThi.ThoiGianBatDau)
            {
                TempData["error"] = "Đợt thi đã bắt đầu, không thể sửa!";
                return RedirectToAction("ChiTietDotThi", new { id = model.MaDotThi });
            }

            // check thời gian
            if (model.ThoiGianBatDau >= model.ThoiGianKetThuc)
            {
                TempData["error"] = "Thời gian không hợp lệ!";
                return RedirectToAction("ChiTietDotThi", new { id = model.MaDotThi });
            }

            // update
            dotThi.TenDotThi = model.TenDotThi;
            dotThi.ThoiGianBatDau = model.ThoiGianBatDau;
            dotThi.ThoiGianKetThuc = model.ThoiGianKetThuc;
            _context.SaveChanges();

            TempData["success"] = "Cập nhật đợt thi thành công 🎉";
            return RedirectToAction("ChiTietDotThi", new { id = model.MaDotThi });
        }
        // ===============================
        // ĐỢT THI - XÓA
        // ===============================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult XoaDotThi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var dotThi = _context.DotThi
                .FirstOrDefault(x => x.MaDotThi == id && x.NguoiTao == maGV);

            if (dotThi == null)
                return NotFound();

            // Không cho xóa nếu đã bắt đầu
            if (DateTime.Now >= dotThi.ThoiGianBatDau)
            {
                TempData["error"] = "Đợt thi đã bắt đầu hoặc đã kết thúc!";
                return RedirectToAction("DotThi");
            }

            // Không cho xóa nếu đã có bài làm
            if (_context.LuotThi.Any(x => x.MaDotThi == id))
            {
                TempData["error"] = "Đã có học sinh làm bài, không thể xóa!";
                return RedirectToAction("DotThi");
            }

            // XÓA DANH SÁCH DỰ THI 
            var ds = _context.DanhSachDuThi.Where(x => x.MaDotThi == id);
            _context.DanhSachDuThi.RemoveRange(ds);

            // XÓA LƯỢT THI 
            var lt = _context.LuotThi.Where(x => x.MaDotThi == id);
            _context.LuotThi.RemoveRange(lt);

            // XÓA ĐỢT THI
            _context.DotThi.Remove(dotThi);
            _context.SaveChanges();

            TempData["success"] = "Đã xóa đợt thi thành công 👍";
            return RedirectToAction("DotThi");
        }
        public IActionResult XuatExcelChiTietDotThi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            var data = (from ds in _context.DanhSachDuThi
                        join hs in _context.HocSinh on ds.MaHocSinh equals hs.MaHocSinh
                        join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                        join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung
                        join lop in _context.Lop on hs.MaLop equals lop.MaLop

                        join lt in _context.LuotThi
                        on new { ds.MaDotThi, hs.MaHocSinh }
                        equals new { lt.MaDotThi, lt.MaHocSinh }
                        into gj
                        from lt in gj.DefaultIfEmpty()

                        where ds.MaDotThi == id

                        select new
                        {
                            hs.SoBaoDanh,
                            hoso.HoTen,
                            lop.TenLop,
                            ThoiDiemVao = lt != null ? lt.ThoiDiemBatDau : (DateTime?)null,
                            ThoiDiemNop = lt != null ? lt.ThoiDiemNopBai : (DateTime?)null,
                            Diem = lt != null ? lt.Diem : (double?)null
                        }).ToList();

            using (var package = new OfficeOpenXml.ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("ChiTietDotThi");

                // HEADER
                ws.Cells[1, 1].Value = "SBD";
                ws.Cells[1, 2].Value = "Họ tên";
                ws.Cells[1, 3].Value = "Lớp";
                ws.Cells[1, 4].Value = "Thời điểm vào";
                ws.Cells[1, 5].Value = "Thời điểm nộp";
                ws.Cells[1, 6].Value = "Điểm";

                int row = 2;

                foreach (var item in data)
                {
                    ws.Cells[row, 1].Value = item.SoBaoDanh;
                    ws.Cells[row, 2].Value = item.HoTen;
                    ws.Cells[row, 3].Value = item.TenLop;

                    // FORMAT NGÀY CHUẨN
                    ws.Cells[row, 4].Value = item.ThoiDiemVao;
                    ws.Cells[row, 4].Style.Numberformat.Format = "dd/MM/yyyy HH:mm";

                    ws.Cells[row, 5].Value = item.ThoiDiemNop;
                    ws.Cells[row, 5].Style.Numberformat.Format = "dd/MM/yyyy HH:mm";

                    ws.Cells[row, 6].Value = item.Diem;

                    row++;
                }

                ws.Cells.AutoFitColumns();

                var file = package.GetAsByteArray();

                return File(file,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    $"ChiTietDotThi_{id}.xlsx");
            }

        }
        public IActionResult TaoDeThiTuDong()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            //danh sách môn
            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .ToList();

            // truyền quyền đại diện theo môn
            var laDaiDienDict = new Dictionary<string, bool>();

            foreach (var mon in monGV)
            {
                bool isDaiDien = _context.PhanCongGiangDays.Any(x =>
                    x.MaMon == mon &&
                    x.MaGiaoVien == maGV &&
                    x.LaDaiDien == true
                );

                laDaiDienDict[mon.ToString()] = isDaiDien;
            }

            ViewBag.LaDaiDienTheoMon = laDaiDienDict;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TaoDeThiTuDong(
              int maMonHoc,
              int khoi,
              int soCau,
              int thoiGian,
              string? tenDe,
              string? loaiDe,
              string? mucDoDe, 
              bool tronCauHoi = true,
              bool tronDapAn = true
                 )
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            if (!monGV.Contains(maMonHoc))
            {
                TempData["error"] = "Bạn không có quyền tạo đề cho môn này!";
                return RedirectToAction("TaoDeThiTuDong");
            }

            if (soCau <= 0 || thoiGian <= 0)
            {
                TempData["error"] = "Dữ liệu không hợp lệ!";
                return RedirectToAction("TaoDeThiTuDong");
            }

            List<CauHoi> randomCau;

            // KHÔNG CHỌN MỨC ĐỘ → RANDOM
            if (string.IsNullOrEmpty(mucDoDe))
            {
                var cauHoi = (from ch in _context.CauHoi
                              join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                              where cd.MaMonHoc == maMonHoc
                                    && cd.Khoi == khoi
                                    && ch.TrangThai
                              select ch).ToList();

                if (cauHoi.Count < soCau)
                {
                    TempData["error"] = "Không đủ câu hỏi!";
                    return RedirectToAction("TaoDeThiTuDong");
                }

                randomCau = cauHoi
                    .OrderBy(x => Guid.NewGuid())
                    .Take(soCau)
                    .ToList();
            }
            else
            {
                // CÓ CHỌN → CHIA ĐỘ KHÓ     
                int soCauDe = 0, soCauTB = 0, soCauKho = 0;

                switch (mucDoDe)
                {
                    case "de":
                        soCauDe = (int)(soCau * 0.7);
                        soCauTB = (int)(soCau * 0.2);
                        soCauKho = soCau - soCauDe - soCauTB;
                        break;

                    case "tb":
                        soCauDe = (int)(soCau * 0.4);
                        soCauTB = (int)(soCau * 0.4);
                        soCauKho = soCau - soCauDe - soCauTB;
                        break;

                    case "kho":
                        soCauDe = (int)(soCau * 0.2);
                        soCauTB = (int)(soCau * 0.2);
                        soCauKho = soCau - soCauDe - soCauTB;
                        break;
                }

                var cauDe = LayCauHoiTheoMucDo(maMonHoc, khoi, 1, soCauDe);
                var cauTB = LayCauHoiTheoMucDo(maMonHoc, khoi, 2, soCauTB);
                var cauKho = LayCauHoiTheoMucDo(maMonHoc, khoi, 3, soCauKho);

                if (cauDe.Count < soCauDe || cauTB.Count < soCauTB || cauKho.Count < soCauKho)
                {
                    TempData["error"] = "Không đủ câu hỏi theo độ khó!";
                    return RedirectToAction("TaoDeThiTuDong");
                }

                randomCau = cauDe.Concat(cauTB).Concat(cauKho).ToList();
            }

            // trộn nếu bật
            if (tronCauHoi)
            {
                randomCau = randomCau.OrderBy(x => Guid.NewGuid()).ToList();
            }

            if (string.IsNullOrWhiteSpace(tenDe))
            {
                tenDe = $"Đề tự động - {DateTime.Now:ddMMyyyyHHmm}";
            }

            string loai = loaiDe == "Chung" ? "Chung" : "Rieng";

            // check giáo viên đại diện
            if (loai == "Chung")
            {
                if (!_context.PhanCongGiangDays.Any(x =>
                    x.MaMon == maMonHoc &&
                    x.MaGiaoVien == maGV &&
                    x.LaDaiDien))
                {
                    TempData["error"] = "Chỉ giáo viên đại diện mới được tạo đề chung!";
                    return RedirectToAction("TaoDeThiTuDong");
                }
            }

            var de = new DeThi
            {
                TenDeThi = tenDe,
                MaMonHoc = maMonHoc,
                Khoi = khoi,
                ThoiGianLamBai = thoiGian,
                TronCauHoi = tronCauHoi,
                TronDapAn = tronDapAn,
                TrangThai = true,
                NguoiTao = maGV,
                LoaiDe = loai
            };

            _context.DeThi.Add(de);
            _context.SaveChanges();

            foreach (var ch in randomCau)
            {
                _context.ChiTietDeThi.Add(new ChiTietDeThi
                {
                    MaDeThi = de.MaDeThi,
                    MaCauHoi = ch.MaCauHoi
                });
            }

            _context.SaveChanges();

            TempData["success"] = "Tạo đề tự động thành công ⚡";

            return RedirectToAction("ChiTietDeThi", new { id = de.MaDeThi });
        }

        private List<CauHoi> LayCauHoiTheoMucDo(int maMon, int khoi, int mucDo, int soLuong)
        {
            return (from ch in _context.CauHoi
                    join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                    where cd.MaMonHoc == maMon
                          && cd.Khoi == khoi
                          && ch.MucDo == mucDo
                          && ch.TrangThai
                    orderby Guid.NewGuid()
                    select ch)
                    .Take(soLuong)
                    .ToList();
        }
        [HttpGet]
        public IActionResult PreviewDeThi(int soCau, int maMonHoc, int khoi, string? mucDoDe)
        {
            if (soCau <= 0)
                return BadRequest("Số câu không hợp lệ");

            var maGV = GetMaGiaoVien();
            if (maGV == null)
                return Unauthorized();

            var monGV = GetDanhSachMonCuaGiaoVien(maGV.Value);
            if (!monGV.Contains(maMonHoc))
                return BadRequest("Không có quyền");

            var query = from ch in _context.CauHoi
                        join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                        where cd.MaMonHoc == maMonHoc
                              && cd.Khoi == khoi
                              && ch.TrangThai == true
                        select ch;

            int de = 0, trung = 0, kho = 0;

            if (string.IsNullOrEmpty(mucDoDe))
            {
                de = (int)Math.Round(soCau * 0.33);
                trung = (int)Math.Round(soCau * 0.33);
            }
            else if (mucDoDe == "de")
            {
                de = (int)Math.Round(soCau * 0.7);
                trung = (int)Math.Round(soCau * 0.2);
            }
            else if (mucDoDe == "tb")
            {
                de = (int)Math.Round(soCau * 0.4);
                trung = (int)Math.Round(soCau * 0.4);
            }
            else if (mucDoDe == "kho")
            {
                de = (int)Math.Round(soCau * 0.2);
                trung = (int)Math.Round(soCau * 0.2);
            }

            kho = soCau - de - trung;

            var cauDe = query.Where(x => x.MucDo == 1)
                .OrderBy(x => Guid.NewGuid()).Take(de).ToList();

            var cauTrung = query.Where(x => x.MucDo == 2)
                .OrderBy(x => Guid.NewGuid()).Take(trung).ToList();

            var cauKho = query.Where(x => x.MucDo == 3)
                .OrderBy(x => Guid.NewGuid()).Take(kho).ToList();

            // RANDOM FINAL 
            var deThi = cauDe.Concat(cauTrung).Concat(cauKho)
                .OrderBy(x => Guid.NewGuid())
                .ToList();

            var result = deThi.Select(ch => new
            {
                maCauHoi = ch.MaCauHoi,
                noiDung = ch.NoiDung,
                mucDo = ch.MucDo,
                dapAns = _context.DapAn
                    .Where(x => x.MaCauHoi == ch.MaCauHoi)
                    .OrderBy(x => x.MaDapAn)
                    .Select(x => new
                    {
                        noiDung = x.NoiDung,
                        dung = x.LaDapAnDung
                    }).ToList()
            });

            return Json(new
            {
                tong = deThi.Count,
                de = deThi.Count(x => x.MucDo == 1),
                trung = deThi.Count(x => x.MucDo == 2),
                kho = deThi.Count(x => x.MucDo == 3),
                cauHoi = result
            });
        }
        [HttpPost]
        public IActionResult TaoDeTuPreview([FromBody] dynamic data)
        {
            var json = (System.Text.Json.JsonElement)data;

            var dsCauHoi = json.GetProperty("dsCauHoi")
                               .EnumerateArray()
                               .Select(x => x.GetInt32())
                               .ToList();

            int thoiGian = json.GetProperty("thoiGian").GetInt32();

            if (dsCauHoi == null || !dsCauHoi.Any())
                return BadRequest("Danh sách câu hỏi rỗng");

            if (thoiGian <= 0)
                return BadRequest("Phải nhập thời gian!");

            var maGV = GetMaGiaoVien();
            if (maGV == null)
                return Unauthorized();

            var cauDau = _context.CauHoi
                .Include(x => x.ChuyenDe)
                .ThenInclude(cd => cd.MonHoc)
                .FirstOrDefault(x => x.MaCauHoi == dsCauHoi.First());

            if (cauDau == null)
                return BadRequest("Không tìm thấy câu hỏi");

            //TÊN ĐỀ CHUẨN
            var de = new DeThi
            {
                TenDeThi = $"Đề {cauDau.ChuyenDe.MonHoc.TenMonHoc} - Khối {cauDau.ChuyenDe.Khoi} - {DateTime.Now:dd/MM/yyyy HH:mm}",
                NguoiTao = maGV.Value,
                TrangThai = true,
                MaMonHoc = cauDau.ChuyenDe.MaMonHoc,
                Khoi = cauDau.ChuyenDe.Khoi,
                LoaiDe = "Rieng",
                ThoiGianLamBai = thoiGian
            };

            _context.DeThi.Add(de);
            _context.SaveChanges();
        
            var chiTietList = dsCauHoi
                .Select((id, index) => new ChiTietDeThi
                {
                    MaDeThi = de.MaDeThi,
                    MaCauHoi = id,
                    ThuTu = index + 1
                }).ToList();

            _context.ChiTietDeThi.AddRange(chiTietList);
            _context.SaveChanges();

            return Ok(new
            {
                success = true,
                message = "Tạo đề thành công!",
                maDeThi = de.MaDeThi
            });
        }
    }
}