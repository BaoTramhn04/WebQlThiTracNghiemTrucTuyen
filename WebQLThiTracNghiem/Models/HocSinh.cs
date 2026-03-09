using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class HocSinh
    {
        [Key]
        public int MaHocSinh { get; set; }

        public int MaNguoiDung { get; set; }

        public int MaLop { get; set; }

        [StringLength(20)]
        public string SoBaoDanh { get; set; }

        public bool TrangThai { get; set; }

        // Navigation
        [ForeignKey("MaNguoiDung")]
        public NguoiDung NguoiDung { get; set; }

        [ForeignKey("MaLop")]
        public Lop Lop { get; set; }
    }
}

