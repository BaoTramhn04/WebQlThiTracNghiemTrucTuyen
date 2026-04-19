using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class GiaoVien
    {
        [Key]
        public int MaGiaoVien { get; set; }

        public int MaNguoiDung { get; set; }

        public bool TrangThai { get; set; }
        [ForeignKey("MaNguoiDung")]
        public NguoiDung NguoiDung { get; set; }
        public bool LaDaiDien { get; set; } = false;
        public ICollection<PhanCongGiangDay> PhanCongs { get; set; }
    }
}