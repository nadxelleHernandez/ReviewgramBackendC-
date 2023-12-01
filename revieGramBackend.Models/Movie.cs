namespace revieGramBackend.models {
    public class Movie {
        public int TMDB_id {get;}
        public string Title {get;}
        public string Overview {get;}
        public string Poster_url {get;}
        public DateTime Release_date {get;}
        public float Rating {get;}
        public int Vote_count {get;}
        public string Original_language {get;}
        public bool IsMovie {get;}
        List <string> Genres {get;}

        public Movie(int TMDB_id, 
                    string Title, 
                    string Overview, 
                    string Poster_url,
                    DateTime release_date, 
                    float Rating, 
                    int Vote_count, 
                    string Original_language, 
                    List<string> Genres) 
        {
            this.TMDB_id = TMDB_id;
            this.Title = Title;
            this.Overview = Overview;
            this.Poster_url = Poster_url;
            this.Release_date = release_date;
            this.Rating = Rating;
            this.Vote_count = Vote_count;
            this.Original_language = Original_language;
            this.IsMovie = true;
            this.Genres = Genres;
        }
    }
}