using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web12._05._2024.Data;
using Web12._05._2024.SeedData;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Web12_05_2024Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Web12_05_2024Context") ?? throw new InvalidOperationException("Connection string 'Web12_05_2024Context' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRequestLocalization("en-US", "ru-RU");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
