using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCK_Axosnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AplicacionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Congelado", "CAliente", "Chido", "FrioAlv", "MasOmenos", "CAliento", "Bambi", "Infierno", "Viento", "No se"
        };

        private readonly ILogger<AplicacionController> _logger;

        public AplicacionController(ILogger<AplicacionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Recibo> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Recibo
            {
                FechaCreacion = DateTime.Now.AddDays(index),
                //IdProvvedor = rng.Next(-20, 55),
               // Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
