// LightBulbController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class LightBulbController : ControllerBase
{
    private readonly AppDbContext _context;

    public LightBulbController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LightBulb>>> GetLightBulbs()
    {
        return await _context.LightBulbs.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<LightBulb>> AddLightBulb(LightBulb lightBulb)
    {
        _context.LightBulbs.Add(lightBulb);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetLightBulbs), new { id = lightBulb.Id }, lightBulb);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLightBulb(int id, LightBulb lightBulb)
    {
        if (id != lightBulb.Id)
        {
            return BadRequest();
        }

        _context.Entry(lightBulb).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLightBulb(int id)
    {
        var lightBulb = await _context.LightBulbs.FindAsync(id);

        if (lightBulb == null)
        {
            return NotFound();
        }

        _context.LightBulbs.Remove(lightBulb);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
