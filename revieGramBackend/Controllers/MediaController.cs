using Microsoft.AspNetCore.Mvc;

namespace revieGramBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class MediaController : ControllerBase 
{
    [HttpGet("image-url")]
    public IActionResult GetImagesUrl() {
        return Ok();
    }

    [HttpPost("search")]
    public IActionResult SearchMedia(string query) {
        return Ok(query);
    }

    [HttpGet("movies/{TMDB_id:int}")]
    public IActionResult GetMovie(int TMDB_id) {
        return Ok(TMDB_id);
    }

    [HttpGet("tv/{TMDB_id:int}")]
    public IActionResult GetTVShow(int TMDB_id) {
        return Ok(TMDB_id);
    }

    [HttpGet("top/movies")]
    public IActionResult GetTopMovies() {
        return Ok();
    }

    [HttpGet("top/tvshows")]
    public IActionResult GetTopTVShows() {
        return Ok();
    }

    [HttpGet("tv/{TMDB_id:int}/reviews")]
    public IActionResult GetTVShowReviews(int TMDB_id) {
        return Ok(TMDB_id);
    }

    [HttpGet("movies/{TMDB_id:int}/reviews")]
    public IActionResult GetMovieReviews(int TMDB_id) {
        return Ok(TMDB_id);
    }
}