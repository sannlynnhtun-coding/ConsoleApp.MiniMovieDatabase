using ConsoleApp.MiniMovieDatabase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

var jsonStr = await File.ReadAllTextAsync("data.json");
List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonStr)!;

MovieDatabase database = new MovieDatabase();
MovieService movieService = new MovieService();
foreach (Movie movie in movieList)
{
    database.AddMovie(movie.Title, movie.Year, movie.Genre);
}

// Add some sample movies
//database.AddMovie("The Shawshank Redemption", 1994, "Drama");
//database.AddMovie("The Godfather", 1972, "Crime");
//database.AddMovie("The Lord of the Rings: The Fellowship of the Ring", 2001, "Fantasy");

bool continueProgram = true;

while (continueProgram)
{
    Console.WriteLine("Welcome to the Movie Database!");
    Console.WriteLine("1. List all movies");
    Console.WriteLine("2. Find movie by title");
    Console.WriteLine("3. Add movie (for demonstration only)");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            movieService.ListMovies(database);
            break;
        case "2":
            movieService.FindMovieByTitle(database);
            break;
        case "3":
            movieService.AddMovie(database); // This is for demonstration only, remove in production
            break;
        case "4":
            continueProgram = false;
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}