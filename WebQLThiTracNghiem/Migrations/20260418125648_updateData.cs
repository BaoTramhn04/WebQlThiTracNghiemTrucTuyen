using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQLThiTracNghiem.Migrations
{
    /// <inheritdoc />
    public partial class updateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoLanDangNhapSai",
                table: "NguoiDung",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "LaDaiDien",
                table: "GiaoVien",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 1,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 2,
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
                keyValue: 4,
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
                keyValue: 6,
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
                keyValue: 8,
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
                keyValue: 10,
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
                keyValue: 12,
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
                keyValue: 14,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 15,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "GiaoVien",
                keyColumn: "MaGiaoVien",
                keyValue: 16,
                column: "LaDaiDien",
                value: false);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 1,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 100,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 101,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 102,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 103,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 104,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 105,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 106,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 107,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 108,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 109,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 110,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 111,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 112,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 113,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 114,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 115,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 500,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 501,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 502,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 503,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 504,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 505,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 506,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 507,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 508,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 509,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 510,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 511,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 512,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 513,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 514,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 515,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 516,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 517,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 518,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 519,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 520,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 521,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 522,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 523,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 524,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 525,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 526,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 527,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 528,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 529,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 530,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 531,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 532,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 533,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 534,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 535,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 536,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 537,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 538,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 539,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 540,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 541,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 542,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 543,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 544,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 545,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 546,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 547,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 548,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 549,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 550,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 551,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 552,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 553,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 554,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 555,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 556,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 557,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 558,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 559,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 560,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 561,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 562,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 563,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 564,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 565,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 566,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 567,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 568,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 569,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 570,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 571,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 572,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 573,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 574,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 575,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 576,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 577,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 578,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 579,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 580,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 581,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 582,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 583,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 584,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 585,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 586,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 587,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 588,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 589,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 590,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 591,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 592,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 593,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 594,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 595,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 596,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 597,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 598,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 599,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 600,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 601,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 602,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 603,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 604,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 605,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 606,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 607,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 608,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 609,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 610,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 611,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 612,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 613,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 614,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 615,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 616,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 617,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 618,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 619,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 620,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 621,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 622,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 623,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 624,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 625,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 626,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 627,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 628,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 629,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 630,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 631,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 632,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 633,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 634,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 635,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 636,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 637,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 638,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 639,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 640,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 641,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 642,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 643,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 644,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 645,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 646,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 647,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 648,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 649,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 650,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 651,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 652,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 653,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 654,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 655,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 656,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 657,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 658,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 659,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 660,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 661,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 662,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 663,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 664,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 665,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 666,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 667,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 668,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 669,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 670,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 671,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 672,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 673,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 674,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 675,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 676,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 677,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 678,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 679,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 680,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 681,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 682,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 683,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 684,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 685,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 686,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 687,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 688,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 689,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 690,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 691,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 692,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 693,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 694,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 695,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 696,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 697,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 698,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 699,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 700,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 701,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 702,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 703,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 704,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 705,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 706,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 707,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 708,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 709,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 710,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 711,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 712,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 713,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 714,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 715,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 716,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 717,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 718,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 719,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 720,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 721,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 722,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 723,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 724,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 725,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 726,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 727,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 728,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 729,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 730,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 731,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 732,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 733,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 734,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 735,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 736,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 737,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 738,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 739,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 740,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 741,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 742,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 743,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 744,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 745,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 746,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 747,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 748,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 749,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 750,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 751,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 752,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 753,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 754,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 755,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 756,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 757,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 758,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 759,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 760,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 761,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 762,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 763,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 764,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 765,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 766,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 767,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 768,
                column: "SoLanDangNhapSai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "MaNguoiDung",
                keyValue: 769,
                column: "SoLanDangNhapSai",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLanDangNhapSai",
                table: "NguoiDung");

            migrationBuilder.DropColumn(
                name: "LaDaiDien",
                table: "GiaoVien");
        }
    }
}
