namespace revieGramBackend.models {
    public class TVShow {
        public int TMDB_id {get;}
        public string Name {get;}
        public string Overview {get;}
        public float Rating {get;}
        public int Vote_count {get;}
        public string Poster_url {get;}
        public string Original_language {get;}
        public string Origin_country {get;}
        public int Number_of_episodes {get;}
        public int Number_of_seasons {get;}
        public string Status {get;}
        public DateTime First_air_date {get;}
        public DateTime Last_air_date {get;}
        public int Episode_runtime {get;}
        public List <string> Genres {get;}
        public bool IsMovie {get;}

        public TVShow(int TMDB_id, 
                      string Name, 
                      string Overview, 
                      float Rating, 
                      int Vote_count, 
                      string Poster_url,
                      string Original_language,
                      string Origin_Country,
                      int Number_of_episodes,
                      int Number_of_seasons,
                      string Status,
                      DateTime First_air_Date,
                      DateTime Last_air_date,
                      int Episode_runtime,
                      List<string> Genres) 
        {
            this.TMDB_id = TMDB_id;
            this.Name = Name;
            this.Overview = Overview;
            this.Rating = Rating;
            this.Vote_count = Vote_count;
            this.Poster_url = Poster_url;
            this.Origin_country = Origin_Country;
            this.Original_language = Original_language;
            this.Number_of_episodes = Number_of_episodes;
            this.Number_of_seasons = Number_of_seasons;
            this.Status = Status;
            this.First_air_date = First_air_Date;
            this.Last_air_date = Last_air_date;
            this.Episode_runtime = Episode_runtime;
            this.Genres = Genres;
            this.IsMovie = false;
        }
    }
}