using Microsoft.EntityFrameworkCore;
using AutoCompleteSearch.Data;

var builder = WebApplication.CreateBuilder(args);

// ��������� ����������� � ���� ������
builder.Services.AddDbContext<YourDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// ��������� ������������ � ��������������� (���� ������������)
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

