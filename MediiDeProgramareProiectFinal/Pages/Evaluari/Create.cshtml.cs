using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MediiDeProgramareProiectFinal.Data;
using MediiDeProgramareProiectFinal.Models;

namespace MediiDeProgramareProiectFinal.Pages.Evaluari
{
    public class CreateModel : PageModel
    {
        private readonly MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext _context;

        public CreateModel(MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CursID"] = new SelectList(_context.Curs, "ID", "Denumire");
        ViewData["SpecializareID"] = new SelectList(_context.Specializare, "ID", "Denumire");
        ViewData["StudentID"] = new SelectList(_context.Student, "ID", "Nume");
            return Page();
        }

        [BindProperty]
        public Evaluare Evaluare { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Evaluare.Add(Evaluare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
