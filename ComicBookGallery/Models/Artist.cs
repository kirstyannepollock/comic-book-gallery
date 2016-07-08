namespace ComicBookGallery.Models
{
    public class Artist
    {

        public Artist() { }

        public Artist(string role, string name)
        {
            Name = name;
            Role = role;
        }

        public string Name { get; set; }
        public string Role { get; set; }
    }
}