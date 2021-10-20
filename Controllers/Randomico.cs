using Baraja2_juangonzales.Data;
using Baraja2_juangonzales.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baraja2_juangonzales.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RandomController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Naipe>> GetNaipe()
        {

            var list = await _context.Naipe.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var Naipe = list[index];

            if (Naipe == null)
            {
                return NoContent();
            }

            return Naipe;
        }
    }
}
