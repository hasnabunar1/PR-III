using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.januar
{
    public  class dtoDrzaveJanuar
    {
        public DrzaveJanuar Drzava;
        public byte[] Zastava => Drzava.Zastava;
        public string  Naziv =>Drzava.Naziv;
        public int Broj { get; set; }
        public bool Status=>Drzava.Status;

    }
}
