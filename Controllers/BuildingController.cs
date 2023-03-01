using Lucy_BRMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lucy_BRMS.Controllers;

public class BuildingController : Controller
{ 
    private readonly ApplicationDbContext _db;

    public BuildingController(ApplicationDbContext db)
    {
        _db = db;
    }


    public IActionResult Index()
    {
        IEnumerable<Building> buildings = _db.Buildings.ToList();
        return View(buildings);
    }

}