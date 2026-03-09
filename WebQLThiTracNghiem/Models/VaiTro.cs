using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class VaiTro
    {
       
            [Key]
            public int MaVaiTro { get; set; }

            [Required]
            [StringLength(50)]
            public string TenVaiTro { get; set; } = string.Empty;
        }
}
