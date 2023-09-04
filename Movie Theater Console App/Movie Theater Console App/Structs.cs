using System.Linq;

struct Time
{
    public int Hours { get; }
    public int Minutes { get; }
    public Time(int hours, int minutes = 0)
    {
        Hours = hours;
        Minutes = minutes;
    }
    public static bool operator ==(Time lhs, Time rhs)
    {
        int lhsMinutes = (lhs.Hours * 60) + lhs.Minutes;
        int rhsMinutes = (rhs.Hours * 60) + rhs.Minutes;
        int minutesDiffrence = Math.Abs(lhsMinutes - rhsMinutes);
        return minutesDiffrence <= 15;
    }
    public static bool operator !=(Time lhs, Time rhs)
    {
        int lhsMinutes = (lhs.Hours * 60) + lhs.Minutes;
        int rhsMinutes = (rhs.Hours * 60) + rhs.Minutes;
        int minutesDiffrence = Math.Abs(lhsMinutes - rhsMinutes);
        return !(minutesDiffrence <= 15);
    }
    public override string ToString()
    {
        return $"{Hours}:{Minutes}";
    }
}


struct Show
{
    public double Price { get; }
    public DayEnum Day { get; }
    public Movie Movie { get; }
    public Time Time { get; }

    public Show(Movie movie, Time time, DayEnum day, double price)
    {
        Price = price;
        Day = day;
        Movie = movie;
        Time = time;
    }
    public override string ToString()
    {
        return $"Movie title:{Movie.Title}, Movie Year:{Movie.Year}, Movie time:{Time.Hours}:{Time.Minutes}, " +
            $"Movie day:{Day}, Movie Cast:{string.Join(",", Movie.Cast)}";
    }
}
