using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediiDeProgramareProiectFinal.Models
{
    public class Evaluare
    {
        public int ID { get; set; }
        public int CursID { get; set; }
        public Curs Curs { get; set; }


        [Display(Name = "Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }


        [Range(1, 10)]
        public int Nota { get; set; }

        public int SpecializareID { get; set; }
        public Specializare Specializare { get; set; }
    }
}
