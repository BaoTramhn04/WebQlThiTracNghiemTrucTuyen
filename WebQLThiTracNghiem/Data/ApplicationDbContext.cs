using Microsoft.EntityFrameworkCore;
using WebQLThiTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebQLThiTracNghiem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<HoSoCaNhan> HoSoCaNhan { get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<HocSinh> HocSinh { get; set; }
        public DbSet<GiaoVien> GiaoVien { get; set; }
        public DbSet<NhatKyHeThong> NhatKyHeThongs { get; set; }
        public DbSet<PhanCongGiangDay> PhanCongGiangDays { get; set; }

        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<ChuyenDe> ChuyenDe { get; set; }
        public DbSet<CauHoi> CauHoi { get; set; }
        public DbSet<DapAn> DapAn { get; set; }

        public DbSet<DeThi> DeThi { get; set; }
        public DbSet<ChiTietDeThi> ChiTietDeThi { get; set; }
        public DbSet<DotThi> DotThi { get; set; }
        public DbSet<DanhSachDuThi> DanhSachDuThi { get; set; }

        public DbSet<LuotThi> LuotThi { get; set; }
        public DbSet<ChiTietBaiLam> ChiTietBaiLam { get; set; }

        public DbSet<ThongBao> ThongBao { get; set; }
        public DbSet<ThongBaoNguoiNhan> ThongBaoNguoiNhan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChiTietDeThi>()
                .HasKey(x => new { x.MaDeThi, x.MaCauHoi });

            modelBuilder.Entity<DanhSachDuThi>()
                .HasKey(x => new { x.MaDotThi, x.MaHocSinh });

            modelBuilder.Entity<ChiTietBaiLam>()
                .HasKey(x => new { x.MaLuotThi, x.MaCauHoi });

            modelBuilder.Entity<ThongBaoNguoiNhan>()
                .HasKey(x => new { x.MaThongBao, x.MaNguoiDung });

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // ===== VAI TRÒ =====
            modelBuilder.Entity<VaiTro>().HasData(
                new VaiTro { MaVaiTro = 1, TenVaiTro = "Admin" },
                new VaiTro { MaVaiTro = 2, TenVaiTro = "GiaoVien" },
                new VaiTro { MaVaiTro = 3, TenVaiTro = "HocSinh" }
            );

            // ===== ADMIN =====
            modelBuilder.Entity<NguoiDung>().HasData(
                new NguoiDung
                {
                    MaNguoiDung = 1,
                    TenDangNhap = "admin",
                    MatKhau = "123456",
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    MaVaiTro = 1
                });

            modelBuilder.Entity<HoSoCaNhan>().HasData(
                new HoSoCaNhan
                {
                    MaNguoiDung = 1,
                    HoTen = "Quản trị hệ thống",
                    NgaySinh = new DateTime(1985, 1, 1),
                    GioiTinh = "Nam",
                    SoDienThoai = "0900000000",
                    DiaChi = "Hà Nội",
                    AnhDaiDien = null
                });

            // ===== LỚP =====
            var lopList = new List<Lop>();
            int lopId = 1;

            var danhSachKhoi = new[] { "10", "11", "12" };

            foreach (var k in danhSachKhoi)
            {
                for (int i = 1; i <= 6; i++)
                {
                    lopList.Add(new Lop
                    {
                        MaLop = lopId,
                        KyHieuLop = $"{k}A{i}",
                        TenLop = $"Lớp {k}A{i}",
                        NamHoc = "2025-2026"
                    });

                    lopId++;
                }
            }

            modelBuilder.Entity<Lop>().HasData(lopList);

            // ===== MÔN =====
            modelBuilder.Entity<MonHoc>().HasData(
                new MonHoc { MaMonHoc = 1, KyHieuMon = "TOAN", TenMonHoc = "Toán" },
                new MonHoc { MaMonHoc = 2, KyHieuMon = "LY", TenMonHoc = "Vật Lý" },
                new MonHoc { MaMonHoc = 3, KyHieuMon = "HOA", TenMonHoc = "Hóa Học" },
                new MonHoc { MaMonHoc = 4, KyHieuMon = "ANH", TenMonHoc = "Tiếng Anh" },
                new MonHoc { MaMonHoc = 5, KyHieuMon = "SINH", TenMonHoc = "Sinh Học" },
                new MonHoc { MaMonHoc = 6, KyHieuMon = "SU", TenMonHoc = "Lịch Sử" },
                new MonHoc { MaMonHoc = 7, KyHieuMon = "DIA", TenMonHoc = "Địa Lý" },
                new MonHoc { MaMonHoc = 8, KyHieuMon = "GDCD", TenMonHoc = "GDCD" }
            );

            modelBuilder.Entity<ChuyenDe>().HasData(

       // ===== TOÁN =====
       new ChuyenDe { MaChuyenDe = 1, TenChuyenDe = "Hàm số (Lớp 10)", MaMonHoc = 1, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 2, TenChuyenDe = "Đạo hàm (Lớp 11)", MaMonHoc = 1, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 3, TenChuyenDe = "Nguyên hàm - Tích phân (Lớp 12)", MaMonHoc = 1, Khoi = 12 },

       // ===== LÝ =====
       new ChuyenDe { MaChuyenDe = 4, TenChuyenDe = "Cơ học (Lớp 10)", MaMonHoc = 2, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 5, TenChuyenDe = "Dao động (Lớp 11)", MaMonHoc = 2, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 6, TenChuyenDe = "Sóng điện từ (Lớp 12)", MaMonHoc = 2, Khoi = 12 },

       // ===== HÓA =====
       new ChuyenDe { MaChuyenDe = 7, TenChuyenDe = "Nguyên tử (Lớp 10)", MaMonHoc = 3, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 8, TenChuyenDe = "Este - Lipit (Lớp 11)", MaMonHoc = 3, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 9, TenChuyenDe = "Kim loại (Lớp 12)", MaMonHoc = 3, Khoi = 12 },

       // ===== ANH =====
       new ChuyenDe { MaChuyenDe = 10, TenChuyenDe = "Thì cơ bản (Lớp 10)", MaMonHoc = 4, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 11, TenChuyenDe = "Câu điều kiện (Lớp 11)", MaMonHoc = 4, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 12, TenChuyenDe = "Mệnh đề quan hệ (Lớp 12)", MaMonHoc = 4, Khoi = 12 },

       // ===== SINH =====
       new ChuyenDe { MaChuyenDe = 13, TenChuyenDe = "Tế bào (Lớp 10)", MaMonHoc = 5, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 14, TenChuyenDe = "Di truyền (Lớp 11)", MaMonHoc = 5, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 15, TenChuyenDe = "Tiến hóa (Lớp 12)", MaMonHoc = 5, Khoi = 12 },

       // ===== SỬ =====
       new ChuyenDe { MaChuyenDe = 16, TenChuyenDe = "Lịch sử cổ đại (Lớp 10)", MaMonHoc = 6, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 17, TenChuyenDe = "Việt Nam 1945 (Lớp 11)", MaMonHoc = 6, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 18, TenChuyenDe = "Hiện đại (Lớp 12)", MaMonHoc = 6, Khoi = 12 },

       // ===== ĐỊA =====
       new ChuyenDe { MaChuyenDe = 19, TenChuyenDe = "Địa lý tự nhiên (Lớp 10)", MaMonHoc = 7, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 20, TenChuyenDe = "Địa lý kinh tế (Lớp 11)", MaMonHoc = 7, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 21, TenChuyenDe = "Địa lý Việt Nam (Lớp 12)", MaMonHoc = 7, Khoi = 12 },

       // ===== GDCD =====
       new ChuyenDe { MaChuyenDe = 22, TenChuyenDe = "Công dân (Lớp 10)", MaMonHoc = 8, Khoi = 10 },
       new ChuyenDe { MaChuyenDe = 23, TenChuyenDe = "Pháp luật (Lớp 11)", MaMonHoc = 8, Khoi = 11 },
       new ChuyenDe { MaChuyenDe = 24, TenChuyenDe = "Kinh tế (Lớp 12)", MaMonHoc = 8, Khoi = 12 }
   );

            // ===== CÂU HỎI =====
            var cauHoiList = new List<CauHoi>();
            var dapAnList = new List<DapAn>();

            int chId = 1;
            int daId = 1;
            var cauHoiThat = new List<(string q, string[] a, int correct, int chuyenDe)>
{
   // ===== TOÁN 10 =====
("Giải phương trình x^2 - 3x + 2 = 0", new[]{"x=1,2","x=±2","x=3","x=0"},1,1),
("Giá trị của √16 là?", new[]{"4","-4","8","2"},1,1),
("Giải phương trình x^2 = 9", new[]{"±3","3","-3","0"},1,1),
("Giá trị của |−7| là?", new[]{"7","-7","0","1"},1,1),
("Hàm số y = x^2 là gì?", new[]{"Parabol","Đường thẳng","Elip","Hypebol"},1,1),
("Giải bất phương trình x > 1", new[]{"(1,+∞)","(-∞,1)","[1,+∞)","(-∞,1]"},1,1),
("Tập xác định của 1/x là?", new[]{"R\\{0}","R","[0,+∞)","(-∞,0]"},1,1),
("Giá trị của 2^4 là?", new[]{"16","8","4","2"},1,1),
("Phương trình bậc nhất có dạng?", new[]{"ax+b=0","ax^2","x^3","ax^2+bx+c"},1,1),
("Hàm số đồng biến khi?", new[]{"x tăng y tăng","x tăng y giảm","x giảm y tăng","không đổi"},1,1),

  // ===== LÝ 10 =====
("Công thức vận tốc là?", new[]{"v=s/t","v=t/s","v=s*t","v=a*t"},1,4),
("Đơn vị vận tốc là?", new[]{"m/s","kg","N","J"},1,4),
("Gia tốc là gì?", new[]{"biến thiên vận tốc","quãng đường","lực","khối lượng"},1,4),
("Chuyển động thẳng đều có?", new[]{"v không đổi","v tăng","v giảm","a lớn"},1,4),
("Lực có đơn vị?", new[]{"N","kg","m","s"},1,4),
("Công thức lực?", new[]{"F=ma","F=m/a","F=a/m","F=m+a"},1,4),
("Quán tính là?", new[]{"giữ trạng thái","tăng tốc","giảm tốc","dừng"},1,4),
("Đơn vị thời gian?", new[]{"s","m","kg","N"},1,4),
("Rơi tự do có gia tốc?", new[]{"g","0","1","2"},1,4),
("Đơn vị quãng đường?", new[]{"m","s","kg","N"},1,4),

// ===== HÓA 10 =====
("H2O là chất gì?", new[]{"Nước","Oxi","Hiđro","Muối"},1,7),
("Nguyên tử gồm?", new[]{"p,n,e","p","e","n"},1,7),
("Số proton gọi là?", new[]{"số nguyên tử","số khối","số e","số n"},1,7),
("O có số hiệu?", new[]{"8","16","2","4"},1,7),
("Nguyên tử trung hòa khi?", new[]{"p=e","p>e","p<e","không có e"},1,7),
("Liên kết ion là?", new[]{"cho nhận e","chia e","mất e","nhận e"},1,7),
("NaCl là?", new[]{"muối","axit","bazơ","kim loại"},1,7),
("Electron mang điện?", new[]{"âm","dương","0","không"},1,7),
("Hóa trị O là?", new[]{"II","I","III","IV"},1,7),
("H là nguyên tố gì?", new[]{"phi kim","kim loại","khí hiếm","kiềm"},1,7),

  // ===== ANH 10 =====
("She ___ to school every day.", new[]{"go","goes","going","gone"},2,10),
("I ___ a student.", new[]{"am","is","are","be"},1,10),
("They ___ football now.", new[]{"play","playing","are playing","plays"},3,10),
("He ___ TV yesterday.", new[]{"watch","watched","watching","watches"},2,10),
("We ___ lunch at 12.", new[]{"have","has","having","had"},1,10),
("She is ___ than me.", new[]{"taller","tall","tallest","more tall"},1,10),
("I ___ to music.", new[]{"like","likes","liking","liked"},1,10),
("He ___ a book now.", new[]{"reads","reading","is reading","read"},3,10),
("They ___ happy.", new[]{"are","is","am","be"},1,10),
("I ___ English.", new[]{"learn","learns","learning","learned"},1,10),

    // ===== SINH 10 =====
("Đơn vị cơ bản của sự sống?", new[]{"Tế bào","Mô","Cơ quan","Hệ"},1,13),
("DNA nằm ở?", new[]{"Nhân","Tế bào chất","Màng","Ribosome"},1,13),
("Quang hợp diễn ra ở?", new[]{"Lá","Rễ","Thân","Hoa"},1,13),
("Enzim là?", new[]{"Xúc tác","Protein","Lipit","Gluco"},1,13),
("Hô hấp tạo ra?", new[]{"ATP","CO2","O2","H2O"},1,13),
("Tế bào nhân sơ?", new[]{"Không nhân","Có nhân","2 nhân","Nhiều"},1,13),
("Màng có tính?", new[]{"Bán thấm","Cứng","Dày","Mỏng"},1,13),
("ADN cấu tạo từ?", new[]{"Nucleotit","Axit","Protein","Lipit"},1,13),
("Gen là?", new[]{"Đoạn ADN","Protein","Enzim","Lipit"},1,13),
("TV có thành?", new[]{"Cellulose","Không có","Mỏng","Nhân"},1,13),

// ===== SỬ 10 =====
("Kim tự tháp thuộc nước nào?", new[]{"Ai Cập","Mỹ","Pháp","Anh"},1,16),
("Xã hội cổ đại có?", new[]{"Chủ nô","Công nhân","Tư sản","Nông dân"},1,16),
("La Mã thuộc?", new[]{"Châu Âu","Á","Phi","Mỹ"},1,16),
("Ấn Độ có sông?", new[]{"Hằng","Mê Kông","Nile","Amazon"},1,16),
("Trung Quốc cổ đại có?", new[]{"Tần Thủy Hoàng","Hitler","Lincoln","Napoleon"},1,16),
("Chữ tượng hình?", new[]{"Ai Cập","VN","Mỹ","Anh"},1,16),
("Công cụ đầu tiên?", new[]{"Đá","Sắt","Đồng","Vàng"},1,16),
("Thời cổ đại có giai cấp?", new[]{"Chủ nô","Tư sản","CN","ND"},1,16),
("Phương Đông cổ đại?", new[]{"Ai Cập","Mỹ","Anh","Pháp"},1,16),
("Nhà nước đầu tiên?", new[]{"Cổ đại","Hiện đại","Trung đại","Mới"},1,16),

// ===== ĐỊA 10 =====
("Thủ đô Việt Nam?", new[]{"Hà Nội","Huế","ĐN","HCM"},1,19),
("Trái Đất hình?", new[]{"Cầu","Vuông","Tam giác","Elip"},1,19),
("Xích đạo là?", new[]{"0°","90°","45°","180°"},1,19),
("VN thuộc?", new[]{"Châu Á","Âu","Phi","Mỹ"},1,19),
("Khí hậu VN?", new[]{"Nhiệt đới","Hàn","Ôn","Cận"},1,19),
("Địa hình VN?", new[]{"Đồi núi","Đồng bằng","Sa mạc","Biển"},1,19),
("Sông lớn?", new[]{"Mekong","Nile","Amazon","Danube"},1,19),
("Biển VN?", new[]{"Đông","Tây","Nam","Bắc"},1,19),
("Dân đông ở?", new[]{"Đồng bằng","Núi","Rừng","Biển"},1,19),
("Châu lớn nhất?", new[]{"Á","Âu","Phi","Mỹ"},1,19),

   // ===== GDCD 10 =====
("Công dân có quyền?", new[]{"Học tập","Ngủ","Chơi","Không làm"},1,22),
("Pháp luật là?", new[]{"Quy tắc","Ý thích","Cảm xúc","Niềm tin"},1,22),
("Công dân phải?", new[]{"Tuân thủ luật","Vi phạm","Trốn","Né"},1,22),
("Đạo đức là?", new[]{"Chuẩn mực","Tiền","Luật","Vật chất"},1,22),
("Quyền học tập là?", new[]{"Cơ bản","Phụ","Không","Ít"},1,22),
("Công dân VN phải?", new[]{"Yêu nước","Ghét nước","Trốn","Né"},1,22),
("Vi phạm luật là?", new[]{"Sai luật","Đúng luật","Hợp lệ","Bình thường"},1,22),
("Hiến pháp là?", new[]{"Luật cao nhất","Luật thường","Không","Ý kiến"},1,22),
("Trách nhiệm là?", new[]{"Nghĩa vụ","Quyền","Sở thích","Đam mê"},1,22),
("Công dân tốt là?", new[]{"Chấp hành luật","Vi phạm","Lười","Trốn"},1,22),

// ===== TOÁN 11 =====
("Đạo hàm của x^2 là?", new[]{"2x","x","x^2","2"},1,2),
("Đạo hàm của sin(x) là?", new[]{"cos(x)","sin(x)","-sin(x)","-cos(x)"},1,2),
("Đạo hàm của cos(x)?", new[]{"-sin(x)","sin(x)","cos(x)","-cos(x)"},1,2),
("Hàm số tăng khi?", new[]{"y'>0","y'<0","y=0","y không đổi"},1,2),
("Tiếp tuyến là?", new[]{"đường tiếp xúc","đường cắt","đường song song","đường vuông góc"},1,2),
("Đạo hàm của hằng số?", new[]{"0","1","x","-1"},1,2),
("y=x^3 có đạo hàm?", new[]{"3x^2","x^2","x^3","3x"},1,2),
("Cực trị khi?", new[]{"y'=0","y=0","x=0","y''=0"},1,2),
("Đạo hàm ln(x)?", new[]{"1/x","x","lnx","0"},1,2),
("Đạo hàm e^x?", new[]{"e^x","x","1","0"},1,2),
// ===== LÝ 11 =====
("Dao động điều hòa có dạng?", new[]{"sin/cos","thẳng","tròn","parabol"},1,5),
("Chu kỳ là?", new[]{"thời gian 1 dao động","tốc độ","quãng đường","gia tốc"},1,5),
("Tần số là?", new[]{"số dao động/s","thời gian","lực","khối lượng"},1,5),
("Công thức T?", new[]{"2π√(l/g)","l/g","g/l","2πl"},1,5),
("Biên độ là?", new[]{"độ lệch max","tốc độ","gia tốc","lực"},1,5),
("Đơn vị tần số?", new[]{"Hz","m","kg","s"},1,5),
("Con lắc đơn có?", new[]{"chu kỳ","vận tốc","lực","áp suất"},1,5),
("Dao động tắt dần là?", new[]{"giảm dần","tăng","đều","không đổi"},1,5),
("Cộng hưởng khi?", new[]{"f=f0","f>f0","f<f0","f=0"},1,5),
("Năng lượng dao động?", new[]{"bảo toàn","tăng","giảm","mất"},1,5),
// ===== HÓA 11 =====
("Este có nhóm?", new[]{"COO","OH","NH2","CO"},1,8),
("Công thức etyl axetat?", new[]{"CH3COOC2H5","C2H5OH","CH3OH","C2H6"},1,8),
("Lipit là?", new[]{"chất béo","axit","muối","kim loại"},1,8),
("Phản ứng este hóa?", new[]{"axit + rượu","axit + bazơ","muối","kim loại"},1,8),
("Chất béo là?", new[]{"este","axit","bazơ","muối"},1,8),
("Este tan tốt trong?", new[]{"dung môi hữu cơ","nước","axit","bazơ"},1,8),
("Công thức chung este?", new[]{"RCOOR'","ROH","RCOOH","RNH2"},1,8),
("Thủy phân este tạo?", new[]{"axit + rượu","muối","kim loại","khí"},1,8),
("Chất nào là este?", new[]{"CH3COOC2H5","C2H5OH","NaCl","HCl"},1,8),
("Este có mùi?", new[]{"thơm","không mùi","khét","hôi"},1,8),
// ===== ANH 11 =====
("If I ___ rich, I would travel.", new[]{"am","were","be","was"},2,11),
("If she ___ harder, she would pass.", new[]{"study","studies","studied","studying"},3,11),
("If I had money, I ___ buy a car.", new[]{"will","would","can","shall"},2,11),
("If he ___ earlier, he would not be late.", new[]{"came","comes","come","coming"},1,11),
("If I ___ you, I would help.", new[]{"am","were","was","be"},2,11),
("If it rains, I ___ stay home.", new[]{"will","would","can","shall"},1,11),
("If she had studied, she ___ passed.", new[]{"will","would","can","shall"},2,11),
("If they ___ harder, they would win.", new[]{"try","tried","tries","trying"},2,11),
("If I see him, I ___ tell him.", new[]{"will","would","can","shall"},1,11),
("If you heat ice, it ___.", new[]{"melts","melt","melting","melted"},1,11),
// ===== SINH 11 =====
("Gen là?", new[]{"đoạn ADN","protein","lipit","enzim"},1,14),
("ADN cấu tạo từ?", new[]{"nucleotit","axit","protein","lipit"},1,14),
("ARN khác ADN ở?", new[]{"1 mạch","2 mạch","3 mạch","4 mạch"},1,14),
("Đột biến gen là?", new[]{"biến đổi ADN","tăng trưởng","phân bào","trao đổi"},1,14),
("Phiên mã tạo?", new[]{"ARN","ADN","protein","enzim"},1,14),
("Dịch mã tạo?", new[]{"protein","ADN","ARN","lipit"},1,14),
("Nhiễm sắc thể chứa?", new[]{"ADN","protein","lipit","gluco"},1,14),
("Gen nằm ở?", new[]{"NST","ribosome","màng","tế bào"},1,14),
("ADN có dạng?", new[]{"xoắn kép","thẳng","tròn","vuông"},1,14),
("Đột biến có thể?", new[]{"có lợi/hại","chỉ lợi","chỉ hại","không ảnh hưởng"},1,14),
// ===== SỬ 11 =====
("Cách mạng tháng 8 diễn ra năm?", new[]{"1945","1930","1954","1975"},1,17),
("Việt Nam độc lập năm?", new[]{"1945","1954","1975","1930"},1,17),
("Hồ Chí Minh đọc Tuyên ngôn ở?", new[]{"Ba Đình","Huế","SG","HN"},1,17),
("Chiến tranh TG2 kết thúc?", new[]{"1945","1939","1918","1954"},1,17),
("Mỹ ném bom nguyên tử ở?", new[]{"Nhật","Đức","Anh","Pháp"},1,17),
("Liên Xô tan rã?", new[]{"1991","1945","1975","2000"},1,17),
("Việt Nam thống nhất?", new[]{"1975","1945","1954","1986"},1,17),
("Đổi mới bắt đầu?", new[]{"1986","1975","1991","2000"},1,17),
("Phong trào 1930?", new[]{"Xô Viết Nghệ Tĩnh","CMT8","Đổi mới","Kháng chiến"},1,17),
("Thủ đô VN?", new[]{"Hà Nội","Huế","SG","ĐN"},1,17),
// ===== ĐỊA 11 =====
("Kinh tế học nghiên cứu?", new[]{"sản xuất","địa lý","lịch sử","sinh học"},1,20),
("Nước phát triển có?", new[]{"GDP cao","GDP thấp","ít dân","khí hậu lạnh"},1,20),
("Việt Nam là?", new[]{"đang phát triển","phát triển","kém phát triển","giàu"},1,20),
("Công nghiệp gồm?", new[]{"sản xuất","trồng trọt","chăn nuôi","dịch vụ"},1,20),
("Nông nghiệp là?", new[]{"trồng trọt","công nghiệp","dịch vụ","CNTT"},1,20),
("Dịch vụ gồm?", new[]{"thương mại","trồng trọt","khai thác","sản xuất"},1,20),
("GDP là?", new[]{"tổng sản phẩm","dân số","diện tích","thuế"},1,20),
("Xuất khẩu là?", new[]{"bán ra nước ngoài","mua vào","trao đổi","sản xuất"},1,20),
("Nhập khẩu là?", new[]{"mua từ nước ngoài","bán ra","trao đổi","sản xuất"},1,20),
("Đô thị hóa là?", new[]{"tăng dân đô thị","giảm dân","không đổi","nông thôn"},1,20),
// ===== GDCD 11 =====
("Pháp luật do ai ban hành?", new[]{"Nhà nước","Cá nhân","Gia đình","Trường"},1,23),
("Công dân phải?", new[]{"tuân thủ luật","vi phạm","trốn","né"},1,23),
("Quyền công dân?", new[]{"học tập","không học","lười","ngủ"},1,23),
("Nghĩa vụ công dân?", new[]{"chấp hành luật","vi phạm","né","trốn"},1,23),
("Vi phạm luật là?", new[]{"sai luật","đúng luật","hợp lệ","bình thường"},1,23),
("Pháp luật mang tính?", new[]{"bắt buộc","tự do","tùy ý","cảm xúc"},1,23),
("Nhà nước là?", new[]{"tổ chức quyền lực","cá nhân","gia đình","trường"},1,23),
("Quyền tự do là?", new[]{"được phép","cấm","không","ít"},1,23),
("Công dân bình đẳng?", new[]{"trước pháp luật","trước tiền","trước học","trước nhà"},1,23),
("Hiến pháp là?", new[]{"luật cao nhất","luật thường","không","ý kiến"},1,23),
// ===== TOÁN 12 =====
("Nguyên hàm của x là?", new[]{"x^2/2","x","2x","1/x"},1,3),
("∫x dx = ?", new[]{"x^2/2 + C","x + C","2x + C","lnx + C"},1,3),
("Đạo hàm của x^3?", new[]{"3x^2","x^2","x^3","3x"},1,3),
("∫1/x dx = ?", new[]{"ln|x| + C","x","1/x","x^2"},1,3),
("Diện tích dưới đồ thị là?", new[]{"tích phân","đạo hàm","giới hạn","log"},1,3),
("∫0→1 x dx = ?", new[]{"1/2","1","0","2"},1,3),
("Nguyên hàm của e^x?", new[]{"e^x","x","1","0"},1,3),
("∫cos(x) dx = ?", new[]{"sin(x)","cos(x)","-cos(x)","-sin(x)"},1,3),
("∫sin(x) dx = ?", new[]{"-cos(x)","cos(x)","sin(x)","-sin(x)"},1,3),
("Tích phân dùng để?", new[]{"tính diện tích","tính đạo hàm","giải PT","log"},1,3),
// ===== LÝ 12 =====
("Sóng điện từ truyền được trong?", new[]{"chân không","nước","khí","rắn"},1,6),
("Ánh sáng là?", new[]{"sóng điện từ","âm thanh","nhiệt","lực"},1,6),
("Tốc độ ánh sáng?", new[]{"3x10^8 m/s","3x10^6","300","3"},1,6),
("Tia X dùng để?", new[]{"chụp X-quang","nghe","nhìn","đo"},1,6),
("Sóng vô tuyến dùng để?", new[]{"truyền tin","nấu ăn","đo","chụp"},1,6),
("Ánh sáng nhìn thấy có màu?", new[]{"7 màu","3","5","1"},1,6),
("Tia hồng ngoại có tác dụng?", new[]{"nhiệt","ánh sáng","âm","lực"},1,6),
("Tia tử ngoại gây?", new[]{"cháy da","lạnh","ẩm","tối"},1,6),
("Sóng EM có vận tốc?", new[]{"bằng ánh sáng","chậm","nhanh hơn","0"},1,6),
("Tần số tăng thì bước sóng?", new[]{"giảm","tăng","không đổi","0"},1,6),
// ===== HÓA 12 =====
("Kim loại dẫn điện do?", new[]{"electron tự do","proton","neutron","ion"},1,9),
("Na là kim loại?", new[]{"kiềm","kiềm thổ","chuyển tiếp","phi kim"},1,9),
("Fe có hóa trị?", new[]{"2,3","1","4","5"},1,9),
("Kim loại tác dụng với axit tạo?", new[]{"muối + H2","muối","H2O","CO2"},1,9),
("Al là kim loại?", new[]{"nhẹ","nặng","hiếm","độc"},1,9),
("Kim loại kiềm có tính?", new[]{"mạnh","yếu","trung bình","không"},1,9),
("NaOH là?", new[]{"bazơ","axit","muối","kim loại"},1,9),
("Kim loại có xu hướng?", new[]{"nhường e","nhận e","không","giữ"},1,9),
("Cu là kim loại?", new[]{"dẫn điện tốt","không dẫn","cách điện","không"},1,9),
("Kim loại hoạt động mạnh?", new[]{"K","Cu","Ag","Au"},1,9),
// ===== ANH 12 =====
("The man ___ is my teacher.", new[]{"who","which","where","when"},1,12),
("The book ___ I read is good.", new[]{"which","who","when","where"},1,12),
("The place ___ I live is Hanoi.", new[]{"where","who","which","when"},1,12),
("The day ___ we met was nice.", new[]{"when","who","which","where"},1,12),
("The girl ___ is singing.", new[]{"who","which","where","when"},1,12),
("The car ___ is red.", new[]{"which","who","when","where"},1,12),
("The person ___ you saw.", new[]{"who","which","where","when"},1,12),
("The house ___ is big.", new[]{"which","who","when","where"},1,12),
("The time ___ I arrived.", new[]{"when","who","which","where"},1,12),
("The boy ___ plays football.", new[]{"who","which","when","where"},1,12),
// ===== SINH 12 =====
("Tiến hóa là?", new[]{"biến đổi","giữ nguyên","tăng trưởng","phân bào"},1,15),
("Chọn lọc tự nhiên?", new[]{"giữ lại tốt","loại bỏ","tăng","giảm"},1,15),
("Darwin là?", new[]{"nhà khoa học","bác sĩ","giáo viên","kỹ sư"},1,15),
("Biến dị là?", new[]{"khác nhau","giống nhau","bằng nhau","không"},1,15),
("Di truyền là?", new[]{"truyền tính trạng","biến đổi","phát triển","tăng"},1,15),
("Quần thể là?", new[]{"nhóm cá thể","1 cá thể","loài","gen"},1,15),
("Loài là?", new[]{"cùng đặc điểm","khác","không","ít"},1,15),
("Tiến hóa nhỏ là?", new[]{"trong loài","khác loài","lớn","không"},1,15),
("Đột biến giúp?", new[]{"đa dạng","giống","không","ít"},1,15),
("Chọn lọc tự nhiên do?", new[]{"môi trường","con người","máy","không"},1,15),
// ===== SỬ 12 =====
("Chiến tranh VN kết thúc?", new[]{"1975","1945","1954","1986"},1,18),
("Hiệp định Paris?", new[]{"1973","1954","1945","1986"},1,18),
("Việt Nam thống nhất?", new[]{"1975","1945","1954","2000"},1,18),
("Đổi mới bắt đầu?", new[]{"1986","1975","1991","2000"},1,18),
("Chiến tranh lạnh?", new[]{"Mỹ-LX","Anh-Pháp","Đức-Nhật","VN-Mỹ"},1,18),
("LX tan rã?", new[]{"1991","1986","1975","2000"},1,18),
("ASEAN thành lập?", new[]{"1967","1975","1991","2000"},1,18),
("WTO VN gia nhập?", new[]{"2007","2000","1995","2010"},1,18),
("Liên Hợp Quốc?", new[]{"1945","1975","1991","2000"},1,18),
("Toàn cầu hóa là?", new[]{"liên kết","chia rẽ","đóng","tách"},1,18),
// ===== ĐỊA 12 =====
("Địa lý VN gồm?", new[]{"tự nhiên + KT","tự nhiên","KT","không"},1,21),
("Khí hậu VN?", new[]{"nhiệt đới","ôn đới","hàn","cận"},1,21),
("Địa hình chủ yếu?", new[]{"đồi núi","đồng bằng","sa mạc","biển"},1,21),
("Sông lớn?", new[]{"Mekong","Nile","Amazon","Danube"},1,21),
("Dân số đông ở?", new[]{"đồng bằng","núi","biển","rừng"},1,21),
("Kinh tế VN?", new[]{"đang phát triển","phát triển","kém","giàu"},1,21),
("Công nghiệp VN?", new[]{"đang phát triển","không","ít","giảm"},1,21),
("Nông nghiệp?", new[]{"trồng trọt","CN","dịch vụ","CNTT"},1,21),
("Xuất khẩu mạnh?", new[]{"nông sản","kim loại","vàng","đá"},1,21),
("Thủ đô?", new[]{"Hà Nội","Huế","ĐN","HCM"},1,21),
// ===== GDCD 12 =====
("Kinh tế là?", new[]{"sản xuất","học","chơi","ngủ"},1,24),
("Cung cầu là?", new[]{"quan hệ","tách biệt","không","ít"},1,24),
("Giá cả do?", new[]{"cung cầu","nhà","trường","cá nhân"},1,24),
("Thị trường là?", new[]{"trao đổi","học","chơi","ngủ"},1,24),
("Tiền tệ là?", new[]{"phương tiện","hàng","dịch vụ","đồ"},1,24),
("Lợi nhuận là?", new[]{"thu - chi","thu","chi","0"},1,24),
("Doanh nghiệp là?", new[]{"kinh doanh","học","chơi","ngủ"},1,24),
("Cạnh tranh là?", new[]{"ganh đua","hòa bình","không","ít"},1,24),
("Kinh tế thị trường?", new[]{"tự do","ép buộc","cứng","ít"},1,24),
("Nhà nước điều tiết?", new[]{"kinh tế","học","chơi","ngủ"},1,24),
            };
            foreach (var item in cauHoiThat)
            {
                cauHoiList.Add(new CauHoi
                {
                    MaCauHoi = chId,
                    NoiDung = item.q,
                    MaChuyenDe = item.chuyenDe,
                    MucDo = 1,
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    NguoiTao = 1
                });

                for (int i = 0; i < 4; i++)
                {
                    dapAnList.Add(new DapAn
                    {
                        MaDapAn = daId++,
                        MaCauHoi = chId,
                        NoiDung = item.a[i],
                        LaDapAnDung = (i + 1) == item.correct
                    });
                }

                chId++;
            }

            modelBuilder.Entity<CauHoi>().HasData(cauHoiList);
            modelBuilder.Entity<DapAn>().HasData(dapAnList);



            // ===== ĐỀ THI =====
            var deList = new List<DeThi>();
            int idDe = 1;

            string[] mon = { "Toán", "Vật Lý", "Hóa", "Anh", "Sinh", "Sử", "Địa", "GDCD" };

            // ===== ĐỀ THEO KHỐI =====
            for (int m = 0; m < 8; m++)
            {
                // Khối 10
                deList.Add(new DeThi
                {
                    MaDeThi = idDe++,
                    TenDeThi = $"Đề thi {mon[m]} - Lớp 10",
                    MaMonHoc = m + 1,
                    ThoiGianLamBai = 15,
                    TronCauHoi = true,
                    TronDapAn = true,
                    NguoiTao = 1,
                    Khoi = 10,
                    TrangThai = true,
                    LoaiDe = "Chung"
                });

                // Khối 11
                deList.Add(new DeThi
                {
                    MaDeThi = idDe++,
                    TenDeThi = $"Đề thi {mon[m]} - Lớp 11",
                    MaMonHoc = m + 1,
                    ThoiGianLamBai = 15,
                    TronCauHoi = true,
                    TronDapAn = true,
                    NguoiTao = 1,
                    Khoi = 11,
                    TrangThai = true,
                    LoaiDe = "Chung"
                });

                // Khối 12
                deList.Add(new DeThi
                {
                    MaDeThi = idDe++,
                    TenDeThi = $"Đề thi {mon[m]} - Lớp 12",
                    MaMonHoc = m + 1,
                    ThoiGianLamBai = 15,
                    TronCauHoi = true,
                    TronDapAn = true,
                    NguoiTao = 1,
                    Khoi = 12,
                    TrangThai = true,
                    LoaiDe = "Chung"
                });
            }
            // ===== ĐỀ LUYỆN TẬP =====
            var random = new Random();

            // danh sách khối
            var khois = new List<int> { 10, 11, 12 };

            for (int i = 0; i < 10; i++)
            {
                //chia đều khối + môn
                var khoiRandom = khois[i % khois.Count];
                var monRandom = (i % 8) + 1; // 8 môn

                // lấy giáo viên đại diện theo môn
                int gvDaiDien = ((monRandom - 1) * 2) + 1;

                deList.Add(new DeThi
                {
                    MaDeThi = idDe++,
                    TenDeThi = $"Đề luyện tập {i + 1} - Khối {khoiRandom}",
                    MaMonHoc = monRandom,
                    ThoiGianLamBai = 15,
                    TronCauHoi = true,
                    TronDapAn = true,

                    NguoiTao = gvDaiDien, 

                    Khoi = khoiRandom,
                    TrangThai = true,
                    LoaiDe = "Rieng"
                });
            }

            modelBuilder.Entity<DeThi>().HasData(deList);



            // ===== CHI TIẾT ĐỀ  =====
            var ctDe = new List<ChiTietDeThi>();

            int soCauMoiDe = 10;

            // chuyên đề → (môn, khối)
            var chuyenDeInfo = new Dictionary<int, (int mon, int khoi)>();

            for (int m = 1; m <= 8; m++)
            {
                for (int k = 1; k <= 3; k++)
                {
                    int chuyenDeId = (m - 1) * 3 + k;
                    chuyenDeInfo[chuyenDeId] = (m, k); // k: 1=10, 2=11, 3=12
                }
            }

            // nhóm câu hỏi theo (môn, khối)
            var cauHoiTheoMonKhoi = new Dictionary<(int, int), List<int>>();

            for (int m = 1; m <= 8; m++)
            {
                for (int k = 1; k <= 3; k++)
                {
                    cauHoiTheoMonKhoi[(m, k)] = new List<int>();
                }
            }

            //đổ câu hỏi vào nhóm
            foreach (var ch in cauHoiList)
            {
                var info = chuyenDeInfo[ch.MaChuyenDe];
                cauHoiTheoMonKhoi[(info.mon, info.khoi)].Add(ch.MaCauHoi);
            }

            // tạo chi tiết đề
            foreach (var de in deList)
            {
                int maMon = de.MaMonHoc;

                // đổi tên tránh trùng biến
                int khoiDe = 1;

                if (de.TenDeThi.Contains("Lớp 11")) khoiDe = 2;
                else if (de.TenDeThi.Contains("Lớp 12")) khoiDe = 3;

                var dsCauHoi = cauHoiTheoMonKhoi[(maMon, khoiDe)];

                // random
                Random rand = new Random(Guid.NewGuid().GetHashCode());

                var selected = dsCauHoi
                    .OrderBy(x => rand.Next())
                    .Take(soCauMoiDe);

                foreach (var cauHoiId in selected)
                {
                    ctDe.Add(new ChiTietDeThi
                    {
                        MaDeThi = de.MaDeThi,
                        MaCauHoi = cauHoiId
                    });
                }
            }

            modelBuilder.Entity<ChiTietDeThi>().HasData(ctDe);

            // ===== GIÁO VIÊN =====
            string[] tenGV =
            {
    "Nguyễn Văn Minh","Trần Thị Lan","Phạm Văn Hùng","Lê Thị Hoa",
    "Đỗ Văn Nam","Ngô Thị Hạnh","Hoàng Văn Tuấn","Bùi Thị Trang",
    "Phan Văn Long","Vũ Thị Mai","Đặng Văn Sơn","Trịnh Thị Hà",
    "Đoàn Văn Phúc","Tạ Thị Thu","Lương Văn Hải","Hà Thị Linh"
};

            string[] dsMonCode = { "TOAN", "LY", "HOA", "SINH", "ANH", "SU", "DIA", "GDCD" };

            var gvUser = new List<NguoiDung>();
            var gvHoSo = new List<HoSoCaNhan>();
            var gvList = new List<GiaoVien>();

            int userId = 100;
            int gvId = 1;

            for (int i = 0; i < 16; i++)
            {
                string maMon = dsMonCode[i / 2];

                int stt = (i % 2) + 1;

                string username = $"GV{maMon}{stt:D2}";

                gvUser.Add(new NguoiDung
                {
                    MaNguoiDung = userId,
                    TenDangNhap = username,
                    MatKhau = username.ToLower(),
                    TrangThai = true,
                    NgayTao = new DateTime(2025, 1, 1),
                    MaVaiTro = 2
                });

                gvHoSo.Add(new HoSoCaNhan
                {
                    MaNguoiDung = userId,
                    HoTen = tenGV[i],
                    NgaySinh = new DateTime(1985 + (i % 10), (i % 12) + 1, (i % 28) + 1),
                    GioiTinh = i % 2 == 0 ? "Nam" : "Nữ",
                    SoDienThoai = "0900000" + userId,
                    DiaChi = "Hà Nội",
                    AnhDaiDien = null
                });

                gvList.Add(new GiaoVien
                {
                    MaGiaoVien = gvId,
                    MaNguoiDung = userId,
                    TrangThai = true,

                    // mỗi môn 2 giáo viên → gv lẻ là đại diện
                    LaDaiDien = (gvId % 2 == 1)
                });

                userId++;
                gvId++;
            }

            modelBuilder.Entity<NguoiDung>().HasData(gvUser);
            modelBuilder.Entity<HoSoCaNhan>().HasData(gvHoSo);
            modelBuilder.Entity<GiaoVien>().HasData(gvList);


            // ===== PHÂN CÔNG GIẢNG DẠY =====
            var phanCong = new List<PhanCongGiangDay>();
            int pcId = 1;

            /*
            - 18 lớp (1 → 18)
            - 8 môn (1 → 8)
            - 16 giáo viên (mỗi môn 2 GV)
            - GV lẻ = đại diện môn
            */

            for (int lop = 1; lop <= 18; lop++)
            {
                for (int monId = 1; monId <= 8; monId++) 
                {
                    // mỗi môn có 2 giáo viên
                    int gv = ((monId - 1) * 2) + (lop % 2 == 0 ? 1 : 2);

                    phanCong.Add(new PhanCongGiangDay
                    {
                        MaPhanCong = pcId++,
                        MaGiaoVien = gv,
                        MaLop = lop,
                        MaMon = monId,
                        LaDaiDien = (gv == (monId - 1) * 2 + 1)
                    });
                }
            }

            modelBuilder.Entity<PhanCongGiangDay>().HasData(phanCong);

            // ===== ĐỢT THI =====
            modelBuilder.Entity<DotThi>().HasData(
                new DotThi
                {
                    MaDotThi = 1,
                    TenDotThi = "Thi Toán Lớp 10",
                    MaDeThi = 1, // Toán lớp 10
                    ThoiGianBatDau = new DateTime(2025, 6, 1, 8, 0, 0),
                    ThoiGianKetThuc = new DateTime(2025, 6, 1, 9, 0, 0),
                    TrangThai = true
                },
                new DotThi
                {
                    MaDotThi = 2,
                    TenDotThi = "Thi Vật Lý Lớp 11",
                    MaDeThi = 5, // Lý lớp 11
                    ThoiGianBatDau = new DateTime(2025, 6, 2, 8, 0, 0),
                    ThoiGianKetThuc = new DateTime(2025, 6, 2, 9, 0, 0),
                    TrangThai = true
                },
                new DotThi
                {
                    MaDotThi = 3,
                    TenDotThi = "Thi Hóa Lớp 12",
                    MaDeThi = 9, // Hóa lớp 12
                    ThoiGianBatDau = new DateTime(2025, 6, 3, 8, 0, 0),
                    ThoiGianKetThuc = new DateTime(2025, 6, 3, 9, 0, 0),
                    TrangThai = true
                }
            );

            // ===== HỌC SINH =====
            string[] ho = { "Nguyễn Hoàng", "Trần Minh", "Lê Hà", "Phạm Nhật", "Hoàng Hải", "Phan Quốc", "Vũ Thái", "Đặng Như", "Bùi Tiến", "Đỗ Xuân" };

            string[] ten = { "Anh", "Bình", "Chi", "Dũng", "Giang", "Hải", "Hà", "Hưng", "Lan", "Linh", "Mai", "Nam", "Ngọc", "Phong", "Quang", "Trang", "Thảo", "Tuấn", "Vy", "Yến" };

            var hsUser = new List<NguoiDung>();
            var hsHoSo = new List<HoSoCaNhan>();
            var hsList = new List<HocSinh>();

            int idHS = 1;
            int nd = 500;
            Random r = new Random(123);

            // 18 lớp
            for (int lop = 1; lop <= 18; lop++)
            {
                for (int i = 1; i <= 15; i++)
                {
                    string hoten = ho[r.Next(ho.Length)] + " " + ten[r.Next(ten.Length)];

                    int namNhapHoc;
                    if (lop <= 6) namNhapHoc = 2026;
                    else if (lop <= 12) namNhapHoc = 2025;
                    else namNhapHoc = 2024;

                    // MÃ HỌC SINH (8 số)
                    string maHS = $"{namNhapHoc % 100:D2}{lop:D2}{i:D2}{idHS:D2}";

                    // ===== USER =====
                    hsUser.Add(new NguoiDung
                    {
                        MaNguoiDung = nd,
                        TenDangNhap = maHS, 
                        MatKhau = "123456",
                        TrangThai = true,
                        NgayTao = new DateTime(2025, 1, 1),
                        MaVaiTro = 3
                    });

                    // ===== HỒ SƠ =====
                    hsHoSo.Add(new HoSoCaNhan
                    {
                        MaNguoiDung = nd,
                        HoTen = hoten,
                        NgaySinh = new DateTime(2007, r.Next(1, 13), r.Next(1, 29)),
                        GioiTinh = r.Next(0, 2) == 0 ? "Nam" : "Nữ",
                        SoDienThoai = "091" + r.Next(1000000, 9999999),
                        DiaChi = "Hà Nội",
                        AnhDaiDien = null
                    });

                    // ===== HỌC SINH =====
                    hsList.Add(new HocSinh
                    {
                        MaHocSinh = int.Parse(maHS),   
                        MaNguoiDung = nd,
                        MaLop = lop,
                        SoBaoDanh = $"{lop:D2}{i:D2}",
                        TrangThai = true
                    });

                    idHS++;
                    nd++;
                }
            }

            modelBuilder.Entity<NguoiDung>().HasData(hsUser);
            modelBuilder.Entity<HoSoCaNhan>().HasData(hsHoSo);
            modelBuilder.Entity<HocSinh>().HasData(hsList);
        }
    }
}