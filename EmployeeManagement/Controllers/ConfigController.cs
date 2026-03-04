using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ConfigController : Controller
    {
        private readonly IConfiguration _config;
        public ConfigController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            string value = _config["MyKey"];
            return Content($"Value from appsettings.json: {value}");
        }
    }
}
