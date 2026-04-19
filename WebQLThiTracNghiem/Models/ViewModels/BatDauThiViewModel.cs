namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class BatDauThiViewModel
    {
        // ===== THÔNG TIN HỌC SINH (từ HoSoCaNhan + HocSinh) =====
        public string HoTen { get; set; } = string.Empty;
        public int MaHocSinh { get; set; }

        public string SoBaoDanh { get; set; } = string.Empty;

        public string Lop { get; set; } = string.Empty;

        public DateTime? NgaySinh { get; set; }

        public string? GioiTinh { get; set; }

        public string? AvatarUrl { get; set; }


        // ===== DANH SÁCH ĐỢT THI =====
        public List<DotThiItemVM> DanhSachDotThi { get; set; } = new();
    }


    public class DotThiItemVM
    {
        public int MaDotThi { get; set; }

        public string TenDotThi { get; set; } = string.Empty;

        public string MonThi { get; set; } = string.Empty;

        public int ThoiGianLamBai { get; set; }

        public DateTime ThoiGianBatDau { get; set; }

        public DateTime ThoiGianKetThuc { get; set; }

        public bool DaNopBai { get; set; }

        // ===== TRẠNG THÁI =====
        public bool DuocPhanCong { get; set; }

        public bool DangMo { get; set; }

        public bool SapDienRa { get; set; }
        public bool DaLam { get; set; }
    }
}