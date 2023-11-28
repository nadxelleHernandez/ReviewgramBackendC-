namespace revieGramBackend.Contracts.TVshows {
    public record GetTVShowResponse(
        string TMDB_id,
        string Name,
        string Overview,
        string Poster_url,
        string Release_date,
        float Rating,
        int Vote_count,
        string Original_language,
        string Origin_Country,
        int Number_of_episodes,
        int Number_of_seasons,
        int Episode_runtime,
        string Status,
        DateTime First_air_date,
        DateTime Last_air_date,
        bool IsMovie,
        List <string> Genres
    );
}