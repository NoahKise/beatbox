using Microsoft.AspNetCore.Mvc;

namespace BeatBox.Controllers
{
  public class SearchController : Controller
  {
    [HttpGet("/search")]
    public ActionResult Index() 
    {
      return View();
    }

    // [HttpGet("search/{artistName}")]
    // public ActionResult Show()
    // {
    //   for (Artist artist in Artist.GetAll())
    //   {
    //     if(artistName == artist.Name)
    //     {
    //       return 
    //     }
    //   }
    // }
  }
}

// using Microsoft.AspNetCore.Mvc;
// using System.Linq;

// namespace BeatBox.Controllers
// {
//     public class SearchController : Controller
//     {
//         [HttpGet("/search")]
//         public ActionResult Index()
//         {
//             return View();
//         }

//         [HttpGet("/search/{artistName}")]
//         public ActionResult Show(string artistName)
//         {
//             var foundArtist = Artist.GetAll().FirstOrDefault(artist => artist.Name == artistName);

//             if (foundArtist != null)
//             {
//                 return View(foundArtist);
//             }

//             return NotFound(); // Artist not found
//         }
//     }
// }