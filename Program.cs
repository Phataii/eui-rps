using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using rps.Data;
using rps.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
DotNetEnv.Env.Load();

// Database Configuration
var connectionString = configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddAuthorization();

// Session Configuration
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
    options.Cookie.IsEssential = true;
});

// Dependency Injection
builder.Services.AddScoped<UserHelper>();
builder.Services.AddScoped<GradeService>();
builder.Services.AddScoped<ResultService>();
builder.Services.AddScoped<TranscriptService>();
builder.Services.AddScoped<GeneralService>();
builder.Services.AddScoped<ActivityTrackerService>();
builder.Services.AddSingleton<IEmailService, EmailService>();


// Controllers & Views
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); 
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();

var app = builder.Build();

// Middleware Configuration
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

app.Run();
