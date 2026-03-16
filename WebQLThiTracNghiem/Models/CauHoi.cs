using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class CauHoi
    {
        [Key]
        public int MaCauHoi { get; set; }

        public int MaChuyenDe { get; set; }

        [ForeignKey("MaChuyenDe")]
        public ChuyenDe? ChuyenDe { get; set; }

        [Required]
        public string NoiDung { get; set; } = string.Empty;

        public int MucDo { get; set; }

        public bool TrangThai { get; set; }

        public int NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        // Navigation
        public List<DapAn>? DapAns { get; set; }
    }
}