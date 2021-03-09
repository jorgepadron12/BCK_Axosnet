using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCK_Axosnet.Model;
using BCK_Axosnet.Data;

namespace BCK_Axosnet.Controllers
{
    public class DivisaController   : Controller  
    {
        // GET: DivisaController
        private readonly DivisaData _divisaData;


        [HttpGet]
        // GET: DivisaController/Details/5
        public Task<String> Details(int id)
        {
            return _divisaData.GetAll();
        }

        // GET: DivisaController/Create
        public async Task<ActionResult> Create()
        {
            return  View();
        }

        // POST: DivisaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
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
        public async Task<ActionResult> Edit(int id)
        {
            return  View();
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
