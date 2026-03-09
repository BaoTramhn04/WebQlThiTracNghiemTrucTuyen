using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class DanhSachDuThi
    {
        public int MaDotThi { get; set; }

        public int MaHocSinh { get; set; }

        public bool DuocPhepThi { get; set; }

        [StringLength(255)]
        public string? GhiChu { get; set; }
    }
}
