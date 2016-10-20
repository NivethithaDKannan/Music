using System;
using MusicShop.Models;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MusicShop.Controllers
{
    public class HomeController : Controller
    {
        Store musicStore = new Store();
        public HomeController()
        {
            
            List<string> genre = new List<string>();
            var query = from ms in musicStore.Albums
                        select ms.Genre;
            ViewBag.Genre = query;
        }
        [HttpGet]
        public ActionResult Index()
        {
           
            return View(musicStore);
        }

        [HttpPost]
        public ActionResult Index(string search, string genre, int? fromYear, int? toYear)
        {
            var results = from ms in musicStore.Albums
                          where ms.Title.ToLower().Contains(search.ToLower())  
                          select ms;
            if (genre != "") results = results.Where(m => m.Genre.Equals(genre));
            if (fromYear != null) results = results.Where(m => m.Year >= fromYear);
            if (toYear != null) results = results.Where(m => m.Year <=toYear);
            musicStore.Albums =  results.ToList();
            return View(musicStore);
        }
    
     [HttpPost]
        public ActionResult ViewAlbum(int id)
        {
            var result =( from a in musicStore.Albums
                         where a.Id == id
                         select a).FirstOrDefault();          
            return PartialView("_AlbumDetails", result);

        }
    }
}