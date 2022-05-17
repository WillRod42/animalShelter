using Microsoft.AspNetCore.Mvc;

namespace Animal.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}