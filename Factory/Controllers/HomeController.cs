using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      var engineers = _db.Engineers.ToList();
      var machines = _db.Machines.ToList();

      ViewBag.Engineers = engineers;
      ViewBag.Machines = machines;

      return View();
    }

  }
}