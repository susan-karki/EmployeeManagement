using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ConfigController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _env;
        public ConfigController(IConfiguration config, IWebHostEnvironment env) 
        {
            _config = config;
            _env = env;
        }
        public IActionResult Index()
        {
            string environmentName = _env.EnvironmentName;
            return Content($"Value from appsettings.json: {environmentName}");
        }
    }
}
