using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniquePlacesToVisit.Data;
using UniquePlacesToVisit.Data.Models;
using UniquePlacesToVisit.Web.ViewModels.City;

namespace UniquePlacesToVisit.Controllers
{
    public class CityController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CityController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cities = await dbContext.Cities
                .Select(c => new CityIndexViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            return View(cities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCityViewModel model)
        {
            if (ModelState.IsValid)
            {
                var city = new City
                {
                    Name = model.Name
                };

                await dbContext.Cities.AddAsync(city);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
