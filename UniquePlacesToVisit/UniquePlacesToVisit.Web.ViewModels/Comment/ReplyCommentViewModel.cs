using System.ComponentModel.DataAnnotations;

public class ReplyCommentViewModel
{
    public int ParentCommentId { get; set; }
    public int ReviewId { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Коментарът не може да надвишава 500 символа.")]
    public string ReCommentText { get; set; } = string.Empty;
}
