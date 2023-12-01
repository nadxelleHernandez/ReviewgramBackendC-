using revieGramBackend.models;

namespace revieGramBackend.Contracts.Media {
    public record GetImagesUrlResponse(
        string Message,
        int StatusCode,
        ImgConfiguration Configuration
    );
}