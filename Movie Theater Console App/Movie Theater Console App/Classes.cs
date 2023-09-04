class Movie
{
    public int Length { get; }
    public int Year { get; }
    public string Title { get; }
    public GenreEnum Genre { get; private set; }
    public List<string> Cast { get; }
    public Movie(string title, int year, int length)
    {
        Title = title;
        Year = year;
        Length = length;
        Cast = new List<string>();
    }
    public void AddActor(string actor) => Cast.Add(actor);
    public void SetGenre(GenreEnum genre)
    {
        Genre |= genre;
    }
}



class Theater
{
    private List<Show> shows;
    public string Name { get; }
    public Theater(string name)
    {
        Name = name;
        shows = new List<Show>();
    }
    public void AddShow(Show show)
    {
        shows.Add(show);
    }
    public void PrintShows()
    {
        int count = 1;
        Console.WriteLine();
        Console.WriteLine($"Theater name: ${Name}");
        Console.WriteLine($"All shows");
        Console.WriteLine($"================");
        foreach (Show show in shows)
        {
            Console.WriteLine($"show {count}: {show}");
            count++;
        }
    }
    public void PrintShows(GenreEnum genre)
    {
        int count = 1;
        Console.WriteLine();
        Console.WriteLine($"Theater name: ${Name}");
        Console.WriteLine($"{genre}");
        Console.WriteLine($"================");
        foreach (Show show in shows)
        {
            if (show.Movie.Genre.HasFlag(genre))
            {
                Console.WriteLine($"show {count}: {show}");
                count++;
            }
        }
    }
    public void PrintShows(DayEnum day)
    {
        int count = 1;
        Console.WriteLine();
        Console.WriteLine($"Theater name: ${Name}");
        Console.WriteLine($"movies on:{day}");
        Console.WriteLine($"================");
        foreach (Show show in shows)
        {
            if (show.Day == day)
            {
                Console.WriteLine($"show {count}: {show}");
                count++;
            }
        }
    }
    public void PrintShows(Time time)
    {
        int count = 1;
        Console.WriteLine();
        Console.WriteLine($"Theater name: ${Name}");
        Console.WriteLine($"movies @{time}");
        Console.WriteLine($"================");
        foreach (Show show in shows)
        {
            if (show.Time == time)
            {
                Console.WriteLine($"show {count}: {show}");
                count++;
            }
        }
    }
    public void PrintShows(string actor)
    {
        int count = 1;
        Console.WriteLine();
        Console.WriteLine($"Theater name: ${Name}");
        Console.WriteLine($" movies by:{actor}");
        Console.WriteLine($"================");
        foreach (Show show in shows)
        {
            if (show.Movie.Cast.Contains(actor))
            {
                Console.WriteLine($"show {count}: {show}");
                count++;
            }
        }
    }
    public void PrintShows(DayEnum day, Time time)
    {
        int count = 1;
        Console.WriteLine();
        Console.WriteLine($"Theater name: ${Name}");
        Console.WriteLine($"movies @{time} on {day}");
        Console.WriteLine($"================");
        foreach (Show show in shows)
        {
            if (show.Day == day && show.Time == time)
            {
                Console.WriteLine($"show {count}: {show}");
                count++;
            }
        }
    }
}
