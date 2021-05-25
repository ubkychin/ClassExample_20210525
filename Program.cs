using System;
using System.Collections.Generic;

namespace ClassExample_20210525
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Song s1 = new Song("I'm Gonna Be", "The Proclaimers", 186);
            Song s2 = new Song("Song 2", "Blur", 90);
            Song s3 = new Song("Another one bites the dust", "Queen", 240);

            List<Song> tracks = new List<Song>();
            tracks.Add(s2);
            tracks.Add(s1);
            tracks.Add(s3);

            Album a1 = new Album("Random songs", "Random Artists", tracks);

            System.Console.WriteLine($"Name of album a1: {a1.Title}");
            System.Console.WriteLine($"Name of the first track on a1: {a1.Tracks[0].Title}");
            System.Console.WriteLine($"Total running time of album a1: {a1.GetAlbumRunTime()}");
            System.Console.WriteLine($"The creator of the second track on a1: {a1.Tracks[1].Creator}");

        }
    }
}
