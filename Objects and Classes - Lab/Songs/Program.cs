using System;
using System.Collections.Generic;
using System.Linq;
namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] nameSong = Console.ReadLine().Split('_').ToArray();

                string type = nameSong[0];
                string name = nameSong[1];
                string time = nameSong[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);



            }

            string finalCommand = Console.ReadLine();

            if (finalCommand == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == finalCommand)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }


        }
    }

}
