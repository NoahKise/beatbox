namespace BeatBox.Models
{
    public class Artist
    {
        private static List<Artist> _instances = new() { };
        public string Name {get; set; }
        public int Id { get; }
        public List<Album> Albums { get; set; }

        
    }
}