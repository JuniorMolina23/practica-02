using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturaController : ControllerBase
    {
        private readonly Conexiones _context;

        public TemperaturaController(Conexiones context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Temperatura>>> GetTemperatura()
        {
            var temperaturas = await _context.Temperatura.ToListAsync();

            if (temperaturas == null || !temperaturas.Any())
            {
                return NotFound("No hay datos de temperaturas disponibles.");
            }
            
            return Ok(temperaturas);
        }
    }
}
