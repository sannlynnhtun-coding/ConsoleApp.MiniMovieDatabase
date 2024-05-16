# Mini Movie Database

#### Overview
The `ConsoleApp.MiniMovieDatabase` is a console-based application designed to manage a simple movie database. It allows users to perform CRUD (Create, Read, Update, Delete) operations on movie records.

#### Key Components

1. **Movie Class**:
   - Represents a movie entity with properties such as `Title`, `Director`, `ReleaseYear`, and `Genre`.
   - Example:
     ```csharp
     public class Movie
     {
         public string Title { get; set; }
         public string Director { get; set; }
         public int ReleaseYear { get; set; }
         public string Genre { get; set; }
     }
     ```

2. **MovieRepository Class**:
   - Manages a collection of movies.
   - Provides methods to add, view, update, and delete movies.
   - Example methods:
     ```csharp
     public void AddMovie(Movie movie) { ... }
     public Movie GetMovie(string title) { ... }
     public void UpdateMovie(string title, Movie updatedMovie) { ... }
     public void DeleteMovie(string title) { ... }
     ```

3. **MovieService Class**:
   - Acts as an intermediary between the console application and the `MovieRepository`.
   - Contains business logic to ensure data integrity and validation before performing repository operations.
   - Example methods:
     ```csharp
     public void AddMovie(Movie movie) { ... }
     public void DisplayAllMovies() { ... }
     public void UpdateMovie(string title, Movie updatedMovie) { ... }
     public void RemoveMovie(string title) { ... }
     ```

4. **Console Interface**:
   - Provides a user interface for interacting with the movie database.
   - Handles user input and displays information to the user.
   - Example interaction:
     ```csharp
     Console.WriteLine("Enter movie title:");
     string title = Console.ReadLine();
     ```

### Example Usage
1. **Adding a Movie**:
   ```csharp
   var movie = new Movie
   {
       Title = "Inception",
       Director = "Christopher Nolan",
       ReleaseYear = 2010,
       Genre = "Sci-Fi"
   };
   movieService.AddMovie(movie);
   ```

2. **Viewing Movies**:
   ```csharp
   movieService.DisplayAllMovies();
   ```

3. **Updating a Movie**:
   ```csharp
   var updatedMovie = new Movie
   {
       Title = "Inception",
       Director = "Christopher Nolan",
       ReleaseYear = 2010,
       Genre = "Science Fiction"
   };
   movieService.UpdateMovie("Inception", updatedMovie);
   ```

4. **Deleting a Movie**:
   ```csharp
   movieService.RemoveMovie("Inception");
   ```

### Conclusion
The `ConsoleApp.MiniMovieDatabase` provides a straightforward way to manage movie records through a console interface, demonstrating basic principles of object-oriented programming and CRUD operations.
