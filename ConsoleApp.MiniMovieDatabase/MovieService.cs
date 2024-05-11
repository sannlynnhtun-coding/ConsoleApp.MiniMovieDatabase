using Dumpify;
using System.Data;
using System.Drawing;

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

        //Movie movie = database.FindMovieByTitle(title);

        //if (movie != null)
        //{
        //    Console.WriteLine($"\nMovie found:");
        //    Console.WriteLine($"- Title: {movie.Title}");
        //    Console.WriteLine($"- Year: {movie.Year}");
        //    Console.WriteLine($"- Genre: {movie.Genre}");
        //}
        //else
        //{
        //    Console.WriteLine("Movie not found.");
        //}

        var movies = database.FindMoviesByTitle(title);
        if (movies.Count == 0)
        {
            Console.WriteLine("Movie not found.");
            return;
        }
        Console.WriteLine($"\nMovie found:");
        ToDataTable(movies).Dump();
    }

    public void ListMovies(MovieDatabase database)
    {
        Console.WriteLine("\nMovies:");
        foreach (Movie movie in database.ListMovies())
        {
            Console.WriteLine($"- {movie.Title} ({movie.Year}) - {movie.Genre}");
        }
    }

    public DataTable ToDataTable<T>(List<T> data)
    {
        DataTable table = new DataTable();

        // Define columns based on object properties (assuming public getters)
        foreach (var prop in typeof(T).GetProperties())
        {
            table.Columns.Add(prop.Name, prop.PropertyType);
        }

        foreach (var item in data)
        {
            DataRow row = table.NewRow();
            foreach (var prop in typeof(T).GetProperties())
            {
                row[prop.Name] = prop.GetValue(item);
            }
            table.Rows.Add(row);
        }

        return table;
    }
}