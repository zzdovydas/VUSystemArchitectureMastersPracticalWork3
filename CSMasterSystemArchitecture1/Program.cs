using CSMasterSystemArchitecture1.Context;
using CSMasterSystemArchitecture1.Repositories;
using CSMasterSystemArchitecture1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ItemDbContext>(
    options => options.UseSqlite("Data Source=items.db;"));

builder.Services.AddScoped<ItemRepository>();
builder.Services.AddScoped<ItemService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Item}/{action=Index}/{id?}");



app.Run();
