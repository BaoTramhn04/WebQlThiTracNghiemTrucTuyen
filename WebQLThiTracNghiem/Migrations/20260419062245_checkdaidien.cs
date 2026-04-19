using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class checkdaidien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 1,
                column: "LaDaiDien",
                value: true);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 3,
                column: "LaDaiDien",
                value: true);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 5,
                column: "LaDaiDien",
                value: true);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 7,
                column: "LaDaiDien",
                value: true);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 9,
                column: "LaDaiDien",
                value: true);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 11,
                column: "LaDaiDien",
                value: true);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 13,
                column: "LaDaiDien",
                value: true);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 15,
                column: "LaDaiDien",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 1,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 3,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 5,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 7,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 9,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 11,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 13,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 15,
                column: "LaDaiDien",
                value: false);
        }
    }
}
