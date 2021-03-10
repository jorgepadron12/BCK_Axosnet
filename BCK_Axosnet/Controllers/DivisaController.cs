using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCK_Axosnet.Model;
using BCK_Axosnet.Data;
using Microsoft.Extensions.Logging;
using BCK_Axosnet.Data;

namespace BCK_Axosnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisaController   : ControllerBase
    {
       
        // GET: DivisaController
        private readonly DivisaData _divisaData;
        

        [HttpGet]
        // GET: DivisaController/Details/5
        public DivisaModel Details(int id)
        {
            DivisaData _divisaData = new DivisaData();

            DivisaModel _divisaModel = new DivisaModel();

            _divisaData.GetAll();

            _divisaModel.IdDivisa = 1;
            _divisaModel.Divisa = "U.S.D";
            _divisaModel.NombreCorto = "Nombe corto papá";


            return _divisaModel;
        }

    //    // GET: DivisaController/Create
    //    public async Task<ActionResult> Create()
    //    {
    //        return  View();
    //    }

    //    // POST: DivisaController/Create
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<ActionResult> Create(IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    // GET: DivisaController/Edit/5
    //    public async Task<ActionResult> Edit(int id)
    //    {
    //        return  View();
    //    }

    //    // POST: DivisaController/Edit/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    // GET: DivisaController/Delete/5
    //    public ActionResult Delete(int id)
    //    {
    //        return View();
    //    }

    //    // POST: DivisaController/Delete/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Delete(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }
    }
}
