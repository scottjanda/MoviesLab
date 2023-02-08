using MoviesLab;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

List<Movie> moviesList = new() {
    new Movie("Apocalypse Now","Drama",153,1979)
    ,new Movie("Home Alone", "Comedy",103,1990) 
    ,new Movie("Casino", "Drama",178,1995)
    ,new Movie("Donnie Darko", "Drama",113,2001)
    ,new Movie("Encanto", "Family", 102, 2021)
    ,new Movie("Friday the 13th", "Horror", 95, 1980)
    ,new Movie("Ghost in the Shell", "Si-Fi", 83, 1995)
    ,new Movie("Back to the Future", "Comedy", 116, 1985)
    ,new Movie("Inception", "Si-Fi", 148, 2010)
    ,new Movie("Jackie Brown", "Drama", 154, 1997)
};

List<Movie> sortedMoviesList = moviesList.OrderBy(x => x.title).ToList();
string[] categoryArray = sortedMoviesList.Select(x => x.category).Distinct().ToArray();
string userContinue = "y";

Console.WriteLine($"Welcome to the Movie List Application!\n\nThere are {moviesList.Count()} movies in this list.\n");

do
{
    int counter = 1;
    Console.WriteLine("The following categories are available:\n");
    foreach (var item in sortedMoviesList.GroupBy(x => x.category).ToArray())
    {
        Console.WriteLine($"{counter} {item.Key}");
        counter++;
    }

    Console.WriteLine("\nWhat category are you interested in? Please enter the coresponding number: ");

    bool userInput = int.TryParse(Console.ReadLine(), out int userSelection);

    if (userInput == false || userSelection < 1 || userSelection > categoryArray.Length)
    {
        Console.WriteLine("That is not a valid category!");
        continue;
    }

    Console.WriteLine();
    foreach (var item in sortedMoviesList)
    {
        if (categoryArray[userSelection - 1].ToLower() == item.category.ToLower())
        {
            Console.WriteLine($"Title: {item.title}, Run Time: {item.runTime}, Release year: {item.releaseYear}");
        }
    }

    Console.WriteLine("\nDo you want to enter a new category? ");
    userContinue = Console.ReadLine();

} while (userContinue.ToLower() == "y");

Console.WriteLine("\nGoodbye!");