using System.Data.Common;
using revieGramBackend.Contracts.Reviews;

namespace revieGramBackend.Contracts.Reviews {
    public record UpdateReviewRequest(
        int Id,
        float Rating,
        string Content,
        DateTime Created,
        DateTime Updated,
        int UserId,
        int TMDB_id,
        bool FromTMDB
    );
}