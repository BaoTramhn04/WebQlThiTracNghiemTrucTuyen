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


        public ICollection<PhanCongGiangDay> PhanCongGiangDays { get; set; } = new List<PhanCongGiangDay>();

        public ICollection<DeThi> DeThis { get; set; }

    }
}