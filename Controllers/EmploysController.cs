using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmloyManagement.modal;
using EmployeeManagement.Modals;

namespace EmployeeManagement.Controllers
{
    [Route("api/Employs")]
    [ApiController]
    public class EmploysController : ControllerBase
    {
        private readonly Appdbcontext _context;

        public EmploysController(Appdbcontext context)
        {
            _context = context;
        }

        // GET: api/Employs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employ>>> GetEmploy()
        {
            return await _context.Employ.ToListAsync();
        }

        // GET: api/Employs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employ>> GetEmploy(int id)
        {
            var employ = await _context.Employ.FindAsync(id);

            if (employ == null)
            {
                return NotFound();
            }

            return employ;
        }

        // PUT: api/Employs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmploy(int id, Employ employ)
        {
            if (id != employ.EmployID)
            {
                return BadRequest();
            }

            _context.Entry(employ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployExists(id))
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

        // POST: api/Employs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employ>> PostEmploy(Employ employ)
        {
            _context.Employ.Add(employ);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmploy", new { id = employ.EmployID }, employ);
        }

        // DELETE: api/Employs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmploy(int id)
        {
            var employ = await _context.Employ.FindAsync(id);
            if (employ == null)
            {
                return NotFound();
            }

            _context.Employ.Remove(employ);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployExists(int id)
        {
            return _context.Employ.Any(e => e.EmployID == id);
        }
    }
}
