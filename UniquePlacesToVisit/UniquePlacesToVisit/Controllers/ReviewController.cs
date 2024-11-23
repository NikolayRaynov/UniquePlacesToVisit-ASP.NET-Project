using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniquePlacesToVisit.Data;
using UniquePlacesToVisit.Data.Models;
using UniquePlacesToVisit.Web.ViewModels.Review;

public class ReviewController : Controller
{
    private readonly ApplicationDbContext dbContext;
    private readonly UserManager<ApplicationUser> userManager;

    public ReviewController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        dbContext = context;
        this.userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> EditReview(int id)
    {
        var review = await dbContext.Reviews.FindAsync(id);
        if (review == null || review.UserId.ToString() != userManager.GetUserId(User))
        {
            return Unauthorized();
        }

        var model = new EditReviewViewModel
        {
            Id = review.Id,
            ReviewText = review.ReviewText!,
            Rating = review.Rating
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> EditReview(EditReviewViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var review = await dbContext.Reviews.FindAsync(model.Id);
        if (review == null || review.UserId.ToString() != userManager.GetUserId(User))
        {
            return Unauthorized();
        }

        review.ReviewText = model.ReviewText;
        review.Rating = model.Rating;
        await dbContext.SaveChangesAsync();

        return RedirectToAction("Details", "Attraction", new { id = review.AttractionId });
    }

    [HttpPost]
    public async Task<IActionResult> DeleteReview(int id)
    {
        var review = await dbContext.Reviews.FindAsync(id);
        if (review == null || review.UserId.ToString() != userManager.GetUserId(User))
        {
            return Unauthorized();
        }

        dbContext.Reviews.Remove(review);
        await dbContext.SaveChangesAsync();

        return RedirectToAction("Details", "Attraction", new { id = review.AttractionId });
    }
}
