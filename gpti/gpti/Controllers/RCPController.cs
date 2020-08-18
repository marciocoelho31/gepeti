using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gpti.Context;
using gpti.Models;

namespace gpti.Controllers
{
    public class RCPController : Controller
    {
        private readonly AppDbContext _context;

        public RCPController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RCPs
        public async Task<IActionResult> Index()
        {
            return View(await _context.RCP.ToListAsync());
        }

        // GET: RCPs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rCP = await _context.RCP
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rCP == null)
            {
                return NotFound();
            }

            return View(rCP);
        }

        // GET: RCPs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RCPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Hora,ContInt,ContExt,Local,TelCont,Posicao,Tipo,Ct,Email,Origem")] RCP rCP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rCP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rCP);
        }

        // GET: RCPs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rCP = await _context.RCP.FindAsync(id);
            if (rCP == null)
            {
                return NotFound();
            }
            return View(rCP);
        }

        // POST: RCPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Hora,ContInt,ContExt,Local,TelCont,Posicao,Tipo,Ct,Email,Origem")] RCP rCP)
        {
            if (id != rCP.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rCP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RCPExists(rCP.Id))
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
            return View(rCP);
        }

        // GET: RCPs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rCP = await _context.RCP
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rCP == null)
            {
                return NotFound();
            }

            return View(rCP);
        }

        // POST: RCPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rCP = await _context.RCP.FindAsync(id);
            _context.RCP.Remove(rCP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RCPExists(double id)
        {
            return _context.RCP.Any(e => e.Id == id);
        }
    }
}
