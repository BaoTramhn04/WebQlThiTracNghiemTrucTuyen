using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class ChuyenDe
    {
        [Key]
        public int MaChuyenDe { get; set; }

        public int MaMonHoc { get; set; }

        [Required]
        [StringLength(100)]
        public string TenChuyenDe { get; set; } = string.Empty;
    }
}
