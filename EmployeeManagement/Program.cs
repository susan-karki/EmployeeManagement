using EmployeeManagement.Models;

namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //added MVC Controllers
            builder.Services.AddControllersWithViews();
            //DI
            builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //for default page/ files to show 
            //app.UseDefaultFiles();

            // for ststic files i have used thois middleware..
            //app.UseStaticFiles();

            // combined UseDefaultFiles() and UseStaticfiles()
            app.UseFileServer();
            //for routing i guess
            app.UseRouting();
            //authorixzation
            app.UseAuthorization();

            //default map controller route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
