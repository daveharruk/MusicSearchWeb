namespace MusicSearchWeb
{
    public class Song
    {
        public string? ArtistName { get; set; }
        public string? SongName { get; set; }
        public string? AlbumName { get; set; }

        public Song(string artistName, string songName, string albumName)
        {
            ArtistName = artistName;
            SongName = songName;
            AlbumName = albumName;
        }
    }
}
