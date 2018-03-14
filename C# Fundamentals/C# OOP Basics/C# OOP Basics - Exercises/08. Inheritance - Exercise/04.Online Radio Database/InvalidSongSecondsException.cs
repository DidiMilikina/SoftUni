using System;

class InvalidSongException : Exception
{
    private string exceptionMessage = "Invalid song.";

    protected virtual string ExceptionMessage
    {
        set
        {
            this.exceptionMessage = value;
        }
    }
    public override string Message => exceptionMessage;
}

class InvalidArtistNameException : InvalidSongException
{
    public override string Message => "Artist name should be between 3 and 20 symbols.";
}

class InvalidSongNameException : InvalidSongException
{
    public override string Message => "Song name should be between 3 and 30 symbols.";
}

class InvalidSongLengthException : InvalidSongException
{
    public override string Message => "Invalid song length.";
}

class InvalidSongMinutesException : InvalidSongLengthException
{
    public override string Message => "Song minutes should be between 0 and 14.";
}

class InvalidSongSecondsException : InvalidSongLengthException
{
    public override string Message => "Song seconds should be between 0 and 59.";
}