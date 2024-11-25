using Microsoft.AspNetCore.Mvc;

namespace KoreklarMVC.Controllers {
    public class ErrorController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
