namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class KetQuaThiViewModel
    {
        public int MaLuotThi { get; set; }
        public string TenDotThi { get; set; } = string.Empty;
        public string TenDeThi { get; set; } = string.Empty;
        public string MonThi { get; set; } = string.Empty;

        public int TongSoCau { get; set; }
        public int SoCauDung { get; set; }
        public int SoCauSai { get; set; }
        public double TongDiem { get; set; }

        public DateTime ThoiDiemBatDau { get; set; }
        public DateTime? ThoiDiemNopBai { get; set; }

        public List<ChiTietKetQuaThiViewModel> ChiTietCauHoi { get; set; } = new();
    }

    public class ChiTietKetQuaThiViewModel
    {
        public int MaCauHoi { get; set; }
        public string NoiDungCauHoi { get; set; } = string.Empty;

        public int? MaDapAnChon { get; set; }
        public string NoiDungDapAnChon { get; set; } = string.Empty;

        public int? MaDapAnDung { get; set; }
        public string NoiDungDapAnDung { get; set; } = string.Empty;

        public bool DungSai { get; set; }
        public double DiemCau { get; set; }
    }
}