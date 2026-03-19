namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class BatDauThiViewModel
    {
        public int MaDotThi { get; set; }
        public string TenDotThi { get; set; } = string.Empty;

        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }

        public int ThoiGianLamBai { get; set; }
        public int SoLuongCauHoi { get; set; }

        public string TenDeThi { get; set; } = string.Empty;
        public string MonThi { get; set; } = string.Empty;
    }
}