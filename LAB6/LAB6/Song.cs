using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    public class Song
    {
        public string Artist
        {
            get;
        }
        public SongGenre Genre
        {
            get;
        }
        public double Length
        {
            get;
        }
        public string Title
        {
            get;
        }

        public Song(string title, string artist, double length, SongGenre genre)
        {
            Artist = artist;
            Title = title;
            Length = length;
            Genre = genre;
        }

        public override string ToString()
        {
            return string.Format("{0} by {1} ({2}) {3:f2}min",Title, Artist, Genre, Length);
        }
    }
}
