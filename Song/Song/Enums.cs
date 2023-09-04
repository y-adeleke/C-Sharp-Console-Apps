
[FlagsAttribute]
public enum SongGenre
{
    Unclassified = 0, //0
    Pop = 0b1, //1
    Rock = 0b10, //2
    Blues = 0b100, //4
    Country = 0b1_000, //8
    Metal = 0b10_000, //16
    Soul = 0b100_000, //32
}
