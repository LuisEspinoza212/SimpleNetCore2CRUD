using Microsoft.AspNetCore.Mvc;
using SimpleNetCoreCRUD.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNetCoreCRUD.Controllers
{
    public class VideogameController : Controller
    {
        protected ApplicationDbContext _db;

        public VideogameController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Videogames.ToList());
        }

        // Get : Videogame/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Videogame videogame)
        {
            if (ModelState.IsValid)
            {
                _db.Add(videogame);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(videogame);
        }

        // Get : Videogame/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var videogame = _db.Videogames.SingleOrDefault(m => m.Id == id);

            if (videogame == null) return NotFound();

            return View(videogame);

        }

        // Get : Videogame/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var videogame = _db.Videogames.SingleOrDefault(m => m.Id == id);

            if (videogame == null) return NotFound();

            return View(videogame);

        }

        //Post : Videogames/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Videogame videogame)
        {
            if (id != videogame.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _db.Update(videogame);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(videogame);
        }

        //Get: Videogames/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var videogame = _db.Videogames.SingleOrDefault(m=>m.Id == id);

            if (videogame == null) return NotFound();

            return View(videogame);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var videogame = _db.Videogames.SingleOrDefault(m => m.Id == id);
            if (videogame == null) return NotFound();
            _db.Remove(videogame);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }
    }
}