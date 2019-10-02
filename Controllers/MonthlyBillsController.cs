using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonthlyBillsWebAPI.Models2;

namespace MonthlyBillsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthlyBillsController : ControllerBase
    {
        private readonly MonthlyBillsWebAppTR_dbContext _context;

        public MonthlyBillsController(MonthlyBillsWebAppTR_dbContext context)
        {
            _context = context;
        }

        // GET: api/MonthlyBills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonthlyBills>>> GetMonthlyBills()
        {
            return await _context.MonthlyBills
                .ToListAsync();
        }

        // GET: api/MonthlyBills/5
        [Route("api/[controller]/{Id}")]        
        [HttpGet("{Id}")]
        
        public async Task<ActionResult<MonthlyBills>> GetMonthlyBills(int Id)
        {
            var monthlyBills = await _context.MonthlyBills.FindAsync(Id);

            if (monthlyBills == null)
            {
                return NotFound();
            }

            return monthlyBills;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonthlyBills(int id, MonthlyBills monthlyBills)
        {
            if (id != monthlyBills.Id)
            {
                return BadRequest();
            }

            _context.Entry(monthlyBills).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonthlyBillsExists(id))
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
        public async Task<ActionResult<MonthlyBills>> PostMonthlyBills(MonthlyBills monthlyBills)
        {
            _context.MonthlyBills.Add(monthlyBills);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonthlyBills", new { id = monthlyBills.Id }, monthlyBills);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonthlyBills>> DeleteMonthlyBills(int id)
        {
            var monthlyBills = await _context.MonthlyBills.FindAsync(id);
            if (monthlyBills == null)
            {
                return NotFound();
            }

            _context.MonthlyBills.Remove(monthlyBills);
            await _context.SaveChangesAsync();

            return monthlyBills;
        }

        private bool MonthlyBillsExists(int id)
        {
            return _context.MonthlyBills.Any(e => e.Id == id);
        }
    }
}
