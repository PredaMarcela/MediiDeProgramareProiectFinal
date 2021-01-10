using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramareProiectFinal.Data;
using MediiDeProgramareProiectFinal.Models;

namespace MediiDeProgramareProiectFinal.Pages.Evaluari
{
    public class DetailsModel : PageModel
    {
        private readonly MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext _context;

        public DetailsModel(MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
