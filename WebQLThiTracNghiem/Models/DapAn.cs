using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models
{
    public class DapAn
    {
        [Key]
        public int MaDapAn { get; set; }

        public int MaCauHoi { get; set; }

        [Required]
        public string NoiDung { get; set; } = string.Empty;

        public bool LaDapAnDung { get; set; }
    }
}
