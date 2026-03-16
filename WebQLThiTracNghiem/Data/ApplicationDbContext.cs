using Microsoft.EntityFrameworkCore;
using WebQLThiTracNghiem.Models;
using System;
using System.Collections.Generic;

namespace WebQLThiTracNghiem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<HoSoCaNhan> HoSoCaNhan { get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<HocSinh> HocSinh { get; set; }
        public DbSet<GiaoVien> GiaoVien { get; set; }
        public DbSet<NhatKyHeThong> NhatKyHeThong { get; set; }
        public DbSet<PhanCongGiangDay> PhanCongGiangDays { get; set; }

        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<ChuyenDe> ChuyenDe { get; set; }
        public DbSet<CauHoi> CauHoi { get; set; }
        public DbSet<DapAn> DapAn { get; set; }

        public DbSet<DeThi> DeThi { get; set; }
        public DbSet<ChiTietDeThi> ChiTietDeThi { get; set; }
        public DbSet<DotThi> DotThi { get; set; }
        public DbSet<DanhSachDuThi> DanhSachDuThi { get; set; }

        public DbSet<LuotThi> LuotThi { get; set; }
        public DbSet<ChiTietBaiLam> ChiTietBaiLam { get; set; }

        public DbSet<ThongBao> ThongBao { get; set; }
        public DbSet<ThongBaoNguoiNhan> ThongBaoNguoiNhan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChiTietDeThi>()
                .HasKey(x => new { x.MaDeThi, x.MaCauHoi });

            modelBuilder.Entity<DanhSachDuThi>()
                .HasKey(x => new { x.MaDotThi, x.MaHocSinh });

            modelBuilder.Entity<ChiTietBaiLam>()
                .HasKey(x => new { x.MaLuotThi, x.MaCauHoi });

            modelBuilder.Entity<ThongBaoNguoiNhan>()
                .HasKey(x => new { x.MaThongBao, x.MaNguoiDung });

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // ===== VAI TRÒ =====
            modelBuilder.Entity<VaiTro>().HasData(
                new VaiTro { MaVaiTro = 1, TenVaiTro = "Admin" },
                new VaiTro { MaVaiTro = 2, TenVaiTro = "GiaoVien" },
                new VaiTro { MaVaiTro = 3, TenVaiTro = "HocSinh" }
            );

            // ===== ADMIN =====
            modelBuilder.Entity<NguoiDung>().HasData(
                new NguoiDung
                {
                    MaNguoiDung = 1,
                    TenDangNhap = "admin",
                    MatKhau = "123456",
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    MaVaiTro = 1
                });

            modelBuilder.Entity<HoSoCaNhan>().HasData(
                new HoSoCaNhan
                {
                    MaNguoiDung = 1,
                    HoTen = "Quản trị hệ thống",
                    NgaySinh = new DateTime(1985, 1, 1),
                    GioiTinh = "Nam",
                    SoDienThoai = "0900000000",
                    DiaChi = "Hà Nội",
                    AnhDaiDien = null
                });

            // ===== LỚP =====
            var lopList = new List<Lop>();

            for (int i = 1; i <= 12; i++)
            {
                lopList.Add(new Lop
                {
                    MaLop = i,
                    KyHieuLop = "12A" + i,
                    TenLop = "Lớp 12A" + i,
                    NamHoc = "2025-2026"
                });
            }

            modelBuilder.Entity<Lop>().HasData(lopList);

            // ===== MÔN =====
            modelBuilder.Entity<MonHoc>().HasData(
                new MonHoc { MaMonHoc = 1, KyHieuMon = "TOAN", TenMonHoc = "Toán" },
                new MonHoc { MaMonHoc = 2, KyHieuMon = "LY", TenMonHoc = "Vật Lý" },
                new MonHoc { MaMonHoc = 3, KyHieuMon = "HOA", TenMonHoc = "Hóa Học" },
                new MonHoc { MaMonHoc = 4, KyHieuMon = "ANH", TenMonHoc = "Tiếng Anh" },
                new MonHoc { MaMonHoc = 5, KyHieuMon = "SINH", TenMonHoc = "Sinh Học" },
                new MonHoc { MaMonHoc = 6, KyHieuMon = "SU", TenMonHoc = "Lịch Sử" },
                new MonHoc { MaMonHoc = 7, KyHieuMon = "DIA", TenMonHoc = "Địa Lý" }
            );

            // ===== CHUYÊN ĐỀ =====
            modelBuilder.Entity<ChuyenDe>().HasData(
                new ChuyenDe { MaChuyenDe = 1, TenChuyenDe = "Hàm số", MaMonHoc = 1 },
                new ChuyenDe { MaChuyenDe = 2, TenChuyenDe = "Dao động", MaMonHoc = 2 },
                new ChuyenDe { MaChuyenDe = 3, TenChuyenDe = "Este - Lipit", MaMonHoc = 3 },
                new ChuyenDe { MaChuyenDe = 4, TenChuyenDe = "Ngữ pháp", MaMonHoc = 4 },
                new ChuyenDe { MaChuyenDe = 5, TenChuyenDe = "Di truyền", MaMonHoc = 5 },
                new ChuyenDe { MaChuyenDe = 6, TenChuyenDe = "Việt Nam 1945", MaMonHoc = 6 },
                new ChuyenDe { MaChuyenDe = 7, TenChuyenDe = "Địa lý kinh tế", MaMonHoc = 7 }
            );

            // ===== CÂU HỎI =====
            var cauHoiList = new List<CauHoi>();
            var dapAnList = new List<DapAn>();

            int chId = 1;
            int daId = 1;

            for (int i = 1; i <= 200; i++)
            {
                int chuyenDe = (i % 7) + 1;

                cauHoiList.Add(new CauHoi
                {
                    MaCauHoi = chId,
                    NoiDung = "Câu hỏi trắc nghiệm số " + chId,
                    MaChuyenDe = chuyenDe,
                    MucDo = (i % 3) + 1,
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    NguoiTao = 1
                });

                for (int j = 1; j <= 4; j++)
                {
                    dapAnList.Add(new DapAn
                    {
                        MaDapAn = daId++,
                        MaCauHoi = chId,
                        NoiDung = "Đáp án " + j,
                        LaDapAnDung = j == 1
                    });
                }

                chId++;
            }

            modelBuilder.Entity<CauHoi>().HasData(cauHoiList);
            modelBuilder.Entity<DapAn>().HasData(dapAnList);

            // ===== ĐỀ THI =====
            var deList = new List<DeThi>();

            for (int i = 1; i <= 10; i++)
            {
                deList.Add(new DeThi
                {
                    MaDeThi = i,
                    TenDeThi = "Đề thi số " + i,
                    MaMonHoc = 1,
                    TrangThai = true
                });
            }

            modelBuilder.Entity<DeThi>().HasData(deList);

            // ===== CHI TIẾT ĐỀ =====
            var ctDe = new List<ChiTietDeThi>();
            int idCau = 1;

            for (int de = 1; de <= 10; de++)
            {
                for (int i = 1; i <= 40; i++)
                {
                    ctDe.Add(new ChiTietDeThi
                    {
                        MaDeThi = de,
                        MaCauHoi = idCau++
                    });
                }
            }

            modelBuilder.Entity<ChiTietDeThi>().HasData(ctDe);

            // ===== ĐỢT THI =====
            modelBuilder.Entity<DotThi>().HasData(
                new DotThi
                {
                    MaDotThi = 1,
                    TenDotThi = "Thi thử học kỳ Toán",
                    MaDeThi = 1,
                    ThoiGianBatDau = new DateTime(2025, 6, 1, 8, 0, 0),
                    ThoiGianKetThuc = new DateTime(2025, 6, 1, 9, 0, 0),
                    TrangThai = true
                },

                new DotThi
                {
                    MaDotThi = 2,
                    TenDotThi = "Thi thử Vật Lý",
                    MaDeThi = 3,
                    ThoiGianBatDau = new DateTime(2025, 6, 2, 8, 0, 0),
                    ThoiGianKetThuc = new DateTime(2025, 6, 2, 9, 0, 0),
                    TrangThai = true
                }
            );

            // ===== GIÁO VIÊN =====
            string[] tenGV =
            {
                "Nguyễn Văn Minh","Trần Thị Lan","Phạm Văn Hùng","Lê Thị Hoa",
                "Đỗ Văn Nam","Ngô Thị Hạnh","Hoàng Văn Tuấn","Bùi Thị Trang",
                "Phan Văn Long","Vũ Thị Mai","Đặng Văn Sơn","Trịnh Thị Hà",
                "Đoàn Văn Phúc","Tạ Thị Thu","Lương Văn Hải","Hà Thị Linh",
                "Nguyễn Văn Quân","Trần Văn Phong","Lê Văn Dũng","Phạm Thị Hương"
            };

            var gvUser = new List<NguoiDung>();
            var gvHoSo = new List<HoSoCaNhan>();
            var gvList = new List<GiaoVien>();

            for (int i = 0; i < 20; i++)
            {
                gvUser.Add(new NguoiDung
                {
                    MaNguoiDung = 100 + i,
                    TenDangNhap = "gv" + (i + 1),
                    MatKhau = "123456",
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    MaVaiTro = 2
                });

                gvHoSo.Add(new HoSoCaNhan
                {
                    MaNguoiDung = 100 + i,
                    HoTen = tenGV[i],
                    NgaySinh = new DateTime(1985 + (i % 10), (i % 12) + 1, (i % 28) + 1),
                    GioiTinh = i % 2 == 0 ? "Nam" : "Nữ",
                    SoDienThoai = "0900000" + (100 + i),
                    DiaChi = "Hà Nội",
                    AnhDaiDien = null
                });

                gvList.Add(new GiaoVien
                {
                    MaGiaoVien = i + 1,
                    MaNguoiDung = 100 + i,
                    TrangThai = true
                });
            }

            modelBuilder.Entity<NguoiDung>().HasData(gvUser);
            modelBuilder.Entity<HoSoCaNhan>().HasData(gvHoSo);
            modelBuilder.Entity<GiaoVien>().HasData(gvList);

            // ===== PHÂN CÔNG GIẢNG DẠY =====
            var phanCong = new List<PhanCongGiangDay>();
            int id = 1;

            /*
            Mỗi môn có 2 giáo viên
            Mỗi giáo viên dạy vài lớp
            Mỗi lớp vẫn có đủ 7 môn
            */

            // ===== TOÁN =====
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 1, MaLop = 1, MaMon = 1 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 1, MaLop = 2, MaMon = 1 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 1, MaLop = 3, MaMon = 1 });

            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 2, MaLop = 4, MaMon = 1 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 2, MaLop = 5, MaMon = 1 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 2, MaLop = 6, MaMon = 1 });

            // ===== VẬT LÝ =====
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 3, MaLop = 1, MaMon = 2 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 3, MaLop = 2, MaMon = 2 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 3, MaLop = 3, MaMon = 2 });

            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 4, MaLop = 4, MaMon = 2 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 4, MaLop = 5, MaMon = 2 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 4, MaLop = 6, MaMon = 2 });

            // ===== HÓA =====
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 5, MaLop = 7, MaMon = 3 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 5, MaLop = 8, MaMon = 3 });

            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 6, MaLop = 9, MaMon = 3 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 6, MaLop = 10, MaMon = 3 });

            // ===== ANH =====
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 7, MaLop = 1, MaMon = 4 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 7, MaLop = 2, MaMon = 4 });

            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 8, MaLop = 3, MaMon = 4 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 8, MaLop = 4, MaMon = 4 });

            // ===== SINH =====
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 9, MaLop = 5, MaMon = 5 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 9, MaLop = 6, MaMon = 5 });

            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 10, MaLop = 7, MaMon = 5 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 10, MaLop = 8, MaMon = 5 });

            // ===== SỬ =====
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 11, MaLop = 9, MaMon = 6 });
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 11, MaLop = 10, MaMon = 6 });

            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 12, MaLop = 11, MaMon = 6 });

            // ===== ĐỊA =====
            phanCong.Add(new PhanCongGiangDay { MaPhanCong = id++, MaGiaoVien = 13, MaLop = 12, MaMon = 7 });

            modelBuilder.Entity<PhanCongGiangDay>().HasData(phanCong);

            // ===== HỌC SINH =====
            string[] ho = { "Nguyễn Hoàng", "Trần Minh", "Lê Hà", "Phạm Nhật", "Hoàng Hải", "Phan Quốc", "Vũ Thái", "Đặng Như", "Bùi Tiến", "Đỗ Xuân" };

            string[] ten = { "Anh", "Bình", "Chi", "Dũng", "Giang", "Hải", "Hà", "Hưng", "Lan", "Linh", "Mai", "Nam", "Ngọc", "Phong", "Quang", "Trang", "Thảo", "Tuấn", "Vy", "Yến" };

            var hsUser = new List<NguoiDung>();
            var hsHoSo = new List<HoSoCaNhan>();
            var hsList = new List<HocSinh>();

            int idHS = 1;
            int nd = 500;
            Random r = new Random(123);

            for (int lop = 1; lop <= 12; lop++)
            {
                for (int i = 0; i < 30; i++)
                {
                    string hoten = ho[r.Next(ho.Length)] + " " + ten[r.Next(ten.Length)];

                    hsUser.Add(new NguoiDung
                    {
                        MaNguoiDung = nd,
                        TenDangNhap = "hs" + idHS,
                        MatKhau = "123456",
                        TrangThai = true,
                        NgayTao = new DateTime(2025, 1, 1),
                        MaVaiTro = 3
                    });

                    hsHoSo.Add(new HoSoCaNhan
                    {
                        MaNguoiDung = nd,
                        HoTen = hoten,
                        NgaySinh = new DateTime(2007, r.Next(1, 13), r.Next(1, 29)),
                        GioiTinh = r.Next(0, 2) == 0 ? "Nam" : "Nữ",
                        SoDienThoai = "091" + r.Next(1000000, 9999999),
                        DiaChi = "Hà Nội",
                        AnhDaiDien = null
                    });

                    hsList.Add(new HocSinh
                    {
                        MaHocSinh = idHS,
                        MaNguoiDung = nd,
                        MaLop = lop,
                        SoBaoDanh = "SBD" + idHS,
                        TrangThai = true
                    });

                    idHS++;
                    nd++;
                }
            }

            modelBuilder.Entity<NguoiDung>().HasData(hsUser);
            modelBuilder.Entity<HoSoCaNhan>().HasData(hsHoSo);
            modelBuilder.Entity<HocSinh>().HasData(hsList);
        }
    }
}