using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using UserAuthenticationApp.Areas.Identity.Data;

namespace UserAuthenticationApp.Controllers
{
    public class SecretController : Controller
    {
        private UserManager<UserAuthenticationAppUser> _userManager;
        private SignInManager<UserAuthenticationAppUser> _signInManager;
        public SecretController(UserManager<UserAuthenticationAppUser> userManager, SignInManager<UserAuthenticationAppUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        private async Task<UserAuthenticationAppUser> GetUser(ClaimsPrincipal User)
        {
            return await _userManager.GetUserAsync(User);
        }

        public async Task<IActionResult> Index2()
        {
            //var user = await _userManager.GetUserAsync(User);
            //var isSignedIn = _signInManager.IsSignedIn(User);

            await GetUser(User);
            return View();
        }
        public async Task<IActionResult> Index()
        {
           var user = await _userManager.GetUserAsync(User);
            var isSignedIn = _signInManager.IsSignedIn(User);

            return View();
        }
    }
}
