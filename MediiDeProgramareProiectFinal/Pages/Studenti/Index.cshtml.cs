﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramareProiectFinal.Data;
using MediiDeProgramareProiectFinal.Models;

namespace MediiDeProgramareProiectFinal.Pages.Studenti
{
    public class IndexModel : PageModel
    {
        private readonly MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext _context;

        public IndexModel(MediiDeProgramareProiectFinal.Data.MediiDeProgramareProiectFinalContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
