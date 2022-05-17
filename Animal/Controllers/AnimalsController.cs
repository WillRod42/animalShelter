using Microsoft.AspNetCore.Mvc;
using Animal.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Animal.Controllers
{
    public class AnimalsController : Controller
    {
      private readonly AnimalShelterContext _db;

      public AnimalsController(AnimalShelterContext db)
      {
        _db = db;
      }

      public ActionResult Index()
      {
        List<AnimalObject> model = _db.Animals.ToList();
        return View(model);
      }

      public ActionResult Create()
      {
        ViewBag.types = new SelectList(_db.AnimalTypes, "TypeId", "Type");
        return View();
      }

      /*
          public ActionResult Edit(int id)
          {
            Item thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
            ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
            return View(thisItem);
          }
      */

      [HttpPost]
      public ActionResult Create(AnimalObject animal)
      {
        animal.DateOfArival = DateTime.Now;
        _db.Animals.Add(animal);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

      public ActionResult Details(int id)
      {
        AnimalObject animal = _db.Animals.FirstOrDefault(animal => animal.Id == id);
        AnimalType animalType = _db.AnimalTypes.FirstOrDefault(animalType => animalType.TypeId == animal.TypeId);
        ViewBag.animalType = animalType;
        return View(animal);
      }
    }
}