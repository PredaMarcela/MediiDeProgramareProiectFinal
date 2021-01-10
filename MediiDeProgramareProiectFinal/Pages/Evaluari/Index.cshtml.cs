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
    public class IndexModel : PageModel
    {
        private readonly MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext _context;

        public IndexModel(MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext context)
        {
            _context = context;
        }

        public IList<Evaluare> Evaluare { get;set; }

        public async Task OnGetAsync()
        {
            Evaluare = await _context.Evaluare
                .Include(e => e.Curs)
                .Include(e => e.Specializare)
                .Include(e => e.Student).ToListAsync();
        }
    }
}
