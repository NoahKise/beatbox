using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BeatBox.Models;
using System;

namespace BeatBox.Tests
{
  [TestClass]
  public class CategoryTests
  {
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
  }
}