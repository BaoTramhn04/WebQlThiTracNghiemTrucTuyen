using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class HoSoCaNhan
    {
        [Key]
        [ForeignKey("NguoiDung")]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string? GioiTinh { get; set; }

        [StringLength(15)]
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }

        public string? AnhDaiDien { get; set; }

        public NguoiDung NguoiDung { get; set; }
    }
}