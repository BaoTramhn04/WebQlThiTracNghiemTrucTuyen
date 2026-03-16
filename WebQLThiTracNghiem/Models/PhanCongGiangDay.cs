using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class PhanCongGiangDay
    {
        [Key]
        public int MaPhanCong { get; set; }

        [Required]
        public int MaGiaoVien { get; set; }

        [Required]
        public int MaLop { get; set; }

        [Required]
        public int MaMon { get; set; }

        // navigation
        [ForeignKey("MaGiaoVien")]
        public GiaoVien GiaoVien { get; set; }

        [ForeignKey("MaLop")]
        public Lop Lop { get; set; }

        [ForeignKey("MaMon")]
        public MonHoc MonHoc { get; set; }
    }
}