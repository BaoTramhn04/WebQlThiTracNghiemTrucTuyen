using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebQLThiTracNghiem.Data;
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

        public IActionResult DanhSachDotThi()
        {
            if (!DaDangNhap())
            {
                return RedirectToAction("DangNhap", "Home");
            }

            var vaiTro = HttpContext.Session.GetInt32("VaiTro");

            if (vaiTro == null || vaiTro != 3)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            int? maHocSinh = HttpContext.Session.GetInt32("MaHocSinh");

            if (maHocSinh == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            var danhSachDotThi = (from dsdt in _context.DanhSachDuThi
                                  join dt in _context.DotThi on dsdt.MaDotThi equals dt.MaDotThi
                                  join d in _context.DeThi on dt.MaDeThi equals d.MaDeThi
                                  join mh in _context.MonHoc on d.MaMonHoc equals mh.MaMonHoc
                                  where dsdt.MaHocSinh == maHocSinh.Value
                                  select new DanhSachDotThiHocSinhViewModel
                                  {
                                      MaDotThi = dt.MaDotThi,
                                      TenDotThi = dt.TenDotThi,
                                      TenDeThi = d.TenDeThi,
                                      MonThi = mh.TenMonHoc,
                                      ThoiGianBatDau = dt.ThoiGianBatDau,
                                      ThoiGianKetThuc = dt.ThoiGianKetThuc,
                                      ThoiGianLamBai = d.ThoiGianLamBai,
                                      SoLanThiToiDa = dt.SoLanThiToiDa,
                                      TrangThai = dt.TrangThai,

                                     
                                     DuocPhepThi = dsdt.DuocPhepThi,
                                      GhiChu = dsdt.GhiChu
                                  }).ToList();
            DateTime hienTai = DateTime.Now;

            foreach (var item in danhSachDotThi)
            {
                bool duocThi = item.DuocPhepThi;

                int soLanDaThi = _context.LuotThi
                    .Count(x => x.MaDotThi == item.MaDotThi && x.MaHocSinh == maHocSinh.Value);

                item.ConLuotThi = soLanDaThi < item.SoLanThiToiDa;

                if (!duocThi)
                {
                    item.DangMoHienThi = false;
                    item.TrangThaiHienThi = "Không được phép";
                }
                else if (hienTai < item.ThoiGianBatDau)
                {
                    item.DangMoHienThi = false;
                    item.TrangThaiHienThi = "Sắp diễn ra";
                }
                else if (hienTai > item.ThoiGianKetThuc)
                {
                    item.DangMoHienThi = false;
                    item.TrangThaiHienThi = "Đã kết thúc";
                }
                else if (!item.ConLuotThi)
                {
                    item.DangMoHienThi = false;
                    item.TrangThaiHienThi = "Hết lượt";
                }
                else
                {
                    item.DangMoHienThi = true;
                    item.TrangThaiHienThi = "Đang thi";
                }
            
        }
            ViewBag.SoBaoDanh = HttpContext.Session.GetString("SoBaoDanh");
            ViewBag.TenDangNhap = HttpContext.Session.GetString("TenDangNhap");

            return View(danhSachDotThi);
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

            nguoiDung.MatKhau = model.MatKhauMoi;
            _context.SaveChanges();

            ViewBag.ThanhCong = "Đổi mật khẩu thành công";
            ModelState.Clear();

            return View();
        }

        [HttpGet]
        public IActionResult BatDauThi(int maDotThi)
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

            var duThi = _context.DanhSachDuThi
                .FirstOrDefault(x => x.MaDotThi == maDotThi && x.MaHocSinh == maHocSinh.Value);

            if (duThi == null || !duThi.DuocPhepThi)
            {
                TempData["Loi"] = "Bạn không được phép tham gia đợt thi này.";
                return RedirectToAction("DanhSachDotThi");
            }

            var thongTinDotThi = (from dt in _context.DotThi
                                  join de in _context.DeThi on dt.MaDeThi equals de.MaDeThi
                                  join mh in _context.MonHoc on de.MaMonHoc equals mh.MaMonHoc
                                  where dt.MaDotThi == maDotThi
                                  select new
                                  {
                                      dt.MaDotThi,
                                      dt.TenDotThi,
                                      dt.ThoiGianBatDau,
                                      dt.ThoiGianKetThuc,
                                      dt.SoLanThiToiDa,
                                      dt.TrangThai,
                                      de.MaDeThi,
                                      de.TenDeThi,
                                      de.ThoiGianLamBai,
                                      mh.TenMonHoc
                                  }).FirstOrDefault();

            if (thongTinDotThi == null)
            {
                TempData["Loi"] = "Không tìm thấy đợt thi.";
                return RedirectToAction("DanhSachDotThi");
            }

            DateTime hienTai = DateTime.Now;

            if (hienTai < thongTinDotThi.ThoiGianBatDau || hienTai > thongTinDotThi.ThoiGianKetThuc)
            {
                TempData["Loi"] = "Chưa đến thời gian thi hoặc đợt thi đã kết thúc.";
                return RedirectToAction("DanhSachDotThi");
            }

            int soLanDaThi = _context.LuotThi
                .Count(x => x.MaDotThi == maDotThi && x.MaHocSinh == maHocSinh.Value);

            if (soLanDaThi >= thongTinDotThi.SoLanThiToiDa)
            {
                TempData["Loi"] = "Bạn đã sử dụng hết số lần thi cho đợt thi này.";
                return RedirectToAction("DanhSachDotThi");
            }

            int soLuongCauHoi = _context.ChiTietDeThi
                .Count(x => x.MaDeThi == thongTinDotThi.MaDeThi);

            var model = new BatDauThiViewModel
            {
                MaDotThi = thongTinDotThi.MaDotThi,
                TenDotThi = thongTinDotThi.TenDotThi,
                ThoiGianBatDau = thongTinDotThi.ThoiGianBatDau,
                ThoiGianKetThuc = thongTinDotThi.ThoiGianKetThuc,
                ThoiGianLamBai = thongTinDotThi.ThoiGianLamBai,
                SoLuongCauHoi = soLuongCauHoi,
                TenDeThi = thongTinDotThi.TenDeThi,
                MonThi = thongTinDotThi.TenMonHoc
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult TaoLuotThi(int maDotThi)
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

            var duThi = _context.DanhSachDuThi
                .FirstOrDefault(x => x.MaDotThi == maDotThi && x.MaHocSinh == maHocSinh.Value);

            if (duThi == null || !duThi.DuocPhepThi)
            {
                TempData["Loi"] = "Bạn không được phép tham gia đợt thi này.";
                return RedirectToAction("DanhSachDotThi");
            }

            var dotThi = _context.DotThi.FirstOrDefault(x => x.MaDotThi == maDotThi);

            if (dotThi == null)
            {
                TempData["Loi"] = "Không tìm thấy đợt thi.";
                return RedirectToAction("DanhSachDotThi");
            }

            DateTime hienTai = DateTime.Now;

            if (hienTai < dotThi.ThoiGianBatDau || hienTai > dotThi.ThoiGianKetThuc)
            {
                TempData["Loi"] = "Chưa đến thời gian thi hoặc đợt thi đã kết thúc.";
                return RedirectToAction("DanhSachDotThi");
            }

            int soLanDaThi = _context.LuotThi
                .Count(x => x.MaDotThi == maDotThi && x.MaHocSinh == maHocSinh.Value);

            if (soLanDaThi >= dotThi.SoLanThiToiDa)
            {
                TempData["Loi"] = "Bạn đã sử dụng hết số lần thi cho đợt thi này.";
                return RedirectToAction("DanhSachDotThi");
            }

            var luotThi = new Models.LuotThi
            {
                MaDotThi = maDotThi,
                MaHocSinh = maHocSinh.Value,
                LanThi = soLanDaThi + 1,
                ThoiDiemBatDau = DateTime.Now,
                ThoiDiemNopBai = null,
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
                return RedirectToAction("DanhSachDotThi");
            }
            if (luotThi.ThoiDiemNopBai != null || !luotThi.TrangThai)
            {
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
                                de.ThoiGianLamBai,
                                mh.TenMonHoc
                            }).FirstOrDefault();

            if (thongTin == null)
            {
                TempData["Loi"] = "Không tìm thấy thông tin bài thi.";
                return RedirectToAction("DanhSachDotThi");
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
            var model = new LamBaiThiViewModel
            {
                MaLuotThi = thongTin.MaLuotThi,
                MaDotThi = thongTin.MaDotThi,
                TenDotThi = thongTin.TenDotThi,
                TenDeThi = thongTin.TenDeThi,
                MonThi = thongTin.TenMonHoc,
                ThoiGianLamBai = thongTin.ThoiGianLamBai,
                ThoiDiemBatDau = thongTin.ThoiDiemBatDau,
                ThoiDiemHetGio = thongTin.ThoiDiemBatDau.AddMinutes(thongTin.ThoiGianLamBai),
                DanhSachCauHoi = cauHoiList
            };

            ViewBag.SoBaoDanh = HttpContext.Session.GetString("SoBaoDanh");
            ViewBag.TenDangNhap = HttpContext.Session.GetString("TenDangNhap");

            return View(model);
        }
        [HttpPost]
        public IActionResult NopBai(LamBaiThiViewModel model)
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
                .FirstOrDefault(x => x.MaLuotThi == model.MaLuotThi && x.MaHocSinh == maHocSinh.Value);

            if (luotThi == null)
            {
                TempData["Loi"] = "Không tìm thấy lượt thi.";
                return RedirectToAction("DanhSachDotThi");
            }
            if (luotThi.ThoiDiemNopBai != null || !luotThi.TrangThai)
            {
                return RedirectToAction("KetQua", new { maLuotThi = luotThi.MaLuotThi });
            }

            var chiTietCu = _context.ChiTietBaiLam
                .Where(x => x.MaLuotThi == model.MaLuotThi)
                .ToList();

            if (chiTietCu.Any())
            {
                _context.ChiTietBaiLam.RemoveRange(chiTietCu);
                _context.SaveChanges();
            }

            if (model.DanhSachCauHoi != null)
            {
                foreach (var cauHoi in model.DanhSachCauHoi)
                {
                    var dapAnDung = _context.DapAn
                        .FirstOrDefault(x => x.MaCauHoi == cauHoi.MaCauHoi && x.LaDapAnDung);

                    bool dungSai = dapAnDung != null
                                   && cauHoi.MaDapAnChon.HasValue
                                   && cauHoi.MaDapAnChon.Value == dapAnDung.MaDapAn;

                    double diemCau = dungSai ? cauHoi.DiemCauHoi : 0;

                    var chiTiet = new WebQLThiTracNghiem.Models.ChiTietBaiLam
                    {
                        MaLuotThi = model.MaLuotThi,
                        MaCauHoi = cauHoi.MaCauHoi,
                        MaDapAnChon = cauHoi.MaDapAnChon,
                        DungSai = dungSai,
                        DiemCau = diemCau
                    };

                    _context.ChiTietBaiLam.Add(chiTiet);
                }
            }

            luotThi.ThoiDiemNopBai = DateTime.Now;
            luotThi.TrangThai = false;

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
                return RedirectToAction("DanhSachDotThi");
            }

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

                               MaDapAnDung = _context.DapAn
                                   .Where(x => x.MaCauHoi == ctbl.MaCauHoi && x.LaDapAnDung)
                                   .Select(x => (int?)x.MaDapAn)
                                   .FirstOrDefault(),

                               NoiDungDapAnDung = _context.DapAn
                                   .Where(x => x.MaCauHoi == ctbl.MaCauHoi && x.LaDapAnDung)
                                   .Select(x => x.NoiDung)
                                   .FirstOrDefault() ?? "",

                               DungSai = ctbl.DungSai,
                               DiemCau = ctbl.DiemCau
                           }).ToList(); ;

            var model = new KetQuaThiViewModel
            {
                MaLuotThi = thongTin.MaLuotThi,
                TenDotThi = thongTin.TenDotThi,
                TenDeThi = thongTin.TenDeThi,
                MonThi = thongTin.TenMonHoc,
                TongSoCau = chiTiet.Count,
                SoCauDung = chiTiet.Count(x => x.DungSai),
                SoCauSai = chiTiet.Count(x => !x.DungSai),
                TongDiem = chiTiet.Sum(x => x.DiemCau),
                ThoiDiemBatDau = thongTin.ThoiDiemBatDau,
                ThoiDiemNopBai = thongTin.ThoiDiemNopBai,
                ChiTietCauHoi = chiTiet
            };

            ViewBag.SoBaoDanh = HttpContext.Session.GetString("SoBaoDanh");
            ViewBag.TenDangNhap = HttpContext.Session.GetString("TenDangNhap");

            return View(model);
        }
    }
}