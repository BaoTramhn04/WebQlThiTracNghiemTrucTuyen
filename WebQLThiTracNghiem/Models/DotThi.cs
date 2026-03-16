using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class DotThi
    {
        [Key]
        public int MaDotThi { get; set; }

        public int MaDeThi { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDotThi { get; set; } = string.Empty;

        public DateTime ThoiGianBatDau { get; set; }

        public DateTime ThoiGianKetThuc { get; set; }

        public int SoLanThiToiDa { get; set; }

        public bool TrangThai { get; set; }

        [ForeignKey("MaDeThi")]
        public DeThi DeThi { get; set; }
    }
}
