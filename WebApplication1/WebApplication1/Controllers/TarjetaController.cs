using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public TarjetaController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<TarjeaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try 
            {
                var listTarjetas = await _context.TarjetaCreditos.ToListAsync();
                return Ok(listTarjetas);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // GET api/<TarjeaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TarjeaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarjetaCredito tarjeta)
        {
            try
            {
                _context.Add(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(tarjeta);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT api/<TarjeaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TarjetaCredito tarjeta)
        {
            try
            {
                if (id != tarjeta.Id) { return NotFound(); }
                _context.Update(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(new {message = "Tarjeta actualizada!!!" });
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE api/<TarjeaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
               var tarjeta = await _context.TarjetaCreditos.FindAsync(id);
                if (tarjeta == null) { return NotFound(); }
                _context.TarjetaCreditos.Remove(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Tarjeta eliminada!!!" });
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
