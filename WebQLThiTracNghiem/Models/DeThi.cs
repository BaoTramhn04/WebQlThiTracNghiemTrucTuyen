using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class DeThi
    {
        [Key]
        public int MaDeThi { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDeThi { get; set; } = string.Empty;

        public int MaMonHoc { get; set; }

        public int ThoiGianLamBai { get; set; }

        public bool TronCauHoi { get; set; }

        public bool TronDapAn { get; set; }

        public int NguoiTao { get; set; }
        public int Khoi { get; set; }
        public bool TrangThai { get; set; }
        [ForeignKey("MaMonHoc")]
        public MonHoc MonHoc { get; set; }
        public string LoaiDe { get; set; } // "Chung" | "Lop"
    }
}
