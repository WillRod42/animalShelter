using Microsoft.AspNetCore.Mvc;
using Animal.Models;
using System.Collections.Generic;
using System.Linq;

namespace Animal.Controllers
{
    public class AnimalTypesController : Controller
    {
      private readonly AnimalShelterContext _db;

      public AnimalTypesController(AnimalShelterContext db)
      {
        _db = db;
      }

      public ActionResult Index()
      {
        List<AnimalType> model = _db.AnimalTypes.ToList();
        return View(model);
      }

      public ActionResult Create()
      {
        return View();
      }

      [HttpPost]
      public ActionResult Create(AnimalType animalType)
      {
        _db.AnimalTypes.Add(animalType);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

    }
}