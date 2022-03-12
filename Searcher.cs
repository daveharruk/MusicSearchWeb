using MetaBrainz.MusicBrainz;

namespace MusicSearchWeb
{
    public class Searcher
    {
        public static List<Song> DoSearch(string? searchText)
        {
            var songs = new List<Song>();

            if (!string.IsNullOrEmpty(searchText))
            {
                var query = new Query("MusicSearchWeb", "1.0", "mail@davidharrington.org.uk");
                
                var recordings = query.FindRecordings("artist:\"" + searchText + "\"", limit: 100);
                foreach (var recording in recordings.Results)
                {
                    if (recording.Item != null && recording.Item.Releases != null)
                    {
                        foreach (var release in recording.Item.Releases)
                        {
                            string? album = release.Title;
                            string? track = recording.Item.Title;
                            string artist = searchText;
                            if (album != null && track != null)
                            {
                                songs.Add(new Song(artist, track, album));
                            }
                        }
                    }
                }
            }
            return songs;
        }
    }
}
