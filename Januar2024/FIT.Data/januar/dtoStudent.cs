using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.januar
{
    public class dtoStudent
    {
        public Student Student { get; set; }
        public string Ime => Student.Ime;
        public string Prezime=>Student.Prezime;
        public string Grad => Student.Grad.Naziv;
        public string Drzava => Student.Grad.Drzava.Naziv;
        public string Prosjek { get; set; }
    }
}
