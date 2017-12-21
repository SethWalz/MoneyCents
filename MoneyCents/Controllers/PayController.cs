using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoneyCents.Data;
using MoneyCents.Models;

namespace MoneyCents.Controllers
{
    public class PayController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PayController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pay
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pay.ToListAsync());
        }

        // GET: Pay/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pay = await _context.Pay
                .SingleOrDefaultAsync(m => m.ID == id);
            if (pay == null)
            {
                return NotFound();
            }

            return View(pay);
        }

        // GET: Pay/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pay/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,LastUpdatedDate,Year,GrossMonthlyIncome,GrossYearlyIncome,TaxableMonthlyGross,NetMonthly,NetYearly,Name")] Pay pay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pay);
        }

        // GET: Pay/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pay = await _context.Pay.SingleOrDefaultAsync(m => m.ID == id);
            if (pay == null)
            {
                return NotFound();
            }
            return View(pay);
        }

        // POST: Pay/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,LastUpdatedDate,Year,GrossMonthlyIncome,GrossYearlyIncome,TaxableMonthlyGross,NetMonthly,NetYearly,Name")] Pay pay)
        {
            if (id != pay.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PayExists(pay.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pay);
        }

        // GET: Pay/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pay = await _context.Pay
                .SingleOrDefaultAsync(m => m.ID == id);
            if (pay == null)
            {
                return NotFound();
            }

            return View(pay);
        }

        // POST: Pay/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pay = await _context.Pay.SingleOrDefaultAsync(m => m.ID == id);
            _context.Pay.Remove(pay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PayExists(int id)
        {
            return _context.Pay.Any(e => e.ID == id);
        }
    }
}
