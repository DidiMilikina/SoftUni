public class Song
{
    private string name;
    private string songName;
    private int minutes;
    private int seconds;
    private int totalLength;

    public Song(string name, string songName, int minutes, int seconds)
    {
        this.Name = name;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }
            this.seconds = value;
        }
    }

    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }
            this.minutes = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }
            this.songName = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
            this.name = value;
        }
    }
}