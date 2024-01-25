using System.Collections.Generic;

namespace BeatBox.Models
{
    public class Album
    {
        private static List<Album> _instances = new() { };
        public string Name {get; set; }
        public int Id { get; }

        public Album(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
        }

    }
}