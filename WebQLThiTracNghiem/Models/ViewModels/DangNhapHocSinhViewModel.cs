using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class DangNhapHocSinhViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập mã học sinh")]
        public int MaHocSinh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; } = string.Empty;
    }
}