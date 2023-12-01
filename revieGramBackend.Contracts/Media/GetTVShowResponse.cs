using revieGramBackend.models;

namespace revieGramBackend.Contracts.Media {
    public record GetTVShowResponse(
        string Message,
        int StatusCode,
        TVShow TVShow
    );
}