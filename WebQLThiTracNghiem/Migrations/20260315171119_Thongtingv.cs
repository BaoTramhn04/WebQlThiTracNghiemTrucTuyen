using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class Thongtingv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "HoSoCaNhan");

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 1,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000000" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 100,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000100" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 101,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1986, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000101" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 102,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1987, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000102" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 103,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1988, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000103" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 104,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1989, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000104" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 105,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1990, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000105" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 106,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1991, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000106" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 107,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1992, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000107" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 108,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000108" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 109,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1994, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000109" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 110,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1985, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000110" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 111,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1986, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000111" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 112,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1987, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000112" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 113,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000113" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 114,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1989, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000114" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 115,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1990, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000115" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 116,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1991, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000116" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 117,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1992, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000117" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 118,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", new DateTime(1993, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000118" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 119,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(1994, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0900000119" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 500,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Vy", new DateTime(2007, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911434835" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 501,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Chi", new DateTime(2007, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915456722" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 502,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Linh", new DateTime(2007, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913297378" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 503,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Vy", new DateTime(2007, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911019515" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 504,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Ngọc", new DateTime(2007, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912263056" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 505,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Tuấn", new DateTime(2007, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911841856" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 506,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Giang", new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918994739" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 507,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Dũng", new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914457024" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 508,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Linh", new DateTime(2007, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915917403" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 509,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Yến", new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911908862" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 510,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Chi", new DateTime(2007, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911516554" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 511,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Chi", new DateTime(2007, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914250589" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 512,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Giang", new DateTime(2007, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916282053" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 513,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Ngọc", new DateTime(2007, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911385799" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 514,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Lan", new DateTime(2007, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916684190" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 515,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Dũng", new DateTime(2007, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918327159" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 516,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Lan", new DateTime(2007, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911607280" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 517,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Dũng", new DateTime(2007, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918212612" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 518,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Nam", new DateTime(2007, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914742468" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 519,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Bình", new DateTime(2007, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916336986" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 520,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Mai", new DateTime(2007, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917777867" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 521,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Mai", new DateTime(2007, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911835438" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 522,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Mai", new DateTime(2007, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916024230" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 523,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Chi", new DateTime(2007, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917278273" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 524,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Lan", new DateTime(2007, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914346357" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 525,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Phong", new DateTime(2007, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918667781" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 526,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Hải", new DateTime(2007, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917882742" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 527,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Hà", new DateTime(2007, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919559135" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 528,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Hải", new DateTime(2007, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915616230" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 529,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Dũng", new DateTime(2007, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916364607" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 530,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Linh", new DateTime(2007, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914035162" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 531,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Tuấn", new DateTime(2007, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915580246" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 532,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Phong", new DateTime(2007, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913991073" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 533,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Tuấn", new DateTime(2007, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914572340" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 534,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Ngọc", new DateTime(2007, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913768552" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 535,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Anh", new DateTime(2007, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916812757" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 536,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Ngọc", new DateTime(2007, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913251587" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 537,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Quang", new DateTime(2007, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914544708" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 538,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Bình", new DateTime(2007, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912508102" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 539,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Hà", new DateTime(2007, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912372387" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 540,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Yến", new DateTime(2007, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912412262" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 541,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Thảo", new DateTime(2007, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914528616" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 542,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Yến", new DateTime(2007, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918580514" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 543,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Hà", new DateTime(2007, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911160677" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 544,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Linh", new DateTime(2007, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914399424" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 545,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Hưng", new DateTime(2007, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911995985" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 546,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Chi", new DateTime(2007, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916263359" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 547,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Giang", new DateTime(2007, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911514147" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 548,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Giang", new DateTime(2007, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919815222" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 549,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Nam", new DateTime(2007, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919335865" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 550,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Dũng", new DateTime(2007, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911841230" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 551,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Hà", new DateTime(2007, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917334721" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 552,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Lan", new DateTime(2007, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916086578" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 553,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Hưng", new DateTime(2007, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911469358" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 554,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Phong", new DateTime(2007, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918943221" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 555,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Trang", new DateTime(2007, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913783211" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 556,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Thảo", new DateTime(2007, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914970545" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 557,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Phong", new DateTime(2007, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917855788" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 558,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Hưng", new DateTime(2007, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913092783" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 559,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Dũng", new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919033329" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 560,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Quang", new DateTime(2007, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918293031" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 561,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Chi", new DateTime(2007, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919544706" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 562,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Vy", new DateTime(2007, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911253947" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 563,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Bình", new DateTime(2007, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911882961" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 564,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Hà", new DateTime(2007, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916384808" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 565,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Mai", new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919535395" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 566,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Vy", new DateTime(2007, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914880631" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 567,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Ngọc", new DateTime(2007, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914700453" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 568,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Vy", new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916895056" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 569,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Hưng", new DateTime(2007, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915064736" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 570,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Tuấn", new DateTime(2007, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911577829" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 571,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Giang", new DateTime(2007, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915361905" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 572,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Mai", new DateTime(2007, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915948411" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 573,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Giang", new DateTime(2007, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913383665" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 574,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Hưng", new DateTime(2007, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913234551" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 575,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Thảo", new DateTime(2007, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917683603" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 576,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Chi", new DateTime(2007, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915258374" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 577,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Thảo", new DateTime(2007, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916122275" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 578,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Anh", new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913658736" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 579,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Hưng", new DateTime(2007, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913926775" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 580,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Lan", new DateTime(2007, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918959162" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 581,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Ngọc", new DateTime(2007, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912984009" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 582,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Nam", new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919396609" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 583,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Mai", new DateTime(2007, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919622388" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 584,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Hưng", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912091545" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 585,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Tuấn", new DateTime(2007, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916206227" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 586,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Chi", new DateTime(2007, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917304157" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 587,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Mai", new DateTime(2007, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918741203" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 588,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Phong", new DateTime(2007, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916902105" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 589,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Thảo", new DateTime(2007, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919735958" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 590,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Anh", new DateTime(2007, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914057143" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 591,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Yến", new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917765630" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 592,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Phong", new DateTime(2007, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917520265" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 593,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Hà", new DateTime(2007, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919841377" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 594,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Lan", new DateTime(2007, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912985819" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 595,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Yến", new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912665867" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 596,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Mai", new DateTime(2007, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914634612" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 597,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Hưng", new DateTime(2007, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919381274" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 598,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Yến", new DateTime(2007, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915444213" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 599,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Anh", new DateTime(2007, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917243362" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 600,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Bình", new DateTime(2007, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919160580" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 601,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Yến", new DateTime(2007, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918117178" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 602,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Ngọc", new DateTime(2007, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917058666" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 603,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Vy", new DateTime(2007, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913993717" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 604,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Vy", new DateTime(2007, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918257894" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 605,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Phong", new DateTime(2007, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915358114" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 606,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Anh", new DateTime(2007, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917862568" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 607,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Chi", new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915396191" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 608,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Lan", new DateTime(2007, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914376531" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 609,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Trang", new DateTime(2007, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914032762" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 610,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Phong", new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919449497" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 611,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Nam", new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912514011" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 612,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Hưng", new DateTime(2007, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918383973" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 613,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Anh", new DateTime(2007, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911720070" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 614,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Vy", new DateTime(2007, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916477855" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 615,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Hưng", new DateTime(2007, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916429100" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 616,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Anh", new DateTime(2007, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915905413" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 617,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Hưng", new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914843034" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 618,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Chi", new DateTime(2007, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916275480" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 619,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Phong", new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919956531" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 620,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Phong", new DateTime(2007, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915371221" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 621,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Thảo", new DateTime(2007, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913062477" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 622,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Nam", new DateTime(2007, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917665204" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 623,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Hải", new DateTime(2007, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916112794" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 624,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Chi", new DateTime(2007, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912343768" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 625,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Tuấn", new DateTime(2007, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915263869" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 626,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Nam", new DateTime(2007, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919066580" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 627,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Ngọc", new DateTime(2007, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918377875" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 628,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Hải", new DateTime(2007, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918168573" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 629,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Nam", new DateTime(2007, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918406333" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 630,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Vy", new DateTime(2007, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917451483" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 631,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Lan", new DateTime(2007, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915848494" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 632,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Lan", new DateTime(2007, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915582927" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 633,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Trang", new DateTime(2007, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919350079" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 634,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Giang", new DateTime(2007, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917994798" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 635,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Hải", new DateTime(2007, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919940800" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 636,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Linh", new DateTime(2007, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912999715" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 637,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Hưng", new DateTime(2007, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915035987" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 638,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Lan", new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918344798" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 639,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Hà", new DateTime(2007, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917864163" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 640,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Dũng", new DateTime(2007, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913854873" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 641,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Phong", new DateTime(2007, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912119828" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 642,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Hải", new DateTime(2007, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917578124" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 643,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Ngọc", new DateTime(2007, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911175386" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 644,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Vy", new DateTime(2007, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913380694" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 645,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Ngọc", new DateTime(2007, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918460976" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 646,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Giang", new DateTime(2007, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918319454" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 647,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Anh", new DateTime(2007, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911078072" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 648,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Chi", new DateTime(2007, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912310752" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 649,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Chi", new DateTime(2007, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915585699" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 650,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Hà", new DateTime(2007, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914583090" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 651,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Yến", new DateTime(2007, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913902059" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 652,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Tuấn", new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916981092" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 653,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Tuấn", new DateTime(2007, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912127818" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 654,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Bình", new DateTime(2007, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919663760" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 655,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Hải", new DateTime(2007, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912562528" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 656,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Anh", new DateTime(2007, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912383785" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 657,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Chi", new DateTime(2007, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915753593" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 658,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Bình", new DateTime(2007, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917622105" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 659,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Hải", new DateTime(2007, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912477373" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 660,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Vy", new DateTime(2007, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917660138" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 661,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Hưng", new DateTime(2007, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919460828" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 662,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Phong", new DateTime(2007, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919990727" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 663,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Anh", new DateTime(2007, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917854612" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 664,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Mai", new DateTime(2007, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917918031" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 665,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Bình", new DateTime(2007, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915762731" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 666,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Ngọc", new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919256097" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 667,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Yến", new DateTime(2007, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917145541" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 668,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Chi", new DateTime(2007, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911656945" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 669,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Linh", new DateTime(2007, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911127294" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 670,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Tuấn", new DateTime(2007, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915480401" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 671,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Dũng", new DateTime(2007, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916089534" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 672,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Ngọc", new DateTime(2007, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916022840" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 673,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Nam", new DateTime(2007, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916086715" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 674,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Tuấn", new DateTime(2007, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913946421" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 675,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Ngọc", new DateTime(2007, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918445585" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 676,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Ngọc", new DateTime(2007, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917959727" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 677,
                columns: new[] { "DiaChi", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", new DateTime(2007, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917182772" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 678,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Nam", new DateTime(2007, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918581384" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 679,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Nam", new DateTime(2007, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912015078" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 680,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Dũng", new DateTime(2007, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919776181" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 681,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Thảo", new DateTime(2007, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914145258" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 682,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Dũng", new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913184109" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 683,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Chi", new DateTime(2007, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917118408" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 684,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Hưng", new DateTime(2007, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911098334" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 685,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Bình", new DateTime(2007, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911504680" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 686,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Hà", new DateTime(2007, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919016974" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 687,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Hải", new DateTime(2007, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919732497" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 688,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Ngọc", new DateTime(2007, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913668651" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 689,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Phong", new DateTime(2007, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914382969" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 690,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Anh", new DateTime(2007, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915869717" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 691,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Ngọc", new DateTime(2007, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911703142" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 692,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Mai", new DateTime(2007, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918145130" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 693,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Phong", new DateTime(2007, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915744548" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 694,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Lan", new DateTime(2007, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916381158" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 695,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Nam", new DateTime(2007, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912451128" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 696,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Nam", new DateTime(2007, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916717225" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 697,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Dũng", new DateTime(2007, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916045109" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 698,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Trang", new DateTime(2007, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919799816" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 699,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Yến", new DateTime(2007, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915736364" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 700,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Dũng", new DateTime(2007, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914698530" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 701,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Linh", new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918477566" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 702,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Hà", new DateTime(2007, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917314660" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 703,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Trang", new DateTime(2007, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912343635" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 704,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Quang", new DateTime(2007, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911395688" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 705,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Yến", new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918778011" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 706,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Trang", new DateTime(2007, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919430494" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 707,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Ngọc", new DateTime(2007, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912780663" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 708,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Trang", new DateTime(2007, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914641312" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 709,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Bình", new DateTime(2007, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916488179" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 710,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Trang", new DateTime(2007, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911421549" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 711,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Phong", new DateTime(2007, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916921065" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 712,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Phong", new DateTime(2007, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919772546" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 713,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Tuấn", new DateTime(2007, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912655084" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 714,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Nam", new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917884514" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 715,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Hưng", new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919099027" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 716,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Ngọc", new DateTime(2007, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912299125" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 717,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Mai", new DateTime(2007, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916505265" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 718,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Hưng", new DateTime(2007, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911621306" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 719,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Mai", new DateTime(2007, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912552810" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 720,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Lan", new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912731839" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 721,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Ngọc", new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917529958" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 722,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Trang", new DateTime(2007, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918718473" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 723,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Nam", new DateTime(2007, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919210364" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 724,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Phong", new DateTime(2007, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913981106" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 725,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Bình", new DateTime(2007, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916375911" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 726,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Anh", new DateTime(2007, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919849962" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 727,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Anh", new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914379068" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 728,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Yến", new DateTime(2007, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914358240" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 729,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Giang", new DateTime(2007, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918852301" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 730,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Chi", new DateTime(2007, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916431795" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 731,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Lan", new DateTime(2007, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911715533" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 732,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Yến", new DateTime(2007, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917151443" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 733,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Anh", new DateTime(2007, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916239041" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 734,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Yến", new DateTime(2007, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911959442" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 735,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Hà", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919475581" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 736,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Hải", new DateTime(2007, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911437118" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 737,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Tuấn", new DateTime(2007, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914449055" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 738,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Dũng", new DateTime(2007, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916881883" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 739,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Bình", new DateTime(2007, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917579224" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 740,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Quang", new DateTime(2007, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916632398" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 741,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Trang", new DateTime(2007, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911104444" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 742,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Bình", new DateTime(2007, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916900746" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 743,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Nam", new DateTime(2007, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913754280" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 744,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Vy", new DateTime(2007, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919691471" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 745,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Lan", new DateTime(2007, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913104149" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 746,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Phong", new DateTime(2007, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918849730" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 747,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Hải", new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912446650" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 748,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Nam", new DateTime(2007, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919788724" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 749,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Mai", new DateTime(2007, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915215005" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 750,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Anh", new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917094690" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 751,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Trang", new DateTime(2007, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913252402" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 752,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Giang", new DateTime(2007, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912899322" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 753,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Hải", new DateTime(2007, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918242563" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 754,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Linh", new DateTime(2007, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917189402" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 755,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Lan", new DateTime(2007, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916423158" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 756,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Mai", new DateTime(2007, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919065124" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 757,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Trang", new DateTime(2007, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916838084" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 758,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Vy", new DateTime(2007, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918648134" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 759,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Nam", new DateTime(2007, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917465507" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 760,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Mai", new DateTime(2007, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916137562" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 761,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Bình", new DateTime(2007, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914204407" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 762,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Trang", new DateTime(2007, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913859148" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 763,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Thảo", new DateTime(2007, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913472534" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 764,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Vy", new DateTime(2007, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913102407" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 765,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Vy", new DateTime(2007, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911929419" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 766,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Chi", new DateTime(2007, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917198941" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 767,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Ngọc", new DateTime(2007, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916709898" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 768,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Thảo", new DateTime(2007, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913983686" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 769,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Hải", new DateTime(2007, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919470232" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 770,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Anh", new DateTime(2007, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911479877" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 771,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Thảo", new DateTime(2007, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915455649" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 772,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Giang", new DateTime(2007, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912247994" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 773,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Quang", new DateTime(2007, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919948390" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 774,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Chi", new DateTime(2007, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919843324" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 775,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Bình", new DateTime(2007, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912557827" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 776,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Anh", new DateTime(2007, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911654281" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 777,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Phong", new DateTime(2007, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911988132" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 778,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Yến", new DateTime(2007, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915025435" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 779,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Dũng", new DateTime(2007, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916118756" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 780,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Anh", new DateTime(2007, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919473698" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 781,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Hưng", new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916350056" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 782,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Lan", new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918277697" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 783,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Thảo", new DateTime(2007, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914227796" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 784,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Quang", new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913463924" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 785,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Giang", new DateTime(2007, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913712824" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 786,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Mai", new DateTime(2007, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918387648" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 787,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Hải", new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915925437" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 788,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Yến", new DateTime(2007, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911966648" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 789,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Anh", new DateTime(2007, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915516617" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 790,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Yến", new DateTime(2007, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914262793" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 791,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Thảo", new DateTime(2007, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917674218" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 792,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Hải", new DateTime(2007, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911465936" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 793,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Hà", new DateTime(2007, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911671932" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 794,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Thảo", new DateTime(2007, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914764628" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 795,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Lan", new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919871474" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 796,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Thảo", new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916423111" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 797,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Vy", new DateTime(2007, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918340822" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 798,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Nam", new DateTime(2007, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919121987" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 799,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Hải", new DateTime(2007, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911046888" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 800,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Lan", new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919222476" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 801,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Hưng", new DateTime(2007, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913968181" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 802,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Vy", new DateTime(2007, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915929707" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 803,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Giang", new DateTime(2007, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912138620" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 804,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Yến", new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918264279" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 805,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Hải", new DateTime(2007, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912398365" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 806,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Anh", new DateTime(2007, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911148836" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 807,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Hưng", new DateTime(2007, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913258867" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 808,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Nam", new DateTime(2007, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918984260" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 809,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Vy", new DateTime(2007, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915760590" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 810,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Yến", new DateTime(2007, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913932366" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 811,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Giang", new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911017139" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 812,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Quang", new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914329531" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 813,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Trần Minh Anh", new DateTime(2007, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912539171" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 814,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Nam", new DateTime(2007, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918981746" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 815,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Linh", new DateTime(2007, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917898494" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 816,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Giang", new DateTime(2007, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917759734" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 817,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Trần Minh Ngọc", new DateTime(2007, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911706949" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 818,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Dũng", new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911009237" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 819,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phan Quốc Ngọc", new DateTime(2007, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918010667" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 820,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Thảo", new DateTime(2007, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917338141" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 821,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Dũng", new DateTime(2007, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915275924" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 822,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Phạm Nhật Linh", new DateTime(2007, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916734781" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 823,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Bùi Tiến Hải", new DateTime(2007, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917047675" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 824,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Giang", new DateTime(2007, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915075380" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 825,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Tuấn", new DateTime(2007, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911455419" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 826,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Tuấn", new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916952443" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 827,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Phong", new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914686279" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 828,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Hà", new DateTime(2007, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915919013" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 829,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Linh", new DateTime(2007, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918772368" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 830,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Anh", new DateTime(2007, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912880114" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 831,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Bình", new DateTime(2007, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919901745" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 832,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Nguyễn Hoàng Chi", new DateTime(2007, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917794467" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 833,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Vy", new DateTime(2007, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911154865" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 834,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Yến", new DateTime(2007, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913741030" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 835,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Nam", new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912901779" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 836,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Giang", new DateTime(2007, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919136298" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 837,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Thảo", new DateTime(2007, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915947245" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 838,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Yến", new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916755274" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 839,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Tuấn", new DateTime(2007, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917548334" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 840,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Hải", new DateTime(2007, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913653079" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 841,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Lan", new DateTime(2007, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917387957" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 842,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Phong", new DateTime(2007, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913585573" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 843,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Yến", new DateTime(2007, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913411857" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 844,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đặng Như Vy", new DateTime(2007, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917329363" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 845,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Bình", new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914522448" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 846,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Nguyễn Hoàng Lan", new DateTime(2007, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916220386" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 847,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Ngọc", new DateTime(2007, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915186325" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 848,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phạm Nhật Hải", new DateTime(2007, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915543574" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 849,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đặng Như Lan", new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915592915" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 850,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Bùi Tiến Yến", new DateTime(2007, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912579993" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 851,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Đỗ Xuân Mai", new DateTime(2007, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911497655" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 852,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Đỗ Xuân Hưng", new DateTime(2007, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917272519" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 853,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Phan Quốc Vy", new DateTime(2007, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917998008" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 854,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Lê Hà Ngọc", new DateTime(2007, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914704572" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 855,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Hoàng Hải Mai", new DateTime(2007, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912194160" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 856,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Lê Hà Chi", new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914112624" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 857,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Vũ Thái Linh", new DateTime(2007, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918644110" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 858,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nam", "Vũ Thái Hưng", new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917164884" });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 859,
                columns: new[] { "DiaChi", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "Hà Nội", "Nữ", "Hoàng Hải Vy", new DateTime(2007, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919203324" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "HoSoCaNhan",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 1,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 100,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 101,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 102,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 103,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 104,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 105,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 106,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 107,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 108,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 109,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 110,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 111,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 112,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 113,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 114,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 115,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 116,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 117,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 118,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 119,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 500,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 501,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 502,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 503,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 504,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 505,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 506,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 507,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 508,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 509,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 510,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 511,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 512,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 513,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 514,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 515,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 516,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 517,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 518,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 519,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 520,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 521,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 522,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 523,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 524,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 525,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 526,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 527,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 528,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 529,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 530,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 531,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 532,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 533,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 534,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 535,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 536,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 537,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 538,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 539,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 540,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 541,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 542,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 543,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 544,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 545,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 546,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 547,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 548,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 549,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 550,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 551,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 552,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 553,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 554,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 555,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 556,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 557,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 558,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 559,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 560,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 561,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 562,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 563,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 564,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 565,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 566,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 567,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 568,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 569,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 570,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 571,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 572,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 573,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 574,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 575,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 576,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 577,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 578,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 579,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 580,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 581,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 582,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 583,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 584,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 585,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 586,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 587,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 588,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 589,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 590,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 591,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 592,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 593,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 594,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 595,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 596,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 597,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 598,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 599,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 600,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 601,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 602,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 603,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 604,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 605,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 606,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 607,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 608,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 609,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 610,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 611,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 612,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 613,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 614,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 615,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 616,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 617,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 618,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 619,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 620,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 621,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 622,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 623,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 624,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 625,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 626,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 627,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 628,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 629,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 630,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 631,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 632,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 633,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 634,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 635,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 636,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 637,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 638,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 639,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 640,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 641,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 642,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 643,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 644,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 645,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 646,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 647,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 648,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 649,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 650,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 651,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 652,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 653,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 654,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 655,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 656,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 657,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 658,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 659,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 660,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 661,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 662,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 663,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 664,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 665,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 666,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 667,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 668,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 669,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 670,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 671,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 672,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 673,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 674,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 675,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 676,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 677,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 678,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 679,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 680,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 681,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 682,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 683,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 684,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 685,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 686,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 687,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 688,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 689,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 690,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 691,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 692,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 693,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 694,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 695,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 696,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 697,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 698,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 699,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 700,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 701,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 702,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 703,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 704,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 705,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 706,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 707,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 708,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 709,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 710,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 711,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 712,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 713,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 714,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 715,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 716,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 717,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 718,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 719,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 720,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 721,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 722,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 723,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 724,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 725,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 726,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 727,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 728,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 729,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 730,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 731,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 732,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 733,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 734,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 735,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 736,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 737,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 738,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 739,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 740,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 741,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 742,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 743,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 744,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 745,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 746,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 747,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 748,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 749,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 750,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 751,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 752,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 753,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 754,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 755,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 756,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 757,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 758,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 759,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 760,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 761,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 762,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 763,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 764,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 765,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 766,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 767,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 768,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 769,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 770,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 771,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 772,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 773,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 774,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 775,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 776,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 777,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 778,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 779,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 780,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 781,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 782,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 783,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 784,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 785,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 786,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 787,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 788,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 789,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 790,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 791,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 792,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 793,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 794,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 795,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 796,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 797,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 798,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 799,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 800,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 801,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 802,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Hà", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 803,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Linh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 804,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 805,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 806,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 807,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 808,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 809,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 810,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 811,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 812,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 813,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 814,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Bình", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 815,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 816,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 817,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 818,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 819,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 820,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 821,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 822,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 823,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 824,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 825,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 826,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 827,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 828,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 829,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 830,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Dũng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 831,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 832,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 833,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 834,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 835,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Quang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 836,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 837,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Lan", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 838,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 839,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Tuấn", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 840,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Yến", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 841,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Hải", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 842,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Giang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 843,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Hoàng Hải Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 844,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 845,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Bùi Tiến Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 846,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 847,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 848,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Nguyễn Hoàng Anh", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 849,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Lê Hà Nam", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 850,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Thảo", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 851,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phạm Nhật Mai", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 852,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Trần Minh Chi", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 853,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Ngọc", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 854,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Vy", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 855,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 856,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Vũ Thái Trang", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 857,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đặng Như Phong", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 858,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Đỗ Xuân Hưng", null, null });

            migrationBuilder.UpdateData(
                table: "HoSoCaNhan",
                keyColumn: "MaNguoiDung",
                keyValue: 859,
                columns: new[] { "DiaChi", "Email", "GioiTinh", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { null, null, null, "Phan Quốc Ngọc", null, null });
        }
    }
}
