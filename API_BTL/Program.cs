using BussinessLayer;
using BussinessLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IKhachHangBUSS, KhachHangBUS>();
builder.Services.AddTransient<IKhachHangResponsitory, KhachHangResponsitory>();
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IHoaDonResponsitory, HoaDonResponsitory>();
builder.Services.AddTransient<IHoaDonBUS, HoaDonBUS>();
builder.Services.AddTransient<IDonHangResponsitory, DonHangResponsitory>();
builder.Services.AddTransient<IDonHangBUS, DonHangBUSS>();
builder.Services.AddTransient<IChiTietDonHangResponsitory, ChiTietDonHangResponsitory>();
builder.Services.AddTransient<IChiTietDonHangBUS, ChiTietDonHangBUSS>();
builder.Services.AddTransient<IChiTietHDNResponsitory, ChiTietHDNResponsitory>();
builder.Services.AddTransient<IChiTietHDNBUS, ChiTietHDNBUSS>();
builder.Services.AddTransient<INhaCungCapResponsitory, NhaCungCapResponsitory>();
builder.Services.AddTransient<INhaCungCapBUS, NhaCungCapBUSS>();
builder.Services.AddTransient<ISanPhamResponsitory, SanPhamResponsitory>();
builder.Services.AddTransient<ISanPhamBUS, SanPhamBUSS>();
builder.Services.AddTransient<ILoaiTaiKhoanResponsitory, LoaiTaiKhoanResponsitory>();
builder.Services.AddTransient<ILoaiTaiKhoanBUS, LoaiTaiKhoanBUSS>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors(x => x
	.AllowAnyOrigin()
	.AllowAnyMethod()
	.AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
