using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine()
                .Split(' ');

            var downloadedSongs = new List<string>();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var isInBlackList = false;
                foreach (var blackListedWord in blackList)
                {
                    if (line.Contains(blackListedWord))
                    {
                        isInBlackList = true;
                        break;
                    }
                }
                if (!isInBlackList)
                {
                    downloadedSongs.Add(line);
                }

                line = Console.ReadLine();
            }

            downloadedSongs.Sort();

            // Console.WriteLine(string.Join(Environment.NewLine, downloadedSongs));

            foreach (var track in downloadedSongs)
            {
                Console.WriteLine(track);
            }
        }
    }
}
