namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //added MVC Controllers
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            //default map controller route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=config}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
