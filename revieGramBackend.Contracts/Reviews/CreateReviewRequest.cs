using revieGramBackend.Contracts.Users;

namespace revieGramBackend.Contracts.Reviews {
    public record CreateReviewRequest(
        float Rating,
        string Content,
        DateTime Created,
        DateTime Updated,
        int UserId,
        int TMDB_id,
        bool FromTMDB
    );
}