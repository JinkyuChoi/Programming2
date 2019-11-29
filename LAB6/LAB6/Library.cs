using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB6
{
    public static class Library
    {
        private static List<Song> _songs;

        public static void DisplaySongs()
        {
            for (int i = 0; i < _songs.Count; i++)
            {
                Console.WriteLine(_songs[i]);
            }
        }
        public static void DisplaySongs(double longerThan)
        {
            for (int i = 0; i < _songs.Count; i++)
            {
                if (_songs[i].Length > longerThan)
                {
                    Console.WriteLine(_songs[i]);
                }
            }
        }
        public static void DisplaySongs(SongGenre genre)
        {
            for (int i = 0; i < _songs.Count; i++)
            {
                if (_songs[i].Genre == genre)
                {
                    Console.WriteLine(_songs[i]);
                }
            }
        }
        public static void DisplaySongs(string artist)
        {
            for (int i = 0; i < _songs.Count; i++)
            {
                if (_songs[i].Artist == artist)
                {
                    Console.WriteLine(_songs[i]);
                }
            }
        }
        public static void LoadSongs(string fileName)
        {
            _songs = new List<Song>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                for (int i = 0; reader.EndOfStream == false; i++)
                {
                    string title = reader.ReadLine();
                    string artist = reader.ReadLine();
                    double length = Convert.ToDouble(reader.ReadLine());
                    SongGenre genre;
                    switch (reader.ReadLine())
                    {
                        case "Pop":
                            genre = SongGenre.Pop;
                            break;
                        case "Rock":
                            genre = SongGenre.Rock;
                            break;
                        case "Blues":
                            genre = SongGenre.Blues;
                            break;
                        case "Country":
                            genre = SongGenre.Country;
                            break;
                        case "Metal":
                            genre = SongGenre.Metal;
                            break;
                        case "Soul":
                            genre = SongGenre.Soul;
                            break;
                        default:
                            genre = SongGenre.Unclasified;
                            break;
                    }
                    Song newSong = new Song(title, artist, length, genre);
                    _songs.Add(newSong);
                }
              
            }
        }
        public static void SaveSongs(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < _songs.Count; i++)
                {
                    writer.WriteLine(_songs[i].Title);
                    writer.WriteLine(_songs[i].Artist);
                    writer.WriteLine(_songs[i].Length);
                    writer.WriteLine(_songs[i].Genre);
                }
            }
        }
    }
}
