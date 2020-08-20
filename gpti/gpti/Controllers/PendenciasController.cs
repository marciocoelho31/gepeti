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
    public class PendenciasController : Controller
    {
        private readonly AppDbContext _context;

        public PendenciasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Pendencias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pendencias.ToListAsync());
        }

        // GET: Pendencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pendencias = await _context.Pendencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pendencias == null)
            {
                return NotFound();
            }

            return View(pendencias);
        }

        // GET: Pendencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pendencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Prior,Tipo,Cliente,Descricao,DataSolic,Posicao,DataPos,HoraPos,QuemSolic,FormaSolic,ComentInt,Sistema,Usuario,Previsao,Minutos,QtdDias,DtLanc,Prog,NovoItem,Urgente,NaWeb,Projeto,DescricaoOrig")] Pendencias pendencias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pendencias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pendencias);
        }

        // GET: Pendencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pendencias = await _context.Pendencias.FindAsync(id);
            if (pendencias == null)
            {
                return NotFound();
            }
            return View(pendencias);
        }

        // POST: Pendencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Prior,Tipo,Cliente,Descricao,DataSolic,Posicao,DataPos,HoraPos,QuemSolic,FormaSolic,ComentInt,Sistema,Usuario,Previsao,Minutos,QtdDias,DtLanc,Prog,NovoItem,Urgente,NaWeb,Projeto,DescricaoOrig")] Pendencias pendencias)
        {
            if (id != pendencias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pendencias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PendenciasExists(pendencias.Id))
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
            return View(pendencias);
        }

        // GET: Pendencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pendencias = await _context.Pendencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pendencias == null)
            {
                return NotFound();
            }

            return View(pendencias);
        }

        // POST: Pendencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pendencias = await _context.Pendencias.FindAsync(id);
            _context.Pendencias.Remove(pendencias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PendenciasExists(int id)
        {
            return _context.Pendencias.Any(e => e.Id == id);
        }
    }
}
