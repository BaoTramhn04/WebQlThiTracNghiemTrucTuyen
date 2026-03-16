using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models
{
    public class DapAn
    {
        [Key]
        public int MaDapAn { get; set; }

        public int MaCauHoi { get; set; }

        [ForeignKey("MaCauHoi")]
        public CauHoi? CauHoi { get; set; }

        [Required]
        public string NoiDung { get; set; } = string.Empty;

        public bool LaDapAnDung { get; set; }
    }
}