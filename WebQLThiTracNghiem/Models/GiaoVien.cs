using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class GiaoVien
    {
        [Key]
        public int MaGiaoVien { get; set; }

        public int MaNguoiDung { get; set; }

        public bool TrangThai { get; set; }
    }
}
