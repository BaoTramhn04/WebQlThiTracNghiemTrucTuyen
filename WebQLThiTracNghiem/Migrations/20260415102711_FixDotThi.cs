using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class FixDotThi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Khoi",
                table: "Lop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Khoi",
                table: "DotThi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DotThi",
                keyColumn: "MaDotThi",
                keyValue: 1,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DotThi",
                keyColumn: "MaDotThi",
                keyValue: 2,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DotThi",
                keyColumn: "MaDotThi",
                keyValue: 3,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 1,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 2,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 3,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 4,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 5,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 6,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 7,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 8,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 9,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 10,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 11,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 12,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 13,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 14,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 15,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 16,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 17,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lop",
                keyColumn: "MaLop",
                keyValue: 18,
                column: "Khoi",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Khoi",
                table: "Lop");

            migrationBuilder.DropColumn(
                name: "Khoi",
                table: "DotThi");
        }
    }
}
