using Microsoft.EntityFrameworkCore;
using WebApplication3.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MvcDemoDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString"))); // this is the injection-thing, after this go to appsettings.json to create a connection string                                                     

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
