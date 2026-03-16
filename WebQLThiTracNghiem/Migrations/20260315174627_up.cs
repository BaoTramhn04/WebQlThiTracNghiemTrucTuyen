using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DapAn_MaCauHoi",
                table: "DapAn",
                column: "MaCauHoi");

            migrationBuilder.CreateIndex(
                name: "IX_CauHoi_MaChuyenDe",
                table: "CauHoi",
                column: "MaChuyenDe");

            migrationBuilder.AddForeignKey(
                name: "FK_CauHoi_ChuyenDe_MaChuyenDe",
                table: "CauHoi",
                column: "MaChuyenDe",
                principalTable: "ChuyenDe",
                principalColumn: "MaChuyenDe",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DapAn_CauHoi_MaCauHoi",
                table: "DapAn",
                column: "MaCauHoi",
                principalTable: "CauHoi",
                principalColumn: "MaCauHoi",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CauHoi_ChuyenDe_MaChuyenDe",
                table: "CauHoi");

            migrationBuilder.DropForeignKey(
                name: "FK_DapAn_CauHoi_MaCauHoi",
                table: "DapAn");

            migrationBuilder.DropIndex(
                name: "IX_DapAn_MaCauHoi",
                table: "DapAn");

            migrationBuilder.DropIndex(
                name: "IX_CauHoi_MaChuyenDe",
                table: "CauHoi");
        }
    }
}
