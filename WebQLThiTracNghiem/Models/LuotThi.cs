using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class LuotThi
    {
        [Key]
        public int MaLuotThi { get; set; }

        public int MaDotThi { get; set; }

        public int MaHocSinh { get; set; }

        public int LanThi { get; set; }

        public DateTime ThoiDiemBatDau { get; set; }

        public DateTime? ThoiDiemNopBai { get; set; }

        public bool TrangThai { get; set; }
    }
}
