using Microsoft.EntityFrameworkCore;
using WebQLThiTracNghiem.Models;

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
            modelBuilder.Entity<VaiTro>().HasData(
                new VaiTro { MaVaiTro = 1, TenVaiTro = "Admin" },
                new VaiTro { MaVaiTro = 2, TenVaiTro = "GiaoVien" },
                new VaiTro { MaVaiTro = 3, TenVaiTro = "HocSinh" }
            );

            modelBuilder.Entity<NguoiDung>().HasData(
                new NguoiDung
                {
                    MaNguoiDung = 1,
                    TenDangNhap = "admin",
                    MatKhau = "123",
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    MaVaiTro = 1
                },
                new NguoiDung
                {
                    MaNguoiDung = 2,
                    TenDangNhap = "gv01",
                    MatKhau = "123",
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    MaVaiTro = 2
                },
                new NguoiDung
                {
                    MaNguoiDung = 3,
                    TenDangNhap = "hs01",
                    MatKhau = "123",
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    MaVaiTro = 3
                }
            );

            modelBuilder.Entity<Lop>().HasData(
                new Lop
                {
                    MaLop = 1,
                    KyHieuLop = "12A1",
                    TenLop = "Lop 12A1",
                    NamHoc = "2025-2026"
                }
            );

            modelBuilder.Entity<HocSinh>().HasData(
                new HocSinh
                {
                    MaHocSinh = 1,
                    MaNguoiDung = 3,
                    SoBaoDanh = "HS001",
                    MaLop = 1,
                    TrangThai = true
                }
            );

            modelBuilder.Entity<GiaoVien>().HasData(
                new GiaoVien
                {
                    MaGiaoVien = 1,
                    MaNguoiDung = 2,
                    TrangThai = true
                }
            );

            modelBuilder.Entity<MonHoc>().HasData(
                new MonHoc { MaMonHoc = 1, KyHieuMon = "TOAN", TenMonHoc = "Toan" },
                new MonHoc { MaMonHoc = 2, KyHieuMon = "LY", TenMonHoc = "Vat ly" },
                new MonHoc { MaMonHoc = 3, KyHieuMon = "HOA", TenMonHoc = "Hoa hoc" },
                new MonHoc { MaMonHoc = 4, KyHieuMon = "SINH", TenMonHoc = "Sinh hoc" },
                new MonHoc { MaMonHoc = 5, KyHieuMon = "ANH", TenMonHoc = "Tieng Anh" }
            );
        }
    }
}