using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class CauHoi
    {
        [Key]
        public int MaCauHoi { get; set; }

        public int MaChuyenDe { get; set; }

        [Required]
        public string NoiDung { get; set; } = string.Empty;

        public int MucDo { get; set; }

        public bool TrangThai { get; set; }

        public int NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
