using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeatBox.Models;

namespace BeatBox.TestTools
{
    [TestClass]
    public class AlbumTests : IDisposable
    {
        public void Dispose()
        {
            Artist.ClearAll();
        }

        [TestMethod]
        public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
        {
            Album newAlbum = new("21");
            Assert.AreEqual(typeof(Album), newAlbum.GetType());
        }
    }
}