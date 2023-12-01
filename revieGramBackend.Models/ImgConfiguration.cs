namespace revieGramBackend.models {
    public class ImgConfiguration {
        public string Base_url {get;}
        public string Secure_base_url {get;}
        public List<string> Poster_sizes {get;}

        public ImgConfiguration(string Base_url, string Secure_base_url, List<string> Poster_sizes) {
            this.Base_url = Base_url;
            this.Secure_base_url = Secure_base_url;
            this.Poster_sizes = Poster_sizes;
        }
    }
}