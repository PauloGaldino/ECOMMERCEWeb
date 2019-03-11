using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGREFRI.ApplicationCore.Entities;
using SGREFRI.Infrastructure.Data;

namespace ECOMMERCE.UI.Web.Controllers
{
    public class PessoasTiposController : Controller
    {
        private readonly GeneralContext _context;

        public PessoasTiposController(GeneralContext context)
        {
            _context = context;
        }

        // GET: PessoasTipos
        public async Task<IActionResult> Index()
        {
            return View(await _context.PessoaTipo.ToListAsync());
        }

        // GET: PessoasTipos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaTipo = await _context.PessoaTipo
                .FirstOrDefaultAsync(m => m.PessoaTipoId == id);
            if (pessoaTipo == null)
            {
                return NotFound();
            }

            return View(pessoaTipo);
        }

        // GET: PessoasTipos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PessoasTipos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PessoaTipoId,Descricao")] PessoaTipo pessoaTipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoaTipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoaTipo);
        }

        // GET: PessoasTipos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaTipo = await _context.PessoaTipo.FindAsync(id);
            if (pessoaTipo == null)
            {
                return NotFound();
            }
            return View(pessoaTipo);
        }

        // POST: PessoasTipos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PessoaTipoId,Descricao")] PessoaTipo pessoaTipo)
        {
            if (id != pessoaTipo.PessoaTipoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoaTipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaTipoExists(pessoaTipo.PessoaTipoId))
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
            return View(pessoaTipo);
        }

        // GET: PessoasTipos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaTipo = await _context.PessoaTipo
                .FirstOrDefaultAsync(m => m.PessoaTipoId == id);
            if (pessoaTipo == null)
            {
                return NotFound();
            }

            return View(pessoaTipo);
        }

        // POST: PessoasTipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pessoaTipo = await _context.PessoaTipo.FindAsync(id);
            _context.PessoaTipo.Remove(pessoaTipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaTipoExists(int id)
        {
            return _context.PessoaTipo.Any(e => e.PessoaTipoId == id);
        }
    }
}
