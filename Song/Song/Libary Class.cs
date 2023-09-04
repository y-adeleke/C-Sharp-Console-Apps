
static class Library
{
    private static List<Song> _songs = new List<Song> { };
    public static void DisplaySongs()
    {
        foreach (Song song in _songs)
        {
            Console.WriteLine(song);
        }
    }
    public static void DisplaySongs(double longerThan)
    {
        foreach (Song song in _songs)
        {
            if (song.Length > longerThan)
            {
                Console.WriteLine(song);
            }
        }
    }
    public static void DisplaySongs(SongGenre genre)
    {
        foreach (Song song in _songs)
        {
            if (genre.HasFlag(song.Genre))
            {
                Console.WriteLine(song);
            }
        }
    }
    public static void DisplaySongs(string artist)
    {
        foreach (Song song in _songs)
        {
            if (song.Artist == artist)
            {
                Console.WriteLine(song);
            }
        }
    }
    public static void LoadSongs(string fileName)
    {
        Console.WriteLine("loading song");
        StreamReader filedata = new StreamReader(fileName);
        string title;
        string artist;
        double length;
        SongGenre genre;
        while (!filedata.EndOfStream)
        {
            title = filedata.ReadLine();
            artist = filedata.ReadLine();
            length = Convert.ToDouble(filedata.ReadLine());
            genre = (SongGenre)Enum.Parse(typeof(SongGenre), filedata.ReadLine());
            _songs.Add(new Song(title, artist, length, genre));
        }
        filedata.Close();
        Console.WriteLine("finished loading song");
    }
}


