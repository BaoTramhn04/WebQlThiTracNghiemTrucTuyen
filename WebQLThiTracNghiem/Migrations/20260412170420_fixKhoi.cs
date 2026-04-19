using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class fixKhoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Khoi",
                table: "ChuyenDe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 1,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 2,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 3,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 4,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 5,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 6,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 7,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 8,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 9,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 10,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 11,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 12,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 13,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 14,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 15,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 16,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 17,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 18,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 19,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 20,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 21,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 22,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 23,
                column: "Khoi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenDe",
                keyColumn: "MaChuyenDe",
                keyValue: 24,
                column: "Khoi",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Khoi",
                table: "ChuyenDe");
        }
    }
}
