using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeatBox.Models;

namespace BeatBox.TestTools
{
    [TestClass]
    public class AlbumTests : IDisposable
    {
        public void Dispose()
        {
            Album.ClearAll();
        }

        [TestMethod]
        public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
        {
            Album newAlbum = new("21");
            Assert.AreEqual(typeof(Album), newAlbum.GetType());
        }

        [TestMethod]
        public void GetAll_GetAllAlbumInstances_List()
        {
            Album nineteen = new("19");
            Album twentyOne = new("21");
            List<Album> expected = new List<Album> {nineteen, twentyOne};
            CollectionAssert.AreEqual(expected, Album.GetAll());
        }
    }
}