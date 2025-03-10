using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Project_Game_Events.Controllers
{
    public class EventController : Controller
    {
        // GET: EventController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: EventController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EventController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: EventController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventController1/Delete/5
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
