using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using WebQLThiTracNghiem.Data;

var builder = WebApplication.CreateBuilder(args);

// ✅ EPPlus (version 7 trở xuống)
ExcelPackage.License.SetNonCommercialPersonal("BaoTram");
// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// ✅ thứ tự chuẩn
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=TrangChu}/{id?}");

app.Run();