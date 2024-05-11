class MovieDatabase
{
    private List<Movie> movies;

    public MovieDatabase()
    {
        movies = new List<Movie>();
    }

    public void AddMovie(string title, int year, string genre)
    {
        movies.Add(new Movie { Title = title, Year = year, Genre = genre });
    }

    public List<Movie> ListMovies()
    {
        return movies;
    }

    public Movie FindMovieByTitle(string title)
    {
        return movies.Find(movie => movie.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase));

    }

    public List<Movie> FindMoviesByTitle(string title)
    {
        return movies.Where(x => x.Title.Contains(title)).ToList();
    }
}
