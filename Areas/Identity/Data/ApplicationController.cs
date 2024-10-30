using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BP.Areas.Identity.Data
{
    public class ApplicationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        // UserManager<TUser> -  где TUser - ваш тип пользователя (например, ApplicationUser)

        public ApplicationController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
