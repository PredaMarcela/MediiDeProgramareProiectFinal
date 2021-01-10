using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramareProiectFinal.Data;
using MediiDeProgramareProiectFinal.Models;

namespace MediiDeProgramareProiectFinal.Pages.Evaluari
{
    public class EditModel : PageModel
    {
        private readonly MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext _context;

        public EditModel(MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Evaluare Evaluare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Evaluare = await _context.Evaluare
                .Include(e => e.Curs)
                .Include(e => e.Specializare)
                .Include(e => e.Student).FirstOrDefaultAsync(m => m.ID == id);

            if (Evaluare == null)
            {
                return NotFound();
            }
           ViewData["CursID"] = new SelectList(_context.Curs, "ID", "Denumire");
           ViewData["SpecializareID"] = new SelectList(_context.Specializare, "ID", "Denumire");
           ViewData["StudentID"] = new SelectList(_context.Student, "ID", "Nume");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Evaluare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvaluareExists(Evaluare.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EvaluareExists(int id)
        {
            return _context.Evaluare.Any(e => e.ID == id);
        }
    }
}
