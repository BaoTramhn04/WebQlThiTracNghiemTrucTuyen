using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; } = string.Empty;

        public bool TrangThai { get; set; }

        public DateTime NgayTao { get; set; }

        public int MaVaiTro { get; set; }
        public HoSoCaNhan HoSoCaNhan { get; set; }
        public int SoLanDangNhapSai { get; set; } = 0;

    }
}
