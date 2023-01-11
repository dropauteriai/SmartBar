using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartBar.Controllers.DTO;

namespace SmartBar.Controllers
{
    public class TableController : Controller
    {
        public List<TableDTO> GetAll()
        {
            var tables = Enumerable.Range(1, 5).Select(index => new TableDTO(index, $"Stalas {index}", index)).ToList();
            tables.Add(new TableDTO(100, "Baras", 100));
            return tables;
        }
        // GET: TableController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TableController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TableController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TableController/Create
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

        // GET: TableController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TableController/Edit/5
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

        // GET: TableController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TableController/Delete/5
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
