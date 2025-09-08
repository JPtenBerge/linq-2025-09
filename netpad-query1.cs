var movies = new List<Movie>
{
    new Movie
    {
        Title = "In the Matrix",
        ReleaseYear = 2010,
        Actors = new List<Actor>
        {
            new Actor { Name = "Keanu Reeves", DateOfBirth = new DateOnly(1964, 9, 2) },
            new Actor { Name = "Carrie-Anne Moss", DateOfBirth = new DateOnly(1967, 8, 21) },
            new Actor { Name = "Laurence Fishburne", DateOfBirth = new DateOnly(1961, 7, 30) },
            new Actor { Name = "Hugo Weaving", DateOfBirth = new DateOnly(1959, 7, 30) },
        }
    },
    new Movie
    {
        Title = "Inception",
        ReleaseYear = 2010,
        Actors = new List<Actor>
        {
            new Actor { Name = "Leonardo DiCaprio", DateOfBirth = new DateOnly(1974, 11, 11) },
            new Actor { Name = "Joseph Gordon-Levitt", DateOfBirth = new DateOnly(1981, 2, 17) },
            new Actor { Name = "Elliot Page", DateOfBirth = new DateOnly(1987, 2, 21) }
        }
    },
    new Movie
    {
        Title = "Interstellar",
        ReleaseYear = 2014,
        Actors = new List<Actor>
        {
            new Actor { Name = "Matthew McConaughey", DateOfBirth = new DateOnly(1969, 11, 4) },
            new Actor { Name = "Anne Hathaway", DateOfBirth = new DateOnly(1982, 11, 12) },
            new Actor { Name = "Jessica Chastain", DateOfBirth = new DateOnly(1977, 3, 24) }
        }
    }
};

var filterLetter = "I";

// var filteredMovies = (from m
//                      in movies
//                      where m.Title.StartsWith(filterLetter)
//                      let nrOfActors = m.Actors.Count()
//                      orderby nrOfActors descending, m.Title descending
//                      select new
//                      {
//                         m.Title,
//                         m.ReleaseYear,
//                         NrOfActors = nrOfActors
//                      });
// filterLetter = "Q";

var filteredMovies = from m
                     in movies.Where(x => x.Title.StartsWith("I"))
                     group m by new { m.ReleaseYear } into grp
                     select new
                     {
                         grp.Key,
                         NrOfMovies = grp.Count()
                     };
filteredMovies.Dump();




class Movie
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }

    public List<Actor> Actors { get; set; } = [];
}

class Actor
{
    public string Name { get; set; }
    public DateOnly DateOfBirth { get; set; }
}