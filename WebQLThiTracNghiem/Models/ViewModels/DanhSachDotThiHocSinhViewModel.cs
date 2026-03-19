namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class DanhSachDotThiHocSinhViewModel
    {
        public int MaDotThi { get; set; }
        public string TenDotThi { get; set; } = string.Empty;
        public string TenDeThi { get; set; } = string.Empty;
        public string MonThi { get; set; } = string.Empty;
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int ThoiGianLamBai { get; set; }
        public int SoLanThiToiDa { get; set; }
        public bool TrangThai { get; set; }
        public bool DangMoHienThi { get; set; }
        public string TrangThaiHienThi { get; set; } = string.Empty;
        public bool DuocPhepThi { get; set; }
        public string? GhiChu { get; set; }
        public bool ConLuotThi { get; set; }
    }
}