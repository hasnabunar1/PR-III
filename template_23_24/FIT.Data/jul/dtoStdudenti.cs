using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.jul
{
    public class dtoStdudenti
    {
        public Student Student { get; set; }
        public string Indeks => Student.Indeks;
        public string ImePrezime=>Student.Ime+" "+Student.Prezime;
        public DateTime DatumRodjenja=>Student.DatumRodjenja;
        public bool Aktivan=>Student.Aktivan;
        public string Spol=>Student.Spol;
        public string Prosjek { get; set; }


       
    }
}
