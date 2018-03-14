using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        List<Song> songs = new List<Song>();
        int attempts = int.Parse(Console.ReadLine());

        for (int i = 0; i < attempts; i++)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            try
            {
                string[] time = input[2].Split(':').ToArray();
                int digit1 = 0;
                int digit2 = 0;
                if (int.TryParse(time[0], out digit1) && int.TryParse(time[1], out digit2))
                {
                    songs.Add(new Song(input[0], input[1], digit1, digit2));
                    Console.WriteLine("Song added.");
                }
                else
                {
                    throw new InvalidSongLengthException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        int totalDuration = 0;
        foreach (var song in songs)
        {
            totalDuration += song.Minutes * 60 + song.Seconds;
        }

        int hours = totalDuration / 3600;
        totalDuration -= hours * 3600;
        int minutes = totalDuration / 60;
        totalDuration -= minutes * 60;
        int seconds = totalDuration;

        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
    }
}
