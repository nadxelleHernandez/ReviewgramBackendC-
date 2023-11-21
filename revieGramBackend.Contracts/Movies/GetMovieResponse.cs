namespace revieGramBackend.Contracts.Movies {
    public record GetMovieResponse(
        string TMDB_id,
        string Title,
        string Overview,
        string Poster_url,
        string Release_date,
        float Rating,
        int Vote_count,
        string Original_language,
        bool IsMovie
    );
}