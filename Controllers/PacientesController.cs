using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho1DevWebNet.Data;
using Trabalho1DevWebNet.Models;

namespace Trabalho1DevWebNet.Controllers;

public class PacientesController : Controller
{
    private readonly AppDbContext _context;

    public PacientesController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Pacientes.OrderBy(p => p.Nome).ToListAsync());
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();

        var paciente = await _context.Pacientes.FirstOrDefaultAsync(p => p.Id == id);
        if (paciente == null) return NotFound();

        return View(paciente);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Paciente paciente)
    {
        if (!ModelState.IsValid) return View(paciente);

        _context.Add(paciente);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();

        var paciente = await _context.Pacientes.FindAsync(id);
        if (paciente == null) return NotFound();

        return View(paciente);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Paciente paciente)
    {
        if (id != paciente.Id) return NotFound();
        if (!ModelState.IsValid) return View(paciente);

        try
        {
            _context.Update(paciente);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await _context.Pacientes.AnyAsync(p => p.Id == paciente.Id)) return NotFound();
            throw;
        }

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();

        var paciente = await _context.Pacientes.FirstOrDefaultAsync(p => p.Id == id);
        if (paciente == null) return NotFound();

        return View(paciente);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var paciente = await _context.Pacientes.FindAsync(id);
        if (paciente != null)
        {
            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}
