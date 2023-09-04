# Song Library Management System

## Project Overview

This project introduces a Song Library Management System that showcases your skills in reading data from a file and creating a complex system involving three interconnected components: SongGenre enum, Song class, and Library class. These components work together to manage and display song information effectively.

### SongGenre Enum

The SongGenre enum encompasses seven distinct song genres, meticulously organized to allow combinations, reflecting real-world scenarios where songs may belong to multiple genres. Each enum value is assigned a unique power of 2, facilitating genre combinations.

Enum Members:

- Unclassified = 0
- Pop = 0b1
- Rock = 0b10
- Blues = 0b100
- Country = 0b1_000
- Metal = 0b10_000
- Soul = 0b100_000

### Song Class

The Song class serves as a data structure to store song details. It includes properties for the artist, title, length, and genre. Notably, setter methods are intentionally absent for these properties.

#### Properties

- Artist: string
- Title: string
- Length: double
- Genre: SongGenre

#### Constructor

- `public Song(string title, string artist, double length, SongGenre genre)`: Constructs a Song object by initializing its properties with provided values.

#### Method

- `public override string ToString()`: Overrides the ToString() method inherited from the object class to offer a string representation of the song.

### Library Class

The Library class represents the user-facing aspect of the application. It functions as a static class, offering a range of methods for loading songs from a file and displaying them based on various criteria.

#### Fields

- `private static List<Song> songs`: A private list that stores song objects.

#### Methods

- `public static void LoadSongs(string fileName)`: Reads song data from a text file, transforms it into Song objects, and populates the songs collection. The file format is specified, so the process adheres to expected structure.

- `public static void DisplaySongs()`: Displays all songs available in the collection.

- `public static void DisplaySongs(double longerThan)`: Presents songs that exceed a specified duration.

- `public static void DisplaySongs(SongGenre genre)`: Exhibits songs belonging to a chosen genre, employing the HasFlags() method for accurate identification.

- `public static void DisplaySongs(string artist)`: Showcases songs by a particular artist.

