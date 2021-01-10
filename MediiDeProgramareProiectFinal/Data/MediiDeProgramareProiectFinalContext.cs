using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramareProiectFinal.Models;

namespace MediiDeProgramareProiectFinal.Data
{
    public class MediiDeProgramareProiectFinalContext : DbContext
    {
        public MediiDeProgramareProiectFinalContext (DbContextOptions<MediiDeProgramareProiectFinalContext> options)
            : base(options)
        {
        }

        public DbSet<MediiDeProgramareProiectFinal.Models.Curs> Curs { get; set; }

        public DbSet<MediiDeProgramareProiectFinal.Models.Student> Student { get; set; }

        public DbSet<MediiDeProgramareProiectFinal.Models.Specializare> Specializare { get; set; }

        public DbSet<MediiDeProgramareProiectFinal.Models.Evaluare> Evaluare { get; set; }
    }
}
