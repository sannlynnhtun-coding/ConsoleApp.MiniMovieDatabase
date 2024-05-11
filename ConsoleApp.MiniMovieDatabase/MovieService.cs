namespace ConsoleApp.MiniMovieDatabase;

internal class MovieService
{
    public void AddMovie(MovieDatabase database) // For demonstration only
    {
        Console.Write("Enter movie title: ");
        string title = Console.ReadLine()!;

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine()!);

        Console.Write("Enter genre: ");
        string genre = Console.ReadLine()!;

        database.AddMovie(title, year, genre);

        Console.WriteLine("Movie added successfully.");
    }

    public void FindMovieByTitle(MovieDatabase database)
    {
        Console.Write("Enter movie title: ");
        string title = Console.ReadLine()!;

        Movie movie = database.FindMovieByTitle(title);

        if (movie != null)
        {
            Console.WriteLine($"\nMovie found:");
            Console.WriteLine($"- Title: {movie.Title}");
            Console.WriteLine($"- Year: {movie.Year}");
            Console.WriteLine($"- Genre: {movie.Genre}");
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }

    public void ListMovies(MovieDatabase database)
    {
        Console.WriteLine("\nMovies:");
        foreach (Movie movie in database.ListMovies())
        {
            Console.WriteLine($"- {movie.Title} ({movie.Year}) - {movie.Genre}");
        }
    }
}