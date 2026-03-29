using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class AddDanhSachDuThiSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DanhSachDuThi",
                columns: new[] { "MaDotThi", "MaHocSinh", "DuocPhepThi", "GhiChu" },
                values: new object[,]
                {
                    { 1, 1, false, null },
                    { 1, 2, false, null },
                    { 1, 3, false, null },
                    { 1, 4, false, null },
                    { 1, 5, false, null },
                    { 1, 6, false, null },
                    { 1, 7, false, null },
                    { 1, 8, false, null },
                    { 1, 9, false, null },
                    { 1, 10, false, null },
                    { 1, 11, false, null },
                    { 1, 12, false, null },
                    { 1, 13, false, null },
                    { 1, 14, false, null },
                    { 1, 15, false, null },
                    { 1, 16, false, null },
                    { 1, 17, false, null },
                    { 1, 18, false, null },
                    { 1, 19, false, null },
                    { 1, 20, false, null },
                    { 1, 21, false, null },
                    { 1, 22, false, null },
                    { 1, 23, false, null },
                    { 1, 24, false, null },
                    { 1, 25, false, null },
                    { 1, 26, false, null },
                    { 1, 27, false, null },
                    { 1, 28, false, null },
                    { 1, 29, false, null },
                    { 1, 30, false, null },
                    { 2, 31, false, null },
                    { 2, 32, false, null },
                    { 2, 33, false, null },
                    { 2, 34, false, null },
                    { 2, 35, false, null },
                    { 2, 36, false, null },
                    { 2, 37, false, null },
                    { 2, 38, false, null },
                    { 2, 39, false, null },
                    { 2, 40, false, null },
                    { 2, 41, false, null },
                    { 2, 42, false, null },
                    { 2, 43, false, null },
                    { 2, 44, false, null },
                    { 2, 45, false, null },
                    { 2, 46, false, null },
                    { 2, 47, false, null },
                    { 2, 48, false, null },
                    { 2, 49, false, null },
                    { 2, 50, false, null },
                    { 2, 51, false, null },
                    { 2, 52, false, null },
                    { 2, 53, false, null },
                    { 2, 54, false, null },
                    { 2, 55, false, null },
                    { 2, 56, false, null },
                    { 2, 57, false, null },
                    { 2, 58, false, null },
                    { 2, 59, false, null },
                    { 2, 60, false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 31 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 32 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 33 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 36 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 38 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 39 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 41 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 42 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 45 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 46 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 47 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 48 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 49 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 50 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 51 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 52 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 53 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 54 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 55 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 56 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 57 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 58 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "DanhSachDuThi",
                keyColumns: new[] { "MaDotThi", "MaHocSinh" },
                keyValues: new object[] { 2, 60 });
        }
    }
}
