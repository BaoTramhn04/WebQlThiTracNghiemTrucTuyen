namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class LamBaiThiViewModel
    {
        public int MaLuotThi { get; set; }
        public int MaDotThi { get; set; }
        public string TenDotThi { get; set; } = string.Empty;
        public string TenDeThi { get; set; } = string.Empty;
        public string MonThi { get; set; } = string.Empty;
        public int ThoiGianLamBai { get; set; }
        public DateTime ThoiDiemBatDau { get; set; }
        public DateTime ThoiDiemHetGio { get; set; }

        public List<CauHoiThiViewModel> DanhSachCauHoi { get; set; } = new();
    }

    public class CauHoiThiViewModel
    {
        public int MaCauHoi { get; set; }
        public string NoiDung { get; set; } = string.Empty;
        public double DiemCauHoi { get; set; }

        public int? MaDapAnChon { get; set; }

        public List<DapAnThiViewModel> DanhSachDapAn { get; set; } = new();
    }

    public class DapAnThiViewModel
    {
        public int MaDapAn { get; set; }
        public string NoiDung { get; set; } = string.Empty;
    }
}