using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class ThongBao
    {
        [Key]
        public int MaThongBao { get; set; }

        [Required]
        [StringLength(200)]
        public string TieuDe { get; set; } = string.Empty;

        [Required]
        public string NoiDung { get; set; } = string.Empty;

        public int NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
