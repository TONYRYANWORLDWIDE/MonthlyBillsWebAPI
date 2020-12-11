using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonthlyBillsWebAPI.Models;

namespace MonthlyBillsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ModelVerify]
    public class TransactionsCMPController : ControllerBase
    {
        private readonly MonthlyBillsWebAppTR_dbContext _context;

        public TransactionsCMPController(MonthlyBillsWebAppTR_dbContext context)
        {
            _context = context;
        }

        // GET: api/Transactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionsCMP>>> GetTransactions()
        {
            return await _context.TransactionsCMP.ToListAsync();
        }

        // GET: api/Transactions/5
        [HttpGet("{transactionid}/{accountid}")]
        public async Task<ActionResult<TransactionsCMP>> GetTransactions(string transactionid,string accountid)
        {
            var transactions = await _context.TransactionsCMP.FindAsync(transactionid,accountid);

            if (transactions == null)
            {
                return NotFound();
            }

            return transactions;
        }

        // PUT: api/Transactions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{transactionid}/{accountid}")]
        public async Task<IActionResult> PutTransactions( string transactionid, string accountid, TransactionsCMP transactions)
        {
            if (transactionid != transactions.Transaction_Id)
            {
                return BadRequest();
            }
            if (accountid != transactions.Account_Id)
            {
                return BadRequest();
            }

            _context.Entry(transactions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionsExists(transactionid))
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

        // POST: api/Transactions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TransactionsCMP>> PostTransactions(TransactionsCMP transactions)
        {
            _context.TransactionsCMP.Add(transactions);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TransactionsExists(transactions.Transaction_Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTransactions", new { id = transactions.Transaction_Id }, transactions);
        }

        // DELETE: api/Transactions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TransactionsCMP>> DeleteTransactions(string id)
        {
            var transactions = await _context.TransactionsCMP.FindAsync(id);
            if (transactions == null)
            {
                return NotFound();
            }

            _context.TransactionsCMP.Remove(transactions);
            await _context.SaveChangesAsync();

            return transactions;
        }

        private bool TransactionsExists(string id)
        {
            return _context.TransactionsCMP.Any(e => e.Transaction_Id == id);
        }
    }
}
