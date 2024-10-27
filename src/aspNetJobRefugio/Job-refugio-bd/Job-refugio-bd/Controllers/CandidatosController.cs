using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Job_refugio_bd.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Job_refugio_bd.Controllers
{
    public class CandidatosController : Controller
    {
        private readonly AppDbContext _context;

        public CandidatosController(AppDbContext context)
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
                var claims = new List<Claim>
                {
                    new Claim (ClaimTypes.Name, usu.NomeUsuario ),
                    new Claim (ClaimTypes.NameIdentifier, usu.IdCandidato.ToString() ),
                    new Claim (ClaimTypes.Email, usu.Email),
                    new Claim("OtherProperties", "Example Role"),
                };

                var usuarioIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Email ou senha inválidos.");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Candidatos");
        }

        //----------------------------------------------------------------------------------

        // GET: Candidatos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Candidatos.ToListAsync());
        }

        // GET: Candidatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidato = await _context.Candidatos
                .FirstOrDefaultAsync(m => m.IdCandidato == id);
            if (candidato == null)
            {
                return NotFound();
            }

            return View(candidato);
        }

        // GET: Candidatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCandidato,NomeUsuario,DataNascimento,Nacionalidade,Endereco,CPF,Celular,Email,Senha,ConfirmPassword")] Candidato candidato)
        {
            if (ModelState.IsValid)
            {
                //candidato.Senha = BCrypt.Net.BCrypt.HashPassword(candidato.Senha);//Comando para criptografar senha
                _context.Add(candidato);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Candidatos");//Retorna para pagina de login
                
            }
            return View(candidato);
        }

        // GET: Candidatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidato = await _context.Candidatos.FindAsync(id);
            if (candidato == null)
            {
                return NotFound();
            }
            return View(candidato);
        }

        // POST: Candidatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCandidato,NomeUsuario,DataNascimento,Nacionalidade,Endereco,CPF,Celular,Email,Senha,ConfirmPassword")] Candidato candidato)
        {
            if (id != candidato.IdCandidato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //candidato.Senha = BCrypt.Net.BCrypt.HashPassword(candidato.Senha);//Comando para criptografar senha
                    _context.Update(candidato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidatoExists(candidato.IdCandidato))
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
            return View(candidato);
        }

        // GET: Candidatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidato = await _context.Candidatos
                .FirstOrDefaultAsync(m => m.IdCandidato == id);
            if (candidato == null)
            {
                return NotFound();
            }

            return View(candidato);
        }

        // POST: Candidatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidato = await _context.Candidatos.FindAsync(id);
            if (candidato != null)
            {
                _context.Candidatos.Remove(candidato);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidatoExists(int id)
        {
            return _context.Candidatos.Any(e => e.IdCandidato == id);
        }
    }
}
