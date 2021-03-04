using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCK_Axosnet.Controllers
{
    public class DivisaController : Controller
    {
        // GET: DivisaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DivisaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DivisaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DivisaController/Create
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

        // GET: DivisaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DivisaController/Edit/5
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

        // GET: DivisaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DivisaController/Delete/5
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
