# Movie Theater Console Application

This console application manages movie shows in a theater. It allows you to add movies, actors, and shows, and then retrieve information about the shows based on various criteria such as genre, day, time, and more.

## Table of Contents

- [Structs](#structs)
- [Classes](#classes)
- [Enums](#enums)
- [Usage](#usage)
- [Examples](#examples)

## Structs

### Time

- Represents a time with hours and minutes.
- Provides comparison operators for checking if two times are within 15 minutes of each other.

### Show

- Represents a movie show with price, day, movie, and time.
- Includes a method to convert the show to a string for display.

## Classes

### Movie

- Represents a movie with length, year, title, genre, and cast.
- Allows adding actors and setting the genre.

### Theater

- Manages a list of shows in a theater.
- Provides methods to add shows and print shows based on various criteria such as genre, day, time, actor, and combinations of these.

## Enums

### DayEnum

- Represents days of the week (Sunday to Saturday).

### GenreEnum

- Represents movie genres using flags.

## Usage

1. Create movies using the `Movie` class by specifying the title, year, and length.
2. Add actors to movies using the `AddActor` method.
3. Set the genre of movies using the `SetGenre` method.
4. Create shows using the `Show` class by specifying the movie, time, day, and price.
5. Create a theater using the `Theater` class.
6. Add shows to the theater using the `AddShow` method.
7. Use various `PrintShows` methods in the theater to retrieve and display shows based on different criteria.

## Examples

Here are some examples of how to use the application:

```csharp
// Example code for creating movies, shows, and a theater
// ...

// Display all shows in the theater
eglinton.PrintShows();

// Display shows on a specific day
eglinton.PrintShows(DayEnum.Sun);

// Display shows of a specific genre
eglinton.PrintShows(GenreEnum.Action);

// Display shows of multiple genres
eglinton.PrintShows(GenreEnum.Action | GenreEnum.Romance);

// Display shows by actor
eglinton.PrintShows("Morgan Freeman");

// Display shows at a specific time
Time time = new Time(14, 05);
eglinton.PrintShows(time);

// Display shows on a specific day and time
eglinton.PrintShows(DayEnum.Sun, time);

