using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicSearchWeb;
using System.Collections.Generic;

namespace MusicSearchWebTest
{
    [TestClass]
    public class UnitTestBasic
    {
        [TestMethod]
        public void TestMethodVerka()
        {
            List<Song> expectedSongs = new List<Song>()
            {
              new Song("Verka Seduchka", albumName: "Die grössten Grand-Prix-Hits aller Zeiten", songName: "Dancing Lasha Tumbai"),
              new Song("Verka Seduchka", albumName: "Absolute Charter", songName: "Dancing Lasha Tumbai"),
              new Song("Verka Seduchka", albumName: "Hitbreaker 4/2007", songName: "Dancing Lasha Tumbai")
            };
            var result = MusicSearchWeb.Searcher.DoSearch("Verka Seduchka");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result[0].SongName == "Dancing Lasha Tumbai");
            Assert.IsTrue(result[1].SongName == "Dancing Lasha Tumbai");
            Assert.IsTrue(result[2].SongName == "Dancing Lasha Tumbai");
            Assert.IsTrue(result[0].AlbumName == "Die grössten Grand-Prix-Hits aller Zeiten");
        }

        [TestMethod]
        public void TestMethodNull()
        {
            var expectedSongs = new List<Song>();
            var result2 = MusicSearchWeb.Searcher.DoSearch(null);
            Assert.IsTrue(result2 != null && result2.Count == 0);
        }

        [TestMethod]
        public void TestMethodEmpty()
        {
            var expectedSongs = new List<Song>();
            var result3 = MusicSearchWeb.Searcher.DoSearch(string.Empty);
            Assert.IsTrue(result3 != null && result3.Count == 0);
        }
    }
}