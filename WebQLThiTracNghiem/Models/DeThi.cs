using System.ComponentModel.DataAnnotations;

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

        public bool TrangThai { get; set; }
    }
}
