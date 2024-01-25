using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BeatBox.Models;
using System;

namespace BeatBox.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }
    
    [TestMethod]
    public void ArtistConstructor_CreateInstanceOfArtist_Artist()
    {
      Artist newArtist = new("Simon and Garfunkel");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetArtistDetails_ReturnsArtistDetails_String()
    {
      string name = "simon and garfunkel";
      Artist simonAndGarfunkel = new(name);
      Assert.AreEqual(simonAndGarfunkel.Name, name);
    }

    [TestMethod]
    public void AddAlbum_AddAlbumToAlbums_List()
    {
        Artist blur = new("blur");
        Album blurAlbum = new("blur");
        List<Album> expected = new List<Album> {blurAlbum};
        blur.AddAlbum(blurAlbum);
        CollectionAssert.AreEqual(expected, blur.Albums);
    }

    [TestMethod]
    public void FindArtist_ReturnsArtistById_Artist()
    {
        Artist eminem = new("eminem");
        Artist mariahCarey = new("Mariah Carey");
        Artist foundArtist = Artist.FindArtist(1);
        Assert.AreEqual(eminem, foundArtist);
    }
  }
}