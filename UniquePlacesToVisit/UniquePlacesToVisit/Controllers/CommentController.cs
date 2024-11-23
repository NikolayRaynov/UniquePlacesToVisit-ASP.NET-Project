using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniquePlacesToVisit.Data;
using UniquePlacesToVisit.Data.Models;
using UniquePlacesToVisit.Web.ViewModels.Comment;

public class CommentController : Controller
{
    private readonly ApplicationDbContext dbContext;
    private readonly UserManager<ApplicationUser> userManager;

    public CommentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        dbContext = context;
        this.userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> EditComment(int id)
    {
        var comment = await dbContext.Comments.FindAsync(id);
        if (comment == null || comment.UserId.ToString() != userManager.GetUserId(User))
        {
            return Unauthorized();
        }

        var model = new EditCommentViewModel
        {
            Id = comment.Id,
            ReCommentText = comment.ReCommentText
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> EditComment(EditCommentViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var comment = await dbContext.Comments.FindAsync(model.Id);
        if (comment == null || comment.UserId.ToString() != userManager.GetUserId(User))
        {
            return Unauthorized();
        }

        comment.ReCommentText = model.ReCommentText;
        await dbContext.SaveChangesAsync();

        return RedirectToAction("Details", "Review", new { id = comment.ReviewId });
    }

    [HttpPost]
    public async Task<IActionResult> DeleteComment(int id)
    {
        var comment = await dbContext.Comments.FindAsync(id);
        if (comment == null || comment.UserId.ToString() != userManager.GetUserId(User))
        {
            return Unauthorized();
        }

        dbContext.Comments.Remove(comment);
        await dbContext.SaveChangesAsync();

        return RedirectToAction("Details", "Review", new { id = comment.ReviewId });
    }

    [HttpGet]
    public IActionResult ReplyComment(int commentId)
    {
        var model = new ReplyCommentViewModel
        {
            ParentCommentId = commentId
        };
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> ReplyComment(ReplyCommentViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var userId = Guid.Parse(userManager.GetUserId(User)!);

        var comment = new Comment
        {
            ReCommentText = model.ReCommentText,
            CreatedAt = DateTime.Now,
            ReviewId = model.ReviewId,
            UserId = userId,
            ParentCommentId = model.ParentCommentId
        };

        dbContext.Comments.Add(comment);
        await dbContext.SaveChangesAsync();

        return RedirectToAction("Details", "Review", new { id = model.ReviewId });
    }
}
