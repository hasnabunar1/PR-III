using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.januar
{
    [Table("Gradovi")]
    public class Gradovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public Drzava Drzava { get; set; }
        public int DrzavaId { get; set; }
    }
}
