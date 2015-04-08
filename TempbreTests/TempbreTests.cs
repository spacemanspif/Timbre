using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timbre.Controllers;
using System.Configuration.ConfigurationManager;
using Tempbre.Models;
namespace TempbreTests
{
    [TestClass]
    public class TempbreTests
    {
        private DiscoFishEntities db = new DiscoFishEntities();

        [TestMethod]
        public void SongsListIsntNull()
        {
            var songs = db.Songs.ToList();

            Assert.IsNotNull(songs);
        }

        [TestMethod]
        public void AlbumsListIsntNull()
        {
            var albums = db.Albums.ToList();

            Assert.IsNotNull(albums);
        }

        [TestMethod]
        public void ArtistsListIsntNull()
        {
            var artists = db.Artists.ToList();

            Assert.IsNotNull(artists);
        }
    }
}
