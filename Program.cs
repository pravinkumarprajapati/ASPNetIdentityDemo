using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASPNetIdentityDemo.Data;
using ASPNetIdentityDemo;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WebUserDbContextConnection") ?? throw new InvalidOperationException("Connection string 'WebUserDbContextConnection' not found.");

builder.Services.AddDbContext<WebUserDbContext>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<WebUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<WebUserDbContext>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
