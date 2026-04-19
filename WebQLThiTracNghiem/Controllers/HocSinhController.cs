using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebQLThiTracNghiem.Data;
using WebQLThiTracNghiem.Models;
using WebQLThiTracNghiem.Models.ViewModels;

namespace WebQLThiTracNghiem.Controllers
{
    public class HocSinhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HocSinhController(ApplicationDbContext context)
        {
            _context = context;
        }

        private bool DaDangNhap()
        {
            /*
            return HttpContext.Session.GetInt32("MaHocSinh") != null;
            */
            return HttpContext.Session.GetInt32("MaNguoiDung") != null;
        }

      

        [HttpGet]
        public IActionResult DoiMatKhau()
        {
            if (!DaDangNhap())
            {
                return RedirectToAction("DangNhap", "Home");
            }

            ViewBag.SoBaoDanh = HttpContext.Session.GetString("SoBaoDanh");
            ViewBag.TenDangNhap = HttpContext.Session.GetString("TenDangNhap");

            return View();
        }

        [HttpPost]
        public IActionResult DoiMatKhau(DoiMatKhauViewModel model)
        {
            if (!DaDangNhap())
            {
                return RedirectToAction("DangNhap", "Home");
            }

            ViewBag.SoBaoDanh = HttpContext.Session.GetString("SoBaoDanh");
            ViewBag.TenDangNhap = HttpContext.Session.GetString("TenDangNhap");

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            int? maNguoiDung = HttpContext.Session.GetInt32("MaNguoiDung");

            if (maNguoiDung == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            var nguoiDung = _context.NguoiDung.FirstOrDefault(nd => nd.MaNguoiDung == maNguoiDung.Value);

            if (nguoiDung == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            if (nguoiDung.MatKhau != model.MatKhauHienTai)
            {
                ViewBag.Loi = "Mật khẩu hiện tại không đúng";
                return View(model);
            }
            if (model.MatKhauMoi.Length < 6)
            {
                ViewBag.Loi = "Mật khẩu phải ít nhất 6 ký tự";
                return View(model);
            }
            nguoiDung.MatKhau = model.MatKhauMoi;
            _context.SaveChanges();

            ViewBag.ThanhCong = "Đổi mật khẩu thành công";
            ModelState.Clear();

            return View();
        }

        [HttpGet]
        public IActionResult BatDauThi()
        {
            if (!DaDangNhap())
                return RedirectToAction("DangNhap", "Home");

            // ✅ LẤY MaNguoiDung (chuẩn)
            int? maNguoiDung = HttpContext.Session.GetInt32("MaNguoiDung");

            if (maNguoiDung == null)
                return RedirectToAction("DangNhap", "Home");

            // ✅ LẤY HỌC SINH
            var hocSinh = _context.HocSinh
                .Include(x => x.Lop)
                .FirstOrDefault(x => x.MaNguoiDung == maNguoiDung.Value);

            if (hocSinh == null)
                return RedirectToAction("DangNhap", "Home");

            // ✅ LẤY HỒ SƠ (CÓ AVATAR)
            var hoSo = _context.HoSoCaNhan
                .FirstOrDefault(x => x.MaNguoiDung == maNguoiDung.Value);

            var now = DateTime.Now;

            var danhSachDotThi = (from ds in _context.DanhSachDuThi
                                  join d in _context.DotThi
                                      on ds.MaDotThi equals d.MaDotThi
                                  where ds.MaHocSinh == hocSinh.MaHocSinh
                                        && d.TrangThai
                                        && d.ThoiGianKetThuc >= now
                                  orderby d.ThoiGianBatDau
                                  select d).ToList();

            var model = new BatDauThiViewModel
            {
                HoTen = hoSo?.HoTen ?? "Chưa cập nhật",
                NgaySinh = hoSo?.NgaySinh,
                GioiTinh = hoSo?.GioiTinh ?? "Chưa rõ",

                // 🔥 FIX AVATAR (QUAN TRỌNG NHẤT)

                MaHocSinh = hocSinh.MaHocSinh,
                SoBaoDanh = hocSinh.SoBaoDanh ?? "",
                Lop = hocSinh.Lop?.TenLop ?? "",
                AvatarUrl = hoSo?.AnhDaiDien,
                DanhSachDotThi = danhSachDotThi.Select(d =>
                {
                    var daNop = _context.LuotThi
                        .Any(x => x.MaHocSinh == hocSinh.MaHocSinh
                               && x.MaDotThi == d.MaDotThi
                               && x.ThoiDiemNopBai != null);

                    var maMon = _context.DeThi
                        .Where(dt => dt.MaDeThi == d.MaDeThi)
                        .Select(dt => dt.MaMonHoc)
                        .FirstOrDefault();

                    var monThi = _context.MonHoc
                        .Where(m => m.MaMonHoc == maMon)
                        .Select(m => m.TenMonHoc)
                        .FirstOrDefault() ?? "";

                    return new DotThiItemVM
                    {
                        MaDotThi = d.MaDotThi,
                        TenDotThi = d.TenDotThi,
                        MonThi = monThi,

                        ThoiGianLamBai = (int)(d.ThoiGianKetThuc - d.ThoiGianBatDau).TotalMinutes,
                        ThoiGianBatDau = d.ThoiGianBatDau,
                        ThoiGianKetThuc = d.ThoiGianKetThuc,

                        DuocPhanCong = true,

                        DangMo = d.TrangThai
                            && now >= d.ThoiGianBatDau
                            && now <= d.ThoiGianKetThuc
                            && !daNop,

                        SapDienRa = d.TrangThai && now < d.ThoiGianBatDau,

                        DaNopBai = daNop
                    };
                }).ToList()
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult TaoLuotThi(int maDotThi)
        {
            // 🔒 chưa đăng nhập
            if (!DaDangNhap())
                return RedirectToAction("DangNhap", "Home");

            var maHocSinh = HttpContext.Session.GetInt32("MaHocSinh");

            if (maHocSinh == null)
                return RedirectToAction("DangNhap", "Home");

            // 🔥 check học sinh tồn tại (FIX FK)
            var hocSinh = _context.HocSinh.FirstOrDefault(x => x.MaHocSinh == maHocSinh.Value);
            if (hocSinh == null)
            {
                TempData["Loi"] = "Không tìm thấy học sinh!";
                return RedirectToAction("BatDauThi");
            }

            // 🔥 check đợt thi
            var dotThi = _context.DotThi.FirstOrDefault(x => x.MaDotThi == maDotThi);

            if (dotThi == null)
            {
                TempData["Loi"] = "Không tìm thấy đợt thi.";
                return RedirectToAction("BatDauThi");
            }

            // ❌ chưa đến giờ
            if (DateTime.Now < dotThi.ThoiGianBatDau)
            {
                TempData["Loi"] = "Chưa đến thời gian làm bài!";
                return RedirectToAction("BatDauThi");
            }

            // ❌ hết giờ
            if (DateTime.Now > dotThi.ThoiGianKetThuc)
            {
                TempData["Loi"] = "Đã hết thời gian làm bài!";
                return RedirectToAction("BatDauThi");
            }

            // 🔥 QUAN TRỌNG: check có trong danh sách dự thi không (FIX FK NGẦM)
            var duocThi = _context.DanhSachDuThi
                .Any(x => x.MaDotThi == maDotThi && x.MaHocSinh == maHocSinh.Value);

            if (!duocThi)
            {
                TempData["Loi"] = "Bạn không thuộc đợt thi này!";
                return RedirectToAction("BatDauThi");
            }

            // ❌ đã thi (chỉ tính khi đã nộp)
            var daThi = _context.LuotThi
                .Any(x => x.MaHocSinh == maHocSinh.Value
                       && x.MaDotThi == maDotThi
                       && x.ThoiDiemNopBai != null);

            if (daThi)
            {
                TempData["Loi"] = "Bạn đã làm bài thi này rồi!";
                return RedirectToAction("BatDauThi");
            }

            // 🔥 FIX BUG: nếu F5 → không tạo nhiều lượt thi
            var dangLam = _context.LuotThi
                .FirstOrDefault(x => x.MaHocSinh == maHocSinh.Value
                                  && x.MaDotThi == maDotThi
                                  && x.ThoiDiemNopBai == null);

            if (dangLam != null)
            {
                return RedirectToAction("LamBai", new { maLuotThi = dangLam.MaLuotThi });
            }

            // ✅ tạo lượt thi
            var luotThi = new LuotThi
            {
                MaDotThi = maDotThi,
                MaHocSinh = maHocSinh.Value,
                LanThi = 1,
                ThoiDiemBatDau = DateTime.Now,
                TrangThai = true
            };

            _context.LuotThi.Add(luotThi);
            _context.SaveChanges();

            return RedirectToAction("LamBai", new { maLuotThi = luotThi.MaLuotThi });
        }

        [HttpGet]
        public IActionResult LamBai(int maLuotThi)
        {
            if (!DaDangNhap())
            {
                return RedirectToAction("DangNhap", "Home");
            }

            int? maHocSinh = HttpContext.Session.GetInt32("MaHocSinh");

            if (maHocSinh == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            var luotThi = _context.LuotThi
                .FirstOrDefault(x => x.MaLuotThi == maLuotThi && x.MaHocSinh == maHocSinh.Value);

            if (luotThi == null)
            {
                TempData["Loi"] = "Không tìm thấy lượt thi.";
                return RedirectToAction("BatDauThi");
            }

            // 🔥 LẤY ĐỢT THI
            var dotThi = _context.DotThi
                .FirstOrDefault(x => x.MaDotThi == luotThi.MaDotThi);

            if (dotThi == null)
            {
                TempData["Loi"] = "Không tìm thấy đợt thi.";
                return RedirectToAction("BatDauThi");
            }

            // 🔒 CHẶN KHÓA (QUAN TRỌNG NHẤT)
            if (dotThi.IsKhoa)
            {
                TempData["Loi"] = "🚫 Đợt thi đã bị khóa!";
                return RedirectToAction("BatDauThi");
            }

            // ❌ ĐÃ NỘP
            if (luotThi.ThoiDiemNopBai != null)
            {
                TempData["Loi"] = "Bạn đã nộp bài rồi!";
                return RedirectToAction("KetQua", new { maLuotThi = luotThi.MaLuotThi });
            }

            var thongTin = (from lt in _context.LuotThi
                            join dt in _context.DotThi on lt.MaDotThi equals dt.MaDotThi
                            join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                            join mh in _context.MonHoc on de.MaMonHoc equals mh.MaMonHoc
                            where lt.MaLuotThi == maLuotThi
                            select new
                            {
                                lt.MaLuotThi,
                                lt.ThoiDiemBatDau,
                                dt.MaDotThi,
                                dt.TenDotThi,
                                de.MaDeThi,
                                de.TenDeThi,
                                ThoiGianLamBai = (int)(dt.ThoiGianKetThuc - dt.ThoiGianBatDau).TotalMinutes,
                                mh.TenMonHoc
                            }).FirstOrDefault();

            if (thongTin == null)
            {
                TempData["Loi"] = "Không tìm thấy thông tin bài thi.";
                return RedirectToAction("BatDauThi");
            }

            var cauHoiList = (from ct in _context.ChiTietDeThi
                              join ch in _context.CauHoi on ct.MaCauHoi equals ch.MaCauHoi
                              where ct.MaDeThi == thongTin.MaDeThi
                              select new CauHoiThiViewModel
                              {
                                  MaCauHoi = ch.MaCauHoi,
                                  NoiDung = ch.NoiDung,
                                  DiemCauHoi = ct.DiemCauHoi,
                                  DanhSachDapAn = _context.DapAn
                                      .Where(da => da.MaCauHoi == ch.MaCauHoi)
                                      .Select(da => new DapAnThiViewModel
                                      {
                                          MaDapAn = da.MaDapAn,
                                          NoiDung = da.NoiDung
                                      }).ToList()
                              }).ToList();

            // 🔥 RANDOM
            var random = new Random();

            var cauHoiRandom = cauHoiList
                .OrderBy(x => random.Next())
                .ToList();

            foreach (var cau in cauHoiRandom)
            {
                cau.DanhSachDapAn = cau.DanhSachDapAn
                    .OrderBy(x => random.Next())
                    .ToList();
            }

            // 🔥 THỜI GIAN
            int thoiGian = thongTin.ThoiGianLamBai > 0 ? thongTin.ThoiGianLamBai : 60;
            DateTime batDau = thongTin.ThoiDiemBatDau;
            DateTime hetGio = batDau.AddMinutes(thoiGian);

            var model = new LamBaiThiViewModel
            {
                MaLuotThi = thongTin.MaLuotThi,
                MaDotThi = thongTin.MaDotThi,
                TenDotThi = thongTin.TenDotThi,
                TenDeThi = thongTin.TenDeThi,
                MonThi = thongTin.TenMonHoc,
                ThoiGianLamBai = thoiGian,
                ThoiDiemBatDau = batDau,
                ThoiDiemHetGio = hetGio,
                DanhSachCauHoi = cauHoiRandom
            };

            // 🔥 HỌC SINH
            var hocSinh = (from hs in _context.HocSinh
                           join h in _context.HoSoCaNhan
                           on hs.MaNguoiDung equals h.MaNguoiDung
                           where hs.MaHocSinh == maHocSinh.Value
                           select new
                           {
                               hs.MaHocSinh,
                               hs.SoBaoDanh,
                               h.HoTen,
                               h.AnhDaiDien
                           }).FirstOrDefault();

            ViewBag.HoTen = hocSinh?.HoTen ?? "Chưa cập nhật";
            ViewBag.MaHocSinh = hocSinh?.MaHocSinh;
            ViewBag.SoBaoDanh = hocSinh?.SoBaoDanh;
            ViewBag.AnhDaiDien = hocSinh?.AnhDaiDien;
            return View(model);
        }
        [HttpPost]
        public IActionResult NopBai(LamBaiThiViewModel model)
        {
            if (!DaDangNhap())
                return RedirectToAction("DangNhap", "Home");

            int? maHocSinh = HttpContext.Session.GetInt32("MaHocSinh");

            if (maHocSinh == null)
                return RedirectToAction("DangNhap", "Home");

            var luotThi = _context.LuotThi
                .FirstOrDefault(x => x.MaLuotThi == model.MaLuotThi && x.MaHocSinh == maHocSinh.Value);

            if (luotThi == null)
            {
                TempData["Loi"] = "Không tìm thấy lượt thi.";
                return RedirectToAction("BatDauThi");
            }

            // ❌ đã nộp rồi
            if (luotThi.ThoiDiemNopBai != null || !luotThi.TrangThai)
            {
                return RedirectToAction("KetQua", new { maLuotThi = luotThi.MaLuotThi });
            }

            // 🔥 XÓA dữ liệu cũ
            var chiTietCu = _context.ChiTietBaiLam
                .Where(x => x.MaLuotThi == model.MaLuotThi)
                .ToList();

            if (chiTietCu.Any())
            {
                _context.ChiTietBaiLam.RemoveRange(chiTietCu);
            }

            double tongDiem = 0;

            // 🔥 FIX QUAN TRỌNG: chia đều điểm (KHÔNG dùng DiemCauHoi DB)
            int tongSoCau = model.DanhSachCauHoi?.Count ?? 0;
            double diemMoiCau = tongSoCau > 0 ? 10.0 / tongSoCau : 0;

            if (model.DanhSachCauHoi != null && model.DanhSachCauHoi.Any())
            {
                foreach (var cauHoi in model.DanhSachCauHoi)
                {
                    var dapAnDung = _context.DapAn
                        .FirstOrDefault(x => x.MaCauHoi == cauHoi.MaCauHoi && x.LaDapAnDung);

                    bool dungSai = false;

                    if (dapAnDung != null && cauHoi.MaDapAnChon.HasValue)
                    {
                        dungSai = cauHoi.MaDapAnChon.Value == dapAnDung.MaDapAn;
                    }

                    double diemCau = dungSai ? diemMoiCau : 0;

                    tongDiem += diemCau;

                    var chiTiet = new ChiTietBaiLam
                    {
                        MaLuotThi = model.MaLuotThi,
                        MaCauHoi = cauHoi.MaCauHoi,
                        MaDapAnChon = cauHoi.MaDapAnChon,
                        DungSai = dungSai,
                        DiemCau = diemCau // 🔥 giờ sẽ KHÔNG còn = 0 nữa
                    };

                    _context.ChiTietBaiLam.Add(chiTiet);
                }
            }

            // 🔥 LƯU KẾT QUẢ
            luotThi.ThoiDiemNopBai = DateTime.Now;
            luotThi.TrangThai = false;
            luotThi.Diem = Math.Round(tongDiem, 2);

            _context.SaveChanges();

            return RedirectToAction("KetQua", new { maLuotThi = model.MaLuotThi });
        }

        [HttpGet]
        public IActionResult KetQua(int maLuotThi)
        {
            if (!DaDangNhap())
            {
                return RedirectToAction("DangNhap", "Home");
            }

            int? maHocSinh = HttpContext.Session.GetInt32("MaHocSinh");

            if (maHocSinh == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            var thongTin = (from lt in _context.LuotThi
                            join dt in _context.DotThi on lt.MaDotThi equals dt.MaDotThi
                            join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                            join mh in _context.MonHoc on de.MaMonHoc equals mh.MaMonHoc
                            where lt.MaLuotThi == maLuotThi && lt.MaHocSinh == maHocSinh.Value
                            select new
                            {
                                lt.MaLuotThi,
                                lt.ThoiDiemBatDau,
                                lt.ThoiDiemNopBai,
                                dt.TenDotThi,
                                de.TenDeThi,
                                mh.TenMonHoc
                            }).FirstOrDefault();

            if (thongTin == null)
            {
                TempData["Loi"] = "Không tìm thấy kết quả thi.";
                return RedirectToAction("BatDauThi");
            }

            // 🔥 LẤY CHI TIẾT BÀI LÀM
            var chiTiet = (from ctbl in _context.ChiTietBaiLam
                           join ch in _context.CauHoi on ctbl.MaCauHoi equals ch.MaCauHoi
                           where ctbl.MaLuotThi == maLuotThi
                           select new ChiTietKetQuaThiViewModel
                           {
                               MaCauHoi = ch.MaCauHoi,
                               NoiDungCauHoi = ch.NoiDung,

                               MaDapAnChon = ctbl.MaDapAnChon,
                               NoiDungDapAnChon = ctbl.MaDapAnChon == null
                                   ? "Chưa chọn"
                                   : _context.DapAn
                                       .Where(x => x.MaDapAn == ctbl.MaDapAnChon)
                                       .Select(x => x.NoiDung)
                                       .FirstOrDefault() ?? "Chưa chọn",

                               NoiDungDapAnDung = _context.DapAn
                                   .Where(x => x.MaCauHoi == ctbl.MaCauHoi && x.LaDapAnDung)
                                   .Select(x => x.NoiDung)
                                   .FirstOrDefault() ?? "",

                               DungSai = ctbl.DungSai,
                               DiemCau = ctbl.DiemCau
                           }).ToList();

            // 🔥 FIX ĐIỂM CHUẨN (QUAN TRỌNG NHẤT)
            int tongCau = chiTiet.Count;
            int soCauDung = chiTiet.Count(x => x.DungSai);
            var diemDb = _context.LuotThi
    .Where(x => x.MaLuotThi == maLuotThi)
    .Select(x => x.Diem)
    .FirstOrDefault();
            double diem = diemDb ?? 0;
            // 🔥 MODEL
            var model = new KetQuaThiViewModel
            {
                MaLuotThi = thongTin.MaLuotThi,
                TenDotThi = thongTin.TenDotThi,
                TenDeThi = thongTin.TenDeThi,
                MonThi = thongTin.TenMonHoc,

                TongSoCau = tongCau,
                SoCauDung = soCauDung,
                SoCauSai = tongCau - soCauDung,

                TongDiem = diem, // 🔥 ĐÃ FIX

                ThoiDiemBatDau = thongTin.ThoiDiemBatDau,
                ThoiDiemNopBai = thongTin.ThoiDiemNopBai,

                ChiTietCauHoi = (from ct in _context.ChiTietBaiLam
                                 join ch in _context.CauHoi on ct.MaCauHoi equals ch.MaCauHoi
                                 where ct.MaLuotThi == maLuotThi
                                 select new ChiTietKetQuaThiViewModel
                                 {
                                     NoiDungCauHoi = ch.NoiDung,

                                     NoiDungDapAnChon = _context.DapAn
                                         .Where(x => x.MaDapAn == ct.MaDapAnChon)
                                         .Select(x => x.NoiDung)
                                         .FirstOrDefault(),

                                     NoiDungDapAnDung = _context.DapAn
                                         .Where(x => x.MaCauHoi == ch.MaCauHoi && x.LaDapAnDung)
                                         .Select(x => x.NoiDung)
                                         .FirstOrDefault(),

                                     DungSai = ct.DungSai,

                                     DanhSachDapAn = _context.DapAn
                                         .Where(x => x.MaCauHoi == ch.MaCauHoi)
                                         .Select(x => new DapAnThiViewModel
                                         {
                                             NoiDung = x.NoiDung
                                         }).ToList()
                                 }).ToList()
            };

            // 🔥 THÔNG TIN HỌC SINH
            ViewBag.SoBaoDanh = HttpContext.Session.GetString("SoBaoDanh");

            var hocSinh = (from hs in _context.HocSinh
                           join h in _context.HoSoCaNhan
                           on hs.MaNguoiDung equals h.MaNguoiDung
                           where hs.MaHocSinh == maHocSinh.Value
                           select new
                           {
                               hs.MaHocSinh,
                               hs.SoBaoDanh,
                               h.HoTen
                           }).FirstOrDefault();

            ViewBag.HoTen = hocSinh?.HoTen ?? "Chưa cập nhật";
            ViewBag.MaHocSinh = hocSinh?.MaHocSinh;
            ViewBag.SoBaoDanh = hocSinh?.SoBaoDanh;

            return View(model);
        }
      
    }

}