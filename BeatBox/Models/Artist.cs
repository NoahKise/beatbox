using System.Collections.Generic;

namespace BeatBox.Models
{
    public class Artist
    {
        private static List<Artist> _instances = new() { };
        public string Name {get; set; }
        public int Id { get; }
        public List<Album> Albums { get; set; }

        public Artist(string name)
        {
          Name = name; 
          _instances.Add(this);
          Id = _instances.Count;
          Albums = new List<Album> { };
        }

        public void AddAlbum(Album album)
        {
          Albums.Add(album);
        }
    }
}