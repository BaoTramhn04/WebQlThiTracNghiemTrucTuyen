using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTrangThaiFromMonHoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "MonHoc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "MonHoc",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "MaMonHoc",
                keyValue: 1,
                column: "TrangThai",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "MaMonHoc",
                keyValue: 2,
                column: "TrangThai",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "MaMonHoc",
                keyValue: 3,
                column: "TrangThai",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "MaMonHoc",
                keyValue: 4,
                column: "TrangThai",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "MaMonHoc",
                keyValue: 5,
                column: "TrangThai",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "MaMonHoc",
                keyValue: 6,
                column: "TrangThai",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonHoc",
                keyColumn: "MaMonHoc",
                keyValue: 7,
                column: "TrangThai",
                value: true);
        }
    }
}
