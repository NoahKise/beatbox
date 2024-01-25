namespace BeatBox.Models
{
    public class Album
    {
        private static List<Artist> _instances = new() { };
        public string Name {get; set; }
        public int Id { get; }
    }
}