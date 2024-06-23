using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ChaBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.Always; 
                options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
            });

            var app = builder.Build();
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
                name: "Login",
                pattern: "{controller=Account}/{action=Login}/{id?}");

            app.MapControllerRoute(
                name: "Register",
                pattern: "{controller=Account}/{action=Register}/{id?}");

            app.MapControllerRoute(
                name: "Admin",
                pattern: "{controller=Admin}/{action=Admin}/{id?}");

            app.MapControllerRoute(
                name: "Books",
                pattern: "{controller=Books}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
