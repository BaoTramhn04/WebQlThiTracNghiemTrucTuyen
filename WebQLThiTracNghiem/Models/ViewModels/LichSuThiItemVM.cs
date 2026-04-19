namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class LichSuThiItemVM
    {
      
            public int MaLuotThi { get; set; }
            public string TenMonHoc { get; set; }
            public string TenDotThi { get; set; }
            public string TenDeThi { get; set; }

            public DateTime ThoiDiemBatDau { get; set; }
            public DateTime? ThoiDiemNopBai { get; set; }

            public int TongCau { get; set; }
            public int SoDung { get; set; }
            public double Diem { get; set; }
        
    }
}
