using System.ComponentModel.DataAnnotations;

namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class DangNhapHocSinhViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập số báo danh")]
        public string SoBaoDanh { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; } = string.Empty;
    }
}