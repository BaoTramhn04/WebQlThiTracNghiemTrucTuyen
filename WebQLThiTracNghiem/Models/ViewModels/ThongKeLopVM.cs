namespace WebQLThiTracNghiem.Models.ViewModels
{
    public class ThongKeLopVM
    {
        public string TenLop { get; set; }
        public int SoHocSinh { get; set; }

        public int SoDotThi { get; set; }

        public double DiemTB { get; set; }
        public double TyLeDat { get; set; }

        public int SoGioi { get; set; }
        public int SoKha { get; set; }
        public int SoTB { get; set; }
        public int SoYeu { get; set; }

        public int Rank { get; set; }

        public List<ThongKeMonVM> ThongKeMon { get; set; }
    }
    public class ThongKeMonVM
    {
        public string Mon { get; set; }
        public int SoLuot { get; set; }
        public double DiemTB { get; set; }
    }
}