using Graduate_Project;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); //creates an instance of the .net core application

var configbuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
var configuration = configbuilder.Build();

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sam}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Profile}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "edit",
    pattern: "{controller=Profile}/{action=Edit}/{id?}");

app.MapControllerRoute(
    name: "delete",
    pattern: "{controller=Profile}/{action=Delete}/{id?}");


/* adding routes here */

app.Run();
