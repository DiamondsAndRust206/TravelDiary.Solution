using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;

namespace TravelDiary.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Place starterPlace = new Place("Add first place to Places Iv been");
      return View(starterPlace);
    }

  }
}