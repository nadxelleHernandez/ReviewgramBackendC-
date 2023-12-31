using revieGramBackend.models;

namespace revieGramBackend.Contracts.Media {

    public record GetMovieResponse(
        string Message,
        Movie Movie,
        int StatusCode
    );
}