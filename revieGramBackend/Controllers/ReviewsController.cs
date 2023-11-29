using Microsoft.AspNetCore.Mvc;
using revieGramBackend.Contracts.Reviews;

namespace revieGramBackend.Controllers;

[ApiController]
public class ReviewsController : ControllerBase 
{
    [HttpPost("/{user_id}/reviews")]
    public IActionResult CreateReview(CreateReviewRequest reviewRequest) {
        return Ok(reviewRequest);
    }
}