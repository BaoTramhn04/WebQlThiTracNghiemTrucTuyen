using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class MonHoc
    {
        [Key]
        public int MaMonHoc { get; set; }

        [Required]
        [StringLength(20)]
        public string KyHieuMon { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenMonHoc { get; set; } = string.Empty;
    }
}
