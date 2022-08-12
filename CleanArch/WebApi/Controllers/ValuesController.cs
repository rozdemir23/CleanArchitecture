using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Data;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Urun>>> GetUrun()
        {
            return await _context.Urun.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Urun>> GetUrun(int id)
        {
            var urun = await _context.Urun.FindAsync(id);

            if (urun == null)
            {
                return NotFound();
            }

            return urun;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutUrun(int id, Urun urun)
        {
            if (id != urun.ID)
            {
                return BadRequest();
            }

            _context.Entry(urun).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UrunExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

     
        [HttpPost]
        public async Task<ActionResult<Urun>> PostUrun(Urun urun)
        {
            _context.Urun.Add(urun);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUrun", new { id = urun.ID }, urun);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUrun(int id)
        {
            var urun = await _context.Urun.FindAsync(id);
            if (urun == null)
            {
                return NotFound();
            }

            _context.Urun.Remove(urun);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UrunExists(int id)
        {
            return _context.Urun.Any(e => e.ID == id);
        }
    }
}
