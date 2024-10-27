using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Job_refugio_bd.Models;

namespace Job_refugio_bd.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        //---------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string senha)
        {
            var usu = await _context.Candidatos
                .FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);

            if (usu != null)
            {
                ModelState.AddModelError("", "Passei aqui");
                // Aqui você pode configurar o cookie de autenticação ou JWT
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Email ou senha inválidos.");
            return View();
        }

        //----------------------------------------------------------------------------------

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Usuarios.Include(u => u.Candidato).Include(u => u.Empregador);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.Candidato)
                .Include(u => u.Empregador)
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["IdCandidato"] = new SelectList(_context.Candidatos, "IdCandidato", "Email");
            ViewData["IdEmpregador"] = new SelectList(_context.Empregadores, "Id", "Cnpj");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,Email,Senha,IdCandidato,IdEmpregador")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCandidato"] = new SelectList(_context.Candidatos, "IdCandidato", "Email", usuario.IdCandidato);
            ViewData["IdEmpregador"] = new SelectList(_context.Empregadores, "Id", "Cnpj", usuario.IdEmpregador);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["IdCandidato"] = new SelectList(_context.Candidatos, "IdCandidato", "Email", usuario.IdCandidato);
            ViewData["IdEmpregador"] = new SelectList(_context.Empregadores, "Id", "Cnpj", usuario.IdEmpregador);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,Email,Senha,IdCandidato,IdEmpregador")] Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.IdUsuario))
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
            ViewData["IdCandidato"] = new SelectList(_context.Candidatos, "IdCandidato", "Email", usuario.IdCandidato);
            ViewData["IdEmpregador"] = new SelectList(_context.Empregadores, "Id", "Cnpj", usuario.IdEmpregador);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.Candidato)
                .Include(u => u.Empregador)
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.IdUsuario == id);
        }
    }
}
