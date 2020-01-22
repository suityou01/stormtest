using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace stormtestmvc.Controllers
{

    //[Authorize]
    public class SecretController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
