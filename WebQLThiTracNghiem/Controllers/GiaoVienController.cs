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

            // 👉 Nếu chưa có session thì tự lấy từ MaNguoiDung
            if (maGV == null)
            {
                var maNguoiDung = HttpContext.Session.GetInt32("MaNguoiDung");

                if (maNguoiDung != null)
                {
                    var gv = _context.GiaoVien
                        .FirstOrDefault(x => x.MaNguoiDung == maNguoiDung);

                    if (gv != null)
                    {
                        // 👉 set lại session cho lần sau
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

            // ❌ chưa login
            if (vaiTro == null)
            {
                return RedirectToAction("DangNhap", "Auth");
            }

            // ❌ không phải giáo viên
            if (vaiTro != 2)
            {
                return Content("Bạn không có quyền truy cập trang giáo viên");
            }

            // ❌ thiếu MaGiaoVien
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

        public IActionResult HocSinh(string? keyword, int? lopId)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var lopGV = GetDanhSachLopCuaGiaoVien(maGV);

            ViewData["Title"] = "Quản lý học sinh";

            var query = _context.HocSinh
                .Include(h => h.NguoiDung)
                    .ThenInclude(nd => nd.HoSoCaNhan)
                .Include(h => h.Lop)
                .Where(h => h.MaLop != null && lopGV.Contains(h.MaLop.Value))
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(h =>
                    h.NguoiDung.HoSoCaNhan.HoTen.Contains(keyword) ||
                    h.SoBaoDanh.Contains(keyword));
            }

            if (lopId != null)
            {
                query = query.Where(h => h.MaLop == lopId);
            }

            ViewBag.DanhSachLop = _context.Lop
                .Where(l => lopGV.Contains(l.MaLop))
                .ToList();

            ViewBag.Keyword = keyword;
            ViewBag.LopId = lopId;

            return View(query.OrderBy(h => h.Lop!.TenLop).ThenBy(h => h.SoBaoDanh).ToList());
        }

        // ===============================
        // CÂU HỎI - DANH SÁCH
        // ===============================

        public IActionResult CauHoi(string? keyword, int? monId, int? chuyenDeId, int? mucDo, bool? trangThai, string? loai)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            ViewBag.MaGV = maGV;
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
                            mh.TenMonHoc
                        };

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.NoiDung.Contains(keyword));
            }

            if (monId != null)
            {
                query = query.Where(x => x.MaMonHoc == monId);
            }

            if (chuyenDeId != null)
            {
                query = query.Where(x => x.MaChuyenDe == chuyenDeId);
            }

            if (mucDo != null)
            {
                query = query.Where(x => x.MucDo == mucDo);
            }

            if (trangThai != null)
            {
                query = query.Where(x => x.TrangThai == trangThai);
            }
            if (!string.IsNullOrEmpty(loai))
            {
                if (loai == "mine")
                {
                    query = query.Where(x => x.NguoiTao == maGV);
                }
                else if (loai == "other")
                {
                    query = query.Where(x => x.NguoiTao != maGV);
                }
            }

            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            ViewBag.ChuyenDe = _context.ChuyenDe
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenChuyenDe)
                .ToList();

            ViewBag.Keyword = keyword;
            ViewBag.MonId = monId;
            ViewBag.ChuyenDeId = chuyenDeId;
            ViewBag.MucDo = mucDo;
            ViewBag.TrangThai = trangThai;

            ViewBag.Loai = loai;

            return View(query
                .OrderByDescending(x => x.NgayTao)
                .ThenByDescending(x => x.MaCauHoi)
                .ToList());
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

            if (string.IsNullOrWhiteSpace(cauHoi.NoiDung))
            {
                ModelState.AddModelError("", "Nội dung câu hỏi không được để trống.");
            }

            if (dapAn == null || dapAn.Count < 4 || dapAn.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                ModelState.AddModelError("", "Bạn phải nhập đầy đủ 4 đáp án.");
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

            var chuyenDe = _context.ChuyenDe.FirstOrDefault(x => x.MaChuyenDe == cauHoi.MaChuyenDe);
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

            if (string.IsNullOrWhiteSpace(model.NoiDung))
            {
                ModelState.AddModelError("", "Nội dung câu hỏi không được để trống.");
            }

            if (dapAn == null || dapAn.Count < 4 || dapAn.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                ModelState.AddModelError("", "Bạn phải nhập đầy đủ 4 đáp án.");
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

        public IActionResult DeThi(string? keyword, int? monId)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Quản lý đề thi";

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

                            // 🔥 số câu
                            SoCau = _context.ChiTietDeThi.Count(x => x.MaDeThi == dt.MaDeThi),

                            // 🔥 đã dùng chưa (rất quan trọng)
                            DaSuDung = _context.DotThi.Any(x => x.MaDeThi == dt.MaDeThi),

                            // 🔥 người tạo
                            dt.NguoiTao
                        };

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.TenDeThi.Contains(keyword));
            }

            if (monId != null)
            {
                query = query.Where(x => x.MaMonHoc == monId);
            }

            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            ViewBag.Keyword = keyword;
            ViewBag.MonId = monId;

            return View(query.OrderByDescending(x => x.MaDeThi).ToList());
        }

        // ===============================
        // ĐỀ THI - TẠO
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

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TaoDeThi(DeThi deThi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            // BỎ validate navigation property vì form chỉ submit MaMonHoc
            ModelState.Remove("MonHoc");

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            if (!monGV.Contains(deThi.MaMonHoc))
            {
                ModelState.AddModelError("", "Môn học không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(deThi.TenDeThi))
            {
                ModelState.AddModelError("", "Tên đề thi không được để trống.");
            }

            if (deThi.ThoiGianLamBai <= 0)
            {
                ModelState.AddModelError("", "Thời gian làm bài phải lớn hơn 0.");
            }

            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Tạo đề thi";
                ViewBag.MonHoc = _context.MonHoc
                    .Where(x => monGV.Contains(x.MaMonHoc))
                    .OrderBy(x => x.TenMonHoc)
                    .ToList();

                return View(deThi);
            }

            deThi.TrangThai = true;

            _context.DeThi.Add(deThi);
            _context.SaveChanges();

            TempData["success"] = "Tạo đề thi thành công.";
            return RedirectToAction("ChiTietDeThi", new { id = deThi.MaDeThi });
        }
        // XÓA ĐỀ THI   
        [HttpPost]
        public IActionResult XoaDeThi(int id)
        {
            var de = _context.DeThi.Find(id);

            if (de != null)
            {
                // ❗ Không cho xóa nếu đã có đợt thi
                if (_context.DotThi.Any(x => x.MaDeThi == id))
                {
                    TempData["error"] = "Không thể xóa vì đề đã được sử dụng!";
                    return RedirectToAction("DeThi");
                }

                // ❗ Xóa luôn chi tiết đề
                var ct = _context.ChiTietDeThi.Where(x => x.MaDeThi == id);
                _context.ChiTietDeThi.RemoveRange(ct);

                _context.DeThi.Remove(de);
                _context.SaveChanges();
            }

            return RedirectToAction("DeThi");
        }
        // SỬA ĐỀ THI
       
        public IActionResult SuaDeThi(int id)
        {
            var de = _context.DeThi.Find(id);

            if (de == null)
            {
                return NotFound();
            }

            return View(de);
        }
        [HttpPost]
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

        // SAO CHÉP ĐỀ THI
        public IActionResult CopyDeThi(int id)
        {
            var de = _context.DeThi.Find(id);

            if (de == null)
            {
                return NotFound();
            }

            // 🔥 tạo đề mới
            var newDe = new DeThi
            {
                TenDeThi = de.TenDeThi + " (Copy)",
                MaMonHoc = de.MaMonHoc,
                ThoiGianLamBai = de.ThoiGianLamBai,
                TrangThai = false
            };

            _context.DeThi.Add(newDe);
            _context.SaveChanges();

            // 🔥 copy câu hỏi
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

            TempData["success"] = "Đã sao chép đề thành công!";

            return RedirectToAction("DeThi");
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

            var dsCauHoi = from ct in _context.ChiTietDeThi
                           join ch in _context.CauHoi on ct.MaCauHoi equals ch.MaCauHoi
                           join cd in _context.ChuyenDe on ch.MaChuyenDe equals cd.MaChuyenDe
                           where ct.MaDeThi == id
                           orderby ch.MaCauHoi
                           select new
                           {
                               ch.MaCauHoi,
                               ch.NoiDung,
                               cd.TenChuyenDe,
                               ch.MucDo
                           };

            ViewData["Title"] = "Chi tiết đề thi";
            ViewBag.DeThi = deThi;
            ViewBag.DanhSachCauHoi = dsCauHoi.ToList();

            return View();
        }

        // ===============================
        // ĐỀ THI - THÊM CÂU HỎI VÀO ĐỀ (GET)
        // ===============================

        public IActionResult ThemCauHoiVaoDe(int id, string? keyword, int? chuyenDeId, int? mucDo)
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
                        select new
                        {
                            ch.MaCauHoi,
                            ch.NoiDung,
                            cd.MaChuyenDe,
                            cd.TenChuyenDe,
                            ch.MucDo
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

            ViewData["Title"] = "Thêm câu hỏi vào đề";
            ViewBag.DeThi = deThi;
            ViewBag.Keyword = keyword;
            ViewBag.ChuyenDeId = chuyenDeId;
            ViewBag.MucDo = mucDo;
            ViewBag.ChuyenDe = _context.ChuyenDe
                .Where(x => x.MaMonHoc == deThi.MaMonHoc)
                .OrderBy(x => x.TenChuyenDe)
                .ToList();

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

        // ===============================
        // ĐỢT THI - DANH SÁCH
        // ===============================

        public IActionResult DotThi(string? keyword, string? trangThai)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Quản lý đợt thi";

            var query = from dt in _context.DotThi
                        join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                        join mh in _context.MonHoc on d.MaMonHoc equals mh.MaMonHoc
                        where monGV.Contains(mh.MaMonHoc)
                        select new
                        {
                            dt.MaDotThi,
                            dt.TenDotThi,
                            mh.TenMonHoc,
                            dt.ThoiGianBatDau,
                            dt.ThoiGianKetThuc,

                            // 🔥 TRẠNG THÁI CHUẨN
                            TrangThai =
                                DateTime.Now < dt.ThoiGianBatDau ? "SapDienRa" :
                                DateTime.Now > dt.ThoiGianKetThuc ? "DaKetThuc" :
                                "DangDienRa",

                            // 🔥 THỐNG KÊ
                            SoHocSinh = _context.DanhSachDuThi
                                .Count(x => x.MaDotThi == dt.MaDotThi),

                            SoDaThi = _context.LuotThi
                                .Count(x => x.MaDotThi == dt.MaDotThi),

                            // 🔥 LOGIC ACTION
                            CoTheSua = DateTime.Now < dt.ThoiGianBatDau,

                            CoTheXoa =
                                DateTime.Now < dt.ThoiGianBatDau &&
                                !_context.DanhSachDuThi.Any(x => x.MaDotThi == dt.MaDotThi),
                                LyDoKhoa =
                                    DateTime.Now >= dt.ThoiGianBatDau && DateTime.Now <= dt.ThoiGianKetThuc
                                        ? "Đợt thi đang diễn ra"
                                    : DateTime.Now > dt.ThoiGianKetThuc
                                        ? "Đợt thi đã kết thúc"
                                    : _context.DanhSachDuThi.Any(x => x.MaDotThi == dt.MaDotThi)
                                        ? "Đã có học sinh tham gia"
                                    : ""
                        };

            // 🔍 SEARCH
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.TenDotThi.Contains(keyword));
            }

            // 🔍 FILTER TRẠNG THÁI
            if (!string.IsNullOrEmpty(trangThai))
            {
                query = query.Where(x => x.TrangThai == trangThai);
            }

            ViewBag.Keyword = keyword;
            ViewBag.TrangThai = trangThai;

            return View(query
                .OrderByDescending(x => x.ThoiGianBatDau)
                .ToList());
        }
        // ===============================
        // ĐỢT THI - TẠO
        // ===============================

        public IActionResult TaoDotThi()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Tạo đợt thi";

            ViewBag.DeThi = _context.DeThi
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderByDescending(x => x.MaDeThi)
                .ToList();

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

            var deThiHopLe = _context.DeThi
                .Any(x => x.MaDeThi == dotThi.MaDeThi && monGV.Contains(x.MaMonHoc));

            if (!deThiHopLe)
            {
                TempData["error"] = "Đề thi không hợp lệ.";
                return RedirectToAction("TaoDotThi");
            }

            // 🔥 FIX QUAN TRỌNG Ở ĐÂY
            dotThi.SoLanThiToiDa = dotThi.SoLanThiToiDa > 0 ? dotThi.SoLanThiToiDa : 1;

            // (tuỳ chọn) mặc định mở
            dotThi.TrangThai = true;

            _context.DotThi.Add(dotThi);
            _context.SaveChanges();

            TempData["success"] = "Tạo đợt thi thành công.";
            return RedirectToAction("DotThi");
        }
        // ===============================
        // ĐỢT THI - CHI TIẾT
        // ===============================

        public IActionResult ChiTietDotThi(int id)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

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
                              dt.ThoiGianKetThuc
                          }).FirstOrDefault();

            if (dotThi == null)
            {
                return NotFound();
            }

            var danhSachDuThi = from ds in _context.DanhSachDuThi
                                join hs in _context.HocSinh on ds.MaHocSinh equals hs.MaHocSinh
                                join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                                join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung
                                join lop in _context.Lop on hs.MaLop equals lop.MaLop
                                where ds.MaDotThi == id
                                orderby lop.TenLop, hoso.HoTen
                                select new
                                {
                                    hs.MaHocSinh,
                                    hs.SoBaoDanh,
                                    hoso.HoTen,
                                    lop.TenLop
                                };

            ViewData["Title"] = "Chi tiết đợt thi";
            ViewBag.DotThi = dotThi;
            ViewBag.DanhSachDuThi = danhSachDuThi.ToList();

            return View();
        }
        //XÓA ĐỢT THI
        [HttpPost]
        public IActionResult XoaDotThi(int id)
        {
            var dot = _context.DotThi.Find(id);

            if (dot != null)
            {
                var now = DateTime.Now;

                // ❌ đang thi
                if (now >= dot.ThoiGianBatDau && now <= dot.ThoiGianKetThuc)
                {
                    TempData["error"] = "Đợt thi đang diễn ra, không thể xóa!";
                    return RedirectToAction("DotThi");
                }

                // ❌ đã thi xong
                if (now > dot.ThoiGianKetThuc)
                {
                    TempData["error"] = "Đợt thi đã kết thúc, không thể xóa!";
                    return RedirectToAction("DotThi");
                }

               
                // ❌ đã gán lớp / có học sinh
                if (_context.DanhSachDuThi.Any(x => x.MaDotThi == id))
                {
                    TempData["error"] = "Đã có học sinh tham gia, không thể xóa!";
                    return RedirectToAction("DotThi");
                }

                _context.DotThi.Remove(dot);
                _context.SaveChanges();

                TempData["success"] = "Xóa thành công!";
            }

            return RedirectToAction("DotThi");
        }
        // SỬA ĐỢT THI
        public IActionResult SuaDotThi(int id)
        {
            var dot = _context.DotThi.Find(id);

            if (dot == null) return NotFound();

            if (DateTime.Now >= dot.ThoiGianBatDau)
            {
                TempData["error"] = "Đợt thi đã bắt đầu, không thể sửa!";
                return RedirectToAction("DotThi");
            }

            return View(dot);
        }
        public class TrangThaiHelper
        {
            public static string GetTrangThai(DateTime batDau, DateTime ketThuc)
            {
                var now = DateTime.Now;

                if (now < batDau) return "SapDienRa";
                if (now > ketThuc) return "DaKetThuc";

                return "DangDienRa";
            }

            public static bool CoTheSua(DateTime batDau)
            {
                return DateTime.Now < batDau;
            }

            public static bool CoTheXoa(DateTime batDau, DateTime ketThuc)
            {
                var now = DateTime.Now;
                return now < batDau;
            }
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
                          select dt).FirstOrDefault();

            if (dotThi == null)
            {
                return NotFound();
            }

            ViewData["Title"] = "Gán lớp vào đợt thi";
            ViewBag.DotThi = dotThi;
            ViewBag.DanhSachLop = _context.Lop
                .Where(x => lopGV.Contains(x.MaLop))
                .OrderBy(x => x.TenLop)
                .ToList();

            return View();
        }

        // ===============================
        // ĐỢT THI - GÁN LỚP (POST)
        // ===============================

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
                          select dt).FirstOrDefault();

            if (dotThi == null)
            {
                return NotFound();
            }

            if (lopIds == null || !lopIds.Any())
            {
                TempData["error"] = "Bạn chưa chọn lớp nào.";
                return RedirectToAction("GanLopVaoDotThi", new { id });
            }
            if (DateTime.Now >= dotThi.ThoiGianBatDau)
            {
                TempData["error"] = "Đợt thi đã bắt đầu, không thể gán lớp!";
                return RedirectToAction("DotThi");
            }

            var lopHopLe = lopIds.Where(x => lopGV.Contains(x)).ToList();

            var hocSinhCanThem = _context.HocSinh
                .Where(x => x.MaLop != null && lopHopLe.Contains(x.MaLop.Value))
                .Select(x => new { x.MaHocSinh })
                .ToList();

            var daTonTai = _context.DanhSachDuThi
                .Where(x => x.MaDotThi == id)
                .Select(x => x.MaHocSinh)
                .ToList();

            foreach (var hs in hocSinhCanThem)
            {
                if (!daTonTai.Contains(hs.MaHocSinh))
                {
                    _context.DanhSachDuThi.Add(new DanhSachDuThi
                    {
                        MaDotThi = id,
                        MaHocSinh = hs.MaHocSinh,
                        DuocPhepThi = true,   // 🔥 QUAN TRỌNG
                        GhiChu = ""
                    });
                }
            }

            _context.SaveChanges();

            TempData["success"] = "Đã gán lớp vào đợt thi thành công.";
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
        // ===============================
        // THÔNG TIN CÁ NHÂN + ĐỔI MẬT KHẨU
        // ===============================

        public IActionResult ThongTinCaNhan()
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var gv = _context.GiaoVien
                .Include(x => x.NguoiDung)
                .ThenInclude(x => x.HoSoCaNhan)
                .FirstOrDefault(x => x.MaGiaoVien == maGV);

            return View(gv);
        }
        // Câp nhật thông tin cá nhân
        [HttpPost]
     
        public IActionResult CapNhatThongTin(HoSoCaNhan model)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var gv = _context.GiaoVien
                .Include(x => x.NguoiDung)
                .ThenInclude(x => x.HoSoCaNhan)
                .FirstOrDefault(x => x.MaGiaoVien == maGV);

            var hs = gv?.NguoiDung?.HoSoCaNhan;

            if (hs == null)
            {
                TempData["Error"] = "Không tìm thấy hồ sơ!";
                return RedirectToAction("ThongTinCaNhan");
            }

            // update
            hs.HoTen = model.HoTen;
            hs.NgaySinh = model.NgaySinh;
            hs.SoDienThoai = model.SoDienThoai;
            hs.DiaChi = model.DiaChi;

            _context.SaveChanges();

            TempData["Success"] = "Cập nhật thành công!";
            return RedirectToAction("ThongTinCaNhan");
        }

        /// Đổi mật khẩu
        [HttpPost]
        public IActionResult DoiMatKhau(string matKhauCu, string matKhauMoi)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            var gv = _context.GiaoVien
                .Include(x => x.NguoiDung)
                .FirstOrDefault(x => x.MaGiaoVien == maGV);

            var user = gv?.NguoiDung;

            if (user == null)
            {
                TempData["Error"] = "Không tìm thấy tài khoản!";
                return RedirectToAction("ThongTinCaNhan");
            }

            // ✅ CHECK MẬT KHẨU CŨ (THIẾU TRONG CODE CỦA BẠN)
            if (user.MatKhau != matKhauCu)
            {
                TempData["Error"] = "Mật khẩu cũ sai!";
                return RedirectToAction("ThongTinCaNhan");
            }

            if (string.IsNullOrEmpty(matKhauMoi) || matKhauMoi.Length < 6)
            {
                TempData["Error"] = "Mật khẩu phải >= 6 ký tự";
                return RedirectToAction("ThongTinCaNhan");
            }

            user.MatKhau = matKhauMoi;

            _context.SaveChanges();

            TempData["Success"] = "Đổi mật khẩu thành công!";
            return RedirectToAction("ThongTinCaNhan");
        }
        /// Ânh đại diện
        [HttpPost]
        public async Task<IActionResult> UploadAvatar(IFormFile file)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;

            if (file != null && file.Length > 0)
            {
                var fileName = "avatar_" + maGV + Path.GetExtension(file.FileName);

                var path = Path.Combine(Directory.GetCurrentDirectory(),
                                        "wwwroot/images",
                                        fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                var gv = _context.GiaoVien
                    .Include(x => x.NguoiDung)
                    .ThenInclude(x => x.HoSoCaNhan)
                    .FirstOrDefault(x => x.MaGiaoVien == maGV);

                var hs = gv?.NguoiDung?.HoSoCaNhan;

                if (hs != null)
                {
                    hs.AnhDaiDien = fileName;
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("ThongTinCaNhan");
        }
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThongTinCaNhan(string matKhauCu, string matKhauMoi)
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

            if (string.IsNullOrWhiteSpace(matKhauCu) || string.IsNullOrWhiteSpace(matKhauMoi))
            {
                ViewBag.Loi = "Vui lòng nhập đầy đủ mật khẩu cũ và mật khẩu mới.";
                return View(gv);
            }

            if (gv.NguoiDung.MatKhau != matKhauCu)
            {
                ViewBag.Loi = "Mật khẩu cũ không đúng.";
                return View(gv);
            }

            if (matKhauMoi.Length < 6)
            {
                ViewBag.Loi = "Mật khẩu mới phải có ít nhất 6 ký tự.";
                return View(gv);
            }

            gv.NguoiDung.MatKhau = matKhauMoi;
            _context.SaveChanges();

            ViewBag.ThongBao = "Đổi mật khẩu thành công.";
            return View(gv);
        }
        */
        // ===============================
        // THỐNG KÊ
        // ===============================

        public IActionResult ThongKe(string? keyword, int? monId, int? dotThiId, string? trangThai)
        {
            var auth = KiemTraDangNhap();
            if (auth != null) return auth;

            var maGV = GetMaGiaoVien()!.Value;
            var monGV = GetDanhSachMonCuaGiaoVien(maGV);

            ViewData["Title"] = "Thống kê";

            var query = from lt in _context.LuotThi
                        join dt in _context.DotThi on lt.MaDotThi equals dt.MaDotThi
                        join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                        join mh in _context.MonHoc on d.MaMonHoc equals mh.MaMonHoc
                        join hs in _context.HocSinh on lt.MaHocSinh equals hs.MaHocSinh
                        join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                        join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung
                        join lop in _context.Lop on hs.MaLop equals lop.MaLop
                        where monGV.Contains(mh.MaMonHoc)
                        select new
                        {
                            lt.MaLuotThi,
                            hoso.HoTen,
                            hs.SoBaoDanh,
                            lop.TenLop,
                            dt.MaDotThi,
                            dt.TenDotThi,
                            mh.MaMonHoc,
                            mh.TenMonHoc,
                            lt.ThoiDiemNopBai
                        };

            // 🔍 Tìm kiếm
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    x.HoTen.Contains(keyword) ||
                    x.SoBaoDanh.Contains(keyword) ||
                    x.TenDotThi.Contains(keyword));
            }

            // 🔍 Lọc môn
            if (monId != null)
            {
                query = query.Where(x => x.MaMonHoc == monId);
            }

            // 🔍 Lọc đợt thi
            if (dotThiId != null)
            {
                query = query.Where(x => x.MaDotThi == dotThiId);
            }

            // 🔥 LỌC TRẠNG THÁI (QUAN TRỌNG)
            if (!string.IsNullOrEmpty(trangThai))
            {
                if (trangThai == "danop")
                    query = query.Where(x => x.ThoiDiemNopBai != null);
                else if (trangThai == "chuanop")
                    query = query.Where(x => x.ThoiDiemNopBai == null);
            }

            // 📌 dropdown
            ViewBag.MonHoc = _context.MonHoc
                .Where(x => monGV.Contains(x.MaMonHoc))
                .OrderBy(x => x.TenMonHoc)
                .ToList();

            ViewBag.DotThi = (from dt in _context.DotThi
                              join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                              where monGV.Contains(d.MaMonHoc)
                              orderby dt.ThoiGianBatDau descending
                              select new
                              {
                                  dt.MaDotThi,
                                  dt.TenDotThi
                              }).ToList();

            // 📌 giữ trạng thái filter
            ViewBag.Keyword = keyword;
            ViewBag.MonId = monId;
            ViewBag.DotThiId = dotThiId;
            ViewBag.TrangThai = trangThai;




            // 🔥 THỐNG KÊ CHUẨN (THEO QUERY)
            ViewBag.TongLuotThi = query.Count();
            ViewBag.TongHocSinhDaThi = query.Select(x => x.SoBaoDanh).Distinct().Count();
            ViewBag.SoDaNop = query.Count(x => x.ThoiDiemNopBai != null);
            ViewBag.SoChuaNop = query.Count(x => x.ThoiDiemNopBai == null);
            // 📊 THỐNG KÊ BIỂU ĐỒ (ĐÃ NỘP / CHƯA NỘP)
            ViewBag.ChartDaNop = query.Count(x => x.ThoiDiemNopBai != null);
            ViewBag.ChartChuaNop = query.Count(x => x.ThoiDiemNopBai == null);

            // 📊 THỐNG KÊ THEO LỚP
            var thongKeTheoLop = query
                .GroupBy(x => x.TenLop)
                .Select(g => new
                {
                    Lop = g.Key,
                    SoLuong = g.Count()
                }).ToList();

            ViewBag.LabelLop = thongKeTheoLop.Select(x => x.Lop).ToList();
            ViewBag.DataLop = thongKeTheoLop.Select(x => x.SoLuong).ToList();

            // 📈 THỐNG KÊ THEO NGÀY (BẮT BUỘC THÊM)
            var theoNgay = query
                .Where(x => x.ThoiDiemNopBai != null)
                .AsEnumerable() // 🔥 QUAN TRỌNG
                .GroupBy(x => x.ThoiDiemNopBai.Value.Date)
                .Select(g => new
                {
                    Ngay = g.Key.ToString("dd/MM"),
                    SoLuong = g.Count()
                })
                .OrderBy(x => x.Ngay)
                .ToList();
            // 🏆 TOP HỌC SINH (ĐIỂM CAO)
            var topHocSinh = (from lt in _context.LuotThi
                              join hs in _context.HocSinh on lt.MaHocSinh equals hs.MaHocSinh
                              join nd in _context.NguoiDung on hs.MaNguoiDung equals nd.MaNguoiDung
                              join hoso in _context.HoSoCaNhan on nd.MaNguoiDung equals hoso.MaNguoiDung
                              join ct in _context.ChiTietBaiLam on lt.MaLuotThi equals ct.MaLuotThi
                              where lt.ThoiDiemNopBai != null
                              group ct by new { hoso.HoTen, hs.SoBaoDanh } into g
                              select new
                              {
                                  HoTen = g.Key.HoTen,
                                  SoBaoDanh = g.Key.SoBaoDanh,
                                  Diem = g.Sum(x => x.DiemCau)
                              })
                              .OrderByDescending(x => x.Diem)
                              .Take(5)
                              .ToList();

            ViewBag.TopHocSinh = topHocSinh;

            ViewBag.LabelNgay = theoNgay.Select(x => x.Ngay).ToList();
            ViewBag.DataNgay = theoNgay.Select(x => x.SoLuong).ToList();
            return View(query
                .OrderByDescending(x => x.ThoiDiemNopBai)
                .ToList());
        }
    }
}