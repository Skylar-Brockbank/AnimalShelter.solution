using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
    public class AnimalController : Controller
    {
      private readonly AnimalShelterContext _db;
      public AnimalController(AnimalShelterContext db)
      {
        _db=db;
      }
      public ActionResult Index()
      {
        List<Animal> model = _db.animalshelter.ToList();
        return View(model);
      }
      public ActionResult Create()
      {
        return View();
      }

      [HttpPost]
      public ActionResult Create(Animal animal)
      {
        _db.animalshelter.Add(animal);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

      public ActionResult Details(int id)
      {
        Animal thisAnimal = _db.animalshelter.FirstOrDefault(animal => animal.id == id);
        return View(thisAnimal);
      }
    }
}