using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GamesASP.Models;
using PagedList.Mvc;
using PagedList;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
      

        // создаем контекст данных
        GameContext db = new GameContext();

        public ActionResult Index()
        {
            IEnumerable<Genres> genry = db.Genres;
            ViewBag.Genres = genry;


            return View();
        }
        public ViewResult Game(int? page, string sortOrder, string currentFilter, string searchString)
        {
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "Date desc" : "Date";
            IEnumerable<Game> games = from s in db.Games select s;
            ViewBag.CurrentFilter = searchString;
          /*  if (!String.IsNullOrEmpty(searchString))
            {
                games = games.Where(s => s.GameName.ToUpper().Contains(searchString.ToUpper()));
            }
            */
                switch (sortOrder)
            {
                case "Name desc":
                    games = games.OrderByDescending(s => s.GameName);
                    break;
                case "Date":
                    games = games.OrderBy(s => s.YearGame);
                    break;
                case "Date desc":
                    games = games.OrderByDescending(s => s.YearGame);
                    break;
                default:
                    games = games.OrderBy(s => s.GameName);
                    break;
            }



           // IEnumerable<Game> games = db.Games.OrderByDescending(p=>p.YearGame);
            ViewBag.Games = games.ToPagedList(pageNumber, pageSize);         


            return View(games.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult Developer(int? page, string sortOrder, string currentFilter, string searchString)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "Date desc" : "Date";
            IEnumerable<Developer> devs = db.Dev.OrderBy(p=>p.DevName);
            ViewBag.CurrentFilter = searchString;
            /*  if (!String.IsNullOrEmpty(searchString))
              {
                  games = games.Where(s => s.GameName.ToUpper().Contains(searchString.ToUpper()));
              }
              */
            switch (sortOrder)
            {
                case "Name desc":
                    devs = devs.OrderByDescending(s => s.DevName);
                    break;
                case "Date":
                    devs = devs.OrderBy(s => s.YearDev);
                    break;
                case "Date desc":
                    devs = devs.OrderByDescending(s => s.YearDev);
                    break;
                default:
                    devs = devs.OrderBy(s => s.DevName);
                    break;
            }



            ViewBag.Dev = devs.ToPagedList(pageNumber, pageSize);
            
                return View(devs.ToPagedList(pageNumber, pageSize));
        }
    }
}
