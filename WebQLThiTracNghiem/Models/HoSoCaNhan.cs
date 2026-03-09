using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class HoSoCaNhan
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; } = string.Empty;

        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string? GioiTinh { get; set; }

        [StringLength(20)]
        public string? SoDienThoai { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(255)]
        public string? DiaChi { get; set; }

        [StringLength(255)]
        public string? AnhDaiDien { get; set; }
    }
}

