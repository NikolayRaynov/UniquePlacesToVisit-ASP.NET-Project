using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniquePlacesToVisit.Data;
using UniquePlacesToVisit.Data.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniquePlacesToVisit.Web.ViewModels.Attraction;
using UniquePlacesToVisit.Web.ViewModels.Review;
using UniquePlacesToVisit.Web.ViewModels.Comment;

namespace UniquePlacesToVisit.Controllers
{
    public class AttractionController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public AttractionController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var attractions = await dbContext.Attractions
                .Include(a => a.City)
                .Select(a => new AttractionIndexViewModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImagePath = a.ImagePath,
                    Description = a.Description,
                    Location = a.Location,
                    CityName = a.City.Name
                })
                .ToListAsync();

            return View(attractions);
        }

        public IActionResult Create()
        {
            ViewData["Cities"] = new SelectList(dbContext.Cities, "Id", "Name");
            return View(new CreateAttractionViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAttractionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var attraction = new Attraction
                {
                    Name = model.Name,
                    Description = model.Description,
                    Location = model.Location,
                    ImagePath = model.ImagePath,
                    CityId = model.CityId,
                    UserId = Guid.Parse("babedf22-6aca-4570-a7fc-23bc05fca770")
                };

                dbContext.Add(attraction);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CityId"] = new SelectList(dbContext.Cities, "Id", "Name", model.CityId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var attraction = await dbContext.Attractions.FindAsync(id);
            if (attraction == null)
            {
                return NotFound();
            }

            var model = new EditAttractionViewModel
            {
                Id = attraction.Id,
                Name = attraction.Name,
                Description = attraction.Description,
                Location = attraction.Location,
                ImagePath = attraction.ImagePath,
                CityId = attraction.CityId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditAttractionViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var attraction = await dbContext.Attractions.FindAsync(id);
                if (attraction == null)
                {
                    return NotFound();
                }

                attraction.Name = model.Name;
                attraction.Description = model.Description;
                attraction.Location = model.Location;
                attraction.ImagePath = model.ImagePath;
                attraction.CityId = model.CityId;

                try
                {
                    dbContext.Update(attraction);
                    await dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!dbContext.Attractions.Any(e => e.Id == attraction.Id))
                    {
                        return NotFound();
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            
            var userIdValue = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userIdValue) || !Guid.TryParse(userIdValue, out var loggedUserId))
            {
                return Unauthorized();
            }

            
            var attraction = await dbContext.Attractions
                .Include(a => a.City)
                .Include(a => a.Reviews)
                .ThenInclude(r => r.Comments)
                .ThenInclude(c => c.User)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (attraction == null)
            {
                return NotFound();
            }

            var reviews = attraction.Reviews?.Select(r => new ReviewViewModel
            {
                ReviewText = r.ReviewText ?? string.Empty,
                Rating = r.Rating,
                CreatedAt = r.CreatedAt,
                UserName = r.User?.UserName ?? "Unknown user",
                Comments = r.Comments?.Select(c => new CommentViewModel
                {
                    Id = c.Id,
                    ReCommentText = c.ReCommentText ?? string.Empty,
                    CreatedAt = c.CreatedAt,
                    UserName = c.User?.UserName ?? "Unknown user",
                    IsUserCommentOwner = c.UserId == loggedUserId
                }).ToList() ?? new List<CommentViewModel>(),
                IsUserReviewOwner = r.UserId == loggedUserId
            }).ToList() ?? new List<ReviewViewModel>();

            var viewModel = new AttractionDetailsViewModel
            {
                Id = attraction.Id,
                Name = attraction.Name,
                Description = attraction.Description,
                Location = attraction.Location,
                CityName = attraction.City?.Name ?? "City is not found",
                ImagePath = attraction.ImagePath,
                Reviews = reviews
            };

            return View(viewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var attraction = await dbContext.Attractions
                .Include(a => a.City)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (attraction == null)
            {
                return NotFound();
            }

            var viewModel = new DeleteAttractionViewModel
            {
                Id = attraction.Id,
                Name = attraction.Name,
                Description = attraction.Description,
                Location = attraction.Location,
                CityName = attraction.City.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attraction = await dbContext.Attractions.FindAsync(id);

            if (attraction != null)
            {
                dbContext.Attractions.Remove(attraction);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
