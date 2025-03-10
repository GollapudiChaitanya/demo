using Demo_Project_Game_Events.Models;
using Demo_Project_Game_Events.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Project_Game_Events.Controllers
{
    public class GameController : Controller
    {
        // GET: GameController1
        GameRepository gameRep = null;
        public GameController(GameEventDbContext ctx)  // DI Feature
        {
            gameRep = new GameRepository(ctx);
        }

        public ActionResult Index()
        {
            List<Game> games = gameRep.AllGameDetails();
            return View(games);
        }

        // GET: GameController1/Details/5
        public ActionResult Details(int id)
        {
            Game game = gameRep.SearchGame(id);
            return View(game);
        }

        // GET: GameController1/Create
        public ActionResult Create()
        {
            Game game = new Game();
            return View(game);
        }

        // POST: GameController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game model)
        {
            try
            {
                bool b =gameRep.AddGame(model);
                if(b)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController1/Edit/5
        public ActionResult Edit(int id)
        {
            Game gameObj = gameRep.SearchGame(id);
            return View(gameObj);
        }

        // POST: GameController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {
            try
            {
                gameRep.UpdateGame(game);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController1/Delete/5
        public ActionResult Delete(int id)
        {
            Game game = gameRep.SearchGame(id);
            gameRep.RemoveGame(game);
            return RedirectToAction("Index");
        }

        // POST: GameController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
