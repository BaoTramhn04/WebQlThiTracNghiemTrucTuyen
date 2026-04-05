using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class AddNhatKy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NhatKyHeThong",
                table: "NhatKyHeThong");

            migrationBuilder.RenameTable(
                name: "NhatKyHeThong",
                newName: "NhatKyHeThongs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhatKyHeThongs",
                table: "NhatKyHeThongs",
                column: "MaNhatKy");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenDe_MaMonHoc",
                table: "ChuyenDe",
                column: "MaMonHoc");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenDe_MonHoc_MaMonHoc",
                table: "ChuyenDe",
                column: "MaMonHoc",
                principalTable: "MonHoc",
                principalColumn: "MaMonHoc",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenDe_MonHoc_MaMonHoc",
                table: "ChuyenDe");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenDe_MaMonHoc",
                table: "ChuyenDe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhatKyHeThongs",
                table: "NhatKyHeThongs");

            migrationBuilder.RenameTable(
                name: "NhatKyHeThongs",
                newName: "NhatKyHeThong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhatKyHeThong",
                table: "NhatKyHeThong",
                column: "MaNhatKy");
        }
    }
}
