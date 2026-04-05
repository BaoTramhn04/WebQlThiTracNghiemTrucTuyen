using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("MaMonHoc")]
        public MonHoc MonHoc { get; set; }

        public ICollection<CauHoi> CauHois { get; set; } = new List<CauHoi>();
    }
}
