using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Job_refugio_bd.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Job_refugio_bd.Controllers
{
    [Authorize]
    public class CurriculosController : Controller
    {
        private readonly AppDbContext _context;

        public CurriculosController(AppDbContext context)
        {
            _context = context;
        }

        private int GetUserId()
        {
            return int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }


        // GET: Curriculos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Curriculos.Include(c => c.Candidato);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Curriculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculos
                .Include(c => c.Candidato)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // GET: Curriculos/Create
        public IActionResult Create()
        {
            ViewData["CandidatoId"] = new SelectList(_context.Candidatos, "IdCandidato", "Email");
            return View();
        }

        // POST: Curriculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeUsuario,Cidade,FormAcad,ResumoQualific,PrincRealiza,ExpProf,ObjProf,CursosComplIdioma,CandidatoId")] Curriculo curriculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Candidatos", new { id = GetUserId() });
            }
            
           
            ViewData["CandidatoId"] = new SelectList(_context.Candidatos, "IdCandidato", "Email", curriculo.CandidatoId);
            return View(curriculo);
        }

        // GET: Curriculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculos.FindAsync(id);
            if (curriculo == null)
            {
                return NotFound();
            }
            ViewData["CandidatoId"] = new SelectList(_context.Candidatos, "IdCandidato", "Email", curriculo.CandidatoId);
            return View(curriculo);
        }

        // POST: Curriculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeUsuario,Cidade,FormAcad,ResumoQualific,PrincRealiza,ExpProf,ObjProf,CursosComplIdioma,CandidatoId")] Curriculo curriculo)
        {
            if (id != curriculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curriculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurriculoExists(curriculo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Candidatos", new { id = GetUserId() });
            }
            ViewData["CandidatoId"] = new SelectList(_context.Candidatos, "IdCandidato", "Email", curriculo.CandidatoId);
            return View(curriculo);
        }

        // GET: Curriculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculos
                .Include(c => c.Candidato)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // POST: Curriculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curriculo = await _context.Curriculos.FindAsync(id);
            if (curriculo != null)
            {
                _context.Curriculos.Remove(curriculo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculoExists(int id)
        {
            return _context.Curriculos.Any(e => e.Id == id);
        }
    }
}
