using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class TaoDotThiViewModel
    {
        public string TenDotThi { get; set; }

        public int MaDeThi { get; set; }

        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }

        public int SoLanThiToiDa { get; set; }
        public int? Khoi { get; set; }

        [ValidateNever]
        public List<SelectListItem> DanhSachDeThi { get; set; }
    }
}
