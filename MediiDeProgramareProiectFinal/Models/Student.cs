using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediiDeProgramareProiectFinal.Models
{
    public class Student
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele studentului trebuie sa fie de forma ' Nume Prenume'"), Required, StringLength(50, MinimumLength = 6)]
        public String Nume { get; set; }
      
        [Range(1, 3)]
        public int An_studiu { get; set; }
    }
}
