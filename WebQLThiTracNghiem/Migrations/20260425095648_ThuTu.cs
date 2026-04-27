using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class ThuTu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThuTu",
                table: "ChiTietDeThi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 1, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 2, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 3, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 4, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 5, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 6, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 7, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 8, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 9, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 10, 1 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 81, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 82, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 83, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 84, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 85, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 86, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 87, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 88, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 89, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 90, 2 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 161, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 162, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 163, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 164, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 165, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 166, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 167, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 168, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 169, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 170, 3 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 11, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 12, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 13, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 14, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 15, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 16, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 17, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 18, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 19, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 20, 4 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 91, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 92, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 93, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 94, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 95, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 96, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 97, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 98, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 99, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 100, 5 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 171, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 172, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 173, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 174, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 175, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 176, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 177, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 178, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 179, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 180, 6 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 21, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 22, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 23, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 24, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 25, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 26, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 27, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 28, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 29, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 30, 7 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 101, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 102, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 103, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 104, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 105, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 106, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 107, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 108, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 109, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 110, 8 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 181, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 182, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 183, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 184, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 185, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 186, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 187, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 188, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 189, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 190, 9 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 31, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 32, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 33, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 34, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 35, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 36, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 37, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 38, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 39, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 40, 10 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 111, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 112, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 113, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 114, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 115, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 116, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 117, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 118, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 119, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 120, 11 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 191, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 192, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 193, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 194, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 195, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 196, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 197, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 198, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 199, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 200, 12 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 41, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 42, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 43, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 44, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 45, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 46, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 47, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 48, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 49, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 50, 13 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 121, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 122, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 123, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 124, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 125, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 126, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 127, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 128, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 129, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 130, 14 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 201, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 202, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 203, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 204, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 205, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 206, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 207, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 208, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 209, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 210, 15 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 51, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 52, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 53, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 54, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 55, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 56, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 57, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 58, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 59, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 60, 16 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 131, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 132, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 133, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 134, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 135, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 136, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 137, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 138, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 139, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 140, 17 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 211, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 212, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 213, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 214, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 215, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 216, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 217, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 218, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 219, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 220, 18 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 61, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 62, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 63, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 64, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 65, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 66, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 67, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 68, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 69, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 70, 19 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 141, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 142, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 143, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 144, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 145, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 146, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 147, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 148, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 149, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 150, 20 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 221, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 222, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 223, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 224, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 225, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 226, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 227, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 228, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 229, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 230, 21 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 71, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 72, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 73, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 74, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 75, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 76, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 77, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 78, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 79, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 80, 22 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 151, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 152, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 153, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 154, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 155, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 156, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 157, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 158, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 159, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 160, 23 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 231, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 232, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 233, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 234, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 235, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 236, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 237, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 238, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 239, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 240, 24 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 1, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 2, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 3, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 4, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 5, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 6, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 7, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 8, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 9, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 10, 25 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 11, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 12, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 13, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 14, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 15, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 16, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 17, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 18, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 19, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 20, 26 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 21, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 22, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 23, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 24, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 25, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 26, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 27, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 28, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 29, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 30, 27 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 31, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 32, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 33, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 34, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 35, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 36, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 37, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 38, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 39, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 40, 28 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 41, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 42, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 43, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 44, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 45, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 46, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 47, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 48, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 49, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 50, 29 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 51, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 52, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 53, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 54, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 55, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 56, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 57, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 58, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 59, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 60, 30 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 61, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 62, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 63, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 64, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 65, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 66, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 67, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 68, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 69, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 70, 31 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 71, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 72, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 73, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 74, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 75, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 76, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 77, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 78, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 79, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 80, 32 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 1, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 2, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 3, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 4, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 5, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 6, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 7, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 8, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 9, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 10, 33 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 11, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 12, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 13, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 14, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 15, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 16, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 17, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 18, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 19, 34 },
                column: "ThuTu",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChiTietDeThi",
                keyColumns: new[] { "MaCauHoi", "MaDeThi" },
                keyValues: new object[] { 20, 34 },
                column: "ThuTu",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThuTu",
                table: "ChiTietDeThi");
        }
    }
}
