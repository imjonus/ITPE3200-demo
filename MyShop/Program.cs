using Microsoft.EntityFrameworkCore;
using Myshop.DAL;
using MyShop.DAL;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ItemDbContext>(options =>
{
    options.UseSqlite(builder.Configuration["Connectionstrings:ItemDbContextConnection"]);
});

builder.Services.AddScoped<IItemRepository, ItemRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    DBInit.Seed(app);
}

app.UseStaticFiles();

app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();