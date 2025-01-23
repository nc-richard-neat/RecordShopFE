namespace RecordShopFE.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; } = new Artist();
        public string AlbumName { get; set; } = "";
        public Genre Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string AlbumArt { get; set; } = "";
        public string SpotifyUrl { get; set; } = "";
    }
}
