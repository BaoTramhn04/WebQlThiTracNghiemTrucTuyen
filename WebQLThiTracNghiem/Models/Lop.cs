using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class Lop
    {
        [Key]
        public int MaLop { get; set; }

        [Required]
        [StringLength(20)]
        public string KyHieuLop { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenLop { get; set; } = string.Empty;

        public int Khoi { get; set; }

        [Required]
        [StringLength(20)]
        public string NamHoc { get; set; } = string.Empty;

        public ICollection<PhanCongGiangDay> PhanCongs { get; set; }
    }
}