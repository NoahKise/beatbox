using Microsoft.AspNetCore.Mvc;
using BeatBox.Models;
using System.Collections.Generic;

namespace BeatBox.Controllers
{
  public class ArtistsController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new(artistName);
      return RedirectToAction("Index");
    }
  }
}