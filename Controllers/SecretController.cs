using Microsoft.AspNetCore.Mvc;

namespace UserAuthenticationApp.Controllers
{
    public class SecretController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
