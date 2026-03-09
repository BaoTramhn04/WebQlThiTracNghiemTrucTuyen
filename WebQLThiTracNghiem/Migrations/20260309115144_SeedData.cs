using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CauHoi",
                columns: table => new
                {
                    MaCauHoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaChuyenDe = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MucDo = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTao = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHoi", x => x.MaCauHoi);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietBaiLam",
                columns: table => new
                {
                    MaLuotThi = table.Column<int>(type: "int", nullable: false),
                    MaCauHoi = table.Column<int>(type: "int", nullable: false),
                    MaDapAnChon = table.Column<int>(type: "int", nullable: true),
                    DungSai = table.Column<bool>(type: "bit", nullable: false),
                    DiemCau = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietBaiLam", x => new { x.MaLuotThi, x.MaCauHoi });
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDeThi",
                columns: table => new
                {
                    MaDeThi = table.Column<int>(type: "int", nullable: false),
                    MaCauHoi = table.Column<int>(type: "int", nullable: false),
                    DiemCauHoi = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDeThi", x => new { x.MaDeThi, x.MaCauHoi });
                });

            migrationBuilder.CreateTable(
                name: "ChuyenDe",
                columns: table => new
                {
                    MaChuyenDe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaMonHoc = table.Column<int>(type: "int", nullable: false),
                    TenChuyenDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenDe", x => x.MaChuyenDe);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachDuThi",
                columns: table => new
                {
                    MaDotThi = table.Column<int>(type: "int", nullable: false),
                    MaHocSinh = table.Column<int>(type: "int", nullable: false),
                    DuocPhepThi = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachDuThi", x => new { x.MaDotThi, x.MaHocSinh });
                });

            migrationBuilder.CreateTable(
                name: "DapAn",
                columns: table => new
                {
                    MaDapAn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCauHoi = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaDapAnDung = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DapAn", x => x.MaDapAn);
                });

            migrationBuilder.CreateTable(
                name: "DeThi",
                columns: table => new
                {
                    MaDeThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDeThi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaMonHoc = table.Column<int>(type: "int", nullable: false),
                    ThoiGianLamBai = table.Column<int>(type: "int", nullable: false),
                    TronCauHoi = table.Column<bool>(type: "bit", nullable: false),
                    TronDapAn = table.Column<bool>(type: "bit", nullable: false),
                    NguoiTao = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeThi", x => x.MaDeThi);
                });

            migrationBuilder.CreateTable(
                name: "DotThi",
                columns: table => new
                {
                    MaDotThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDeThi = table.Column<int>(type: "int", nullable: false),
                    TenDotThi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLanThiToiDa = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotThi", x => x.MaDotThi);
                });

            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    MaGiaoVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.MaGiaoVien);
                });

            migrationBuilder.CreateTable(
                name: "HoSoCaNhan",
                columns: table => new
                {
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoCaNhan", x => x.MaNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyHieuLop = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "LuotThi",
                columns: table => new
                {
                    MaLuotThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDotThi = table.Column<int>(type: "int", nullable: false),
                    MaHocSinh = table.Column<int>(type: "int", nullable: false),
                    LanThi = table.Column<int>(type: "int", nullable: false),
                    ThoiDiemBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiDiemNopBai = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuotThi", x => x.MaLuotThi);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    MaMonHoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyHieuMon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.MaMonHoc);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaVaiTro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.MaNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "NhatKyHeThong",
                columns: table => new
                {
                    MaNhatKy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    HanhDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DoiTuongTacDong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaBanGhiTacDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThoiGianThucHien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChiIP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhatKyHeThong", x => x.MaNhatKy);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    MaThongBao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiTao = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.MaThongBao);
                });

            migrationBuilder.CreateTable(
                name: "ThongBaoNguoiNhan",
                columns: table => new
                {
                    MaThongBao = table.Column<int>(type: "int", nullable: false),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    DaDoc = table.Column<bool>(type: "bit", nullable: false),
                    ThoiGianDoc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBaoNguoiNhan", x => new { x.MaThongBao, x.MaNguoiDung });
                });

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    MaVaiTro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVaiTro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.MaVaiTro);
                });

            migrationBuilder.CreateTable(
                name: "HocSinh",
                columns: table => new
                {
                    MaHocSinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    MaLop = table.Column<int>(type: "int", nullable: false),
                    SoBaoDanh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinh", x => x.MaHocSinh);
                    table.ForeignKey(
                        name: "FK_HocSinh_Lop_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocSinh_NguoiDung_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GiaoVien",
                columns: new[] { "MaGiaoVien", "MaNguoiDung", "TrangThai" },
                values: new object[] { 1, 2, true });

            migrationBuilder.InsertData(
                table: "Lop",
                columns: new[] { "MaLop", "KyHieuLop", "NamHoc", "TenLop" },
                values: new object[] { 1, "12A1", "2025-2026", "Lop 12A1" });

            migrationBuilder.InsertData(
                table: "MonHoc",
                columns: new[] { "MaMonHoc", "KyHieuMon", "TenMonHoc" },
                values: new object[,]
                {
                    { 1, "TOAN", "Toan" },
                    { 2, "LY", "Vat ly" },
                    { 3, "HOA", "Hoa hoc" },
                    { 4, "SINH", "Sinh hoc" },
                    { 5, "ANH", "Tieng Anh" }
                });

            migrationBuilder.InsertData(
                table: "NguoiDung",
                columns: new[] { "MaNguoiDung", "MaVaiTro", "MatKhau", "NgayTao", "TenDangNhap", "TrangThai" },
                values: new object[,]
                {
                    { 1, 1, "123", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", true },
                    { 2, 2, "123", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gv01", true },
                    { 3, 3, "123", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hs01", true }
                });

            migrationBuilder.InsertData(
                table: "VaiTro",
                columns: new[] { "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "GiaoVien" },
                    { 3, "HocSinh" }
                });

            migrationBuilder.InsertData(
                table: "HocSinh",
                columns: new[] { "MaHocSinh", "MaLop", "MaNguoiDung", "SoBaoDanh", "TrangThai" },
                values: new object[] { 1, 1, 3, "HS001", true });

            migrationBuilder.CreateIndex(
                name: "IX_HocSinh_MaLop",
                table: "HocSinh",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinh_MaNguoiDung",
                table: "HocSinh",
                column: "MaNguoiDung");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CauHoi");

            migrationBuilder.DropTable(
                name: "ChiTietBaiLam");

            migrationBuilder.DropTable(
                name: "ChiTietDeThi");

            migrationBuilder.DropTable(
                name: "ChuyenDe");

            migrationBuilder.DropTable(
                name: "DanhSachDuThi");

            migrationBuilder.DropTable(
                name: "DapAn");

            migrationBuilder.DropTable(
                name: "DeThi");

            migrationBuilder.DropTable(
                name: "DotThi");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "HocSinh");

            migrationBuilder.DropTable(
                name: "HoSoCaNhan");

            migrationBuilder.DropTable(
                name: "LuotThi");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "NhatKyHeThong");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "ThongBaoNguoiNhan");

            migrationBuilder.DropTable(
                name: "VaiTro");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
