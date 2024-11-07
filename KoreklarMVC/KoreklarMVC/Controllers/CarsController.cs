using Microsoft.AspNetCore.Mvc;

namespace KoreklarMVC.Controllers {
    public class CarsController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
