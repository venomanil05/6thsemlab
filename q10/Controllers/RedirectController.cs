using Microsoft.AspNetCore.Mvc;

namespace q10.Controllers
{
    public class RedirectController : Controller
    {
        // Display the form
        public IActionResult Index()
        {
            return View();
        }

        // Secure redirect
        [HttpPost]
        public IActionResult Go(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return LocalRedirect(returnUrl);
            }

            ViewBag.Message =
                "Invalid redirect URL. Only local URLs are allowed.";

            return View("Index");
        }
    }
}
