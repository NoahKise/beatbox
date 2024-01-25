using Microsoft.AspNetCore.Mvc;
using BeatBox.Models;
using System.Collections.Generic;

namespace BeatBox.Controllers
{
    public class AlbumsController : Controller
    {
        [HttpGet("/artists/{artistId}/albums/new")]
        public ActionResult New(int artistId)
        {
            Artist artist = Artist.FindArtist(artistId);
            return View(artist);
        }
    }
}