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
    public class EnderecoPessoaController : Controller
    {
        private readonly GeneralContext _context;

        public EnderecoPessoaController(GeneralContext context)
        {
            _context = context;
        }

        // GET: EnderecoPessoa
        public async Task<IActionResult> Index()
        {
            var generalContext = _context.EnderecosPessoas.Include(e => e.Endereco).Include(e => e.Pessoa);
            return View(await generalContext.ToListAsync());
        }

        // GET: EnderecoPessoa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoPessoa = await _context.EnderecosPessoas
                .Include(e => e.Endereco)
                .Include(e => e.Pessoa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enderecoPessoa == null)
            {
                return NotFound();
            }

            return View(enderecoPessoa);
        }

        // GET: EnderecoPessoa/Create
        public IActionResult Create()
        {
            ViewData["EnderecoId"] = new SelectList(_context.Enderecos, "EnderecoId", "Descricao");
            ViewData["PessoaId"] = new SelectList(_context.Pessoas, "PessoaId", "Nome");
            return View();
        }

        // POST: EnderecoPessoa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PessoaId,EnderecoId")] EnderecoPessoa enderecoPessoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enderecoPessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EnderecoId"] = new SelectList(_context.Enderecos, "EnderecoId", "Bairro", enderecoPessoa.EnderecoId);
            ViewData["PessoaId"] = new SelectList(_context.Pessoas, "PessoaId", "Nome", enderecoPessoa.PessoaId);
            return View(enderecoPessoa);
        }

        // GET: EnderecoPessoa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoPessoa = await _context.EnderecosPessoas.FindAsync(id);
            if (enderecoPessoa == null)
            {
                return NotFound();
            }
            ViewData["EnderecoId"] = new SelectList(_context.Enderecos, "EnderecoId", "Bairro", enderecoPessoa.EnderecoId);
            ViewData["PessoaId"] = new SelectList(_context.Pessoas, "PessoaId", "Nome", enderecoPessoa.PessoaId);
            return View(enderecoPessoa);
        }

        // POST: EnderecoPessoa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PessoaId,EnderecoId")] EnderecoPessoa enderecoPessoa)
        {
            if (id != enderecoPessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enderecoPessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnderecoPessoaExists(enderecoPessoa.Id))
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
            ViewData["EnderecoId"] = new SelectList(_context.Enderecos, "EnderecoId", "Bairro", enderecoPessoa.EnderecoId);
            ViewData["PessoaId"] = new SelectList(_context.Pessoas, "PessoaId", "Nome", enderecoPessoa.PessoaId);
            return View(enderecoPessoa);
        }

        // GET: EnderecoPessoa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecoPessoa = await _context.EnderecosPessoas
                .Include(e => e.Endereco)
                .Include(e => e.Pessoa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enderecoPessoa == null)
            {
                return NotFound();
            }

            return View(enderecoPessoa);
        }

        // POST: EnderecoPessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enderecoPessoa = await _context.EnderecosPessoas.FindAsync(id);
            _context.EnderecosPessoas.Remove(enderecoPessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnderecoPessoaExists(int id)
        {
            return _context.EnderecosPessoas.Any(e => e.Id == id);
        }
    }
}
