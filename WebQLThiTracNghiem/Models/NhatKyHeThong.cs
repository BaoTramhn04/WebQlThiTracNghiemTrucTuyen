using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class NhatKyHeThong
    {
        [Key]
        public int MaNhatKy { get; set; }

        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(200)]
        public string HanhDong { get; set; } = string.Empty;

        [StringLength(100)]
        public string? DoiTuongTacDong { get; set; }

        [StringLength(50)]
        public string? MaBanGhiTacDong { get; set; }

        public DateTime ThoiGianThucHien { get; set; }

        [StringLength(50)]
        public string? DiaChiIP { get; set; }
    }
}
