using FIT.Data;
using FIT.Data.januar;
using FIT.Infrastructure.januar;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.januar
{

    public partial class frmPretragaJanuar : Form
    {
        List<dtoStudenti> Studenti = new List<dtoStudenti>();
        public frmPretragaJanuar()
        {
            InitializeComponent();
            ucitajDrzave();
            ucitajGradove();
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            dgvStudenti.DataSource = null;
            GradoviJanuar grad = null;
            List<Student> stud = null;
            if (cbGrad.SelectedItem as GradoviJanuar is object)
            {
                grad = cbGrad.SelectedItem as GradoviJanuar;
                if (KonekcijaDBJanuar.db.Studenti.Where(x => x.GradId == grad.Id) is object)
                    stud = KonekcijaDBJanuar.db.Studenti.Where(x => x.GradId == grad.Id).ToList();
                Studenti.Clear();
                //foreach (var s in stud)
                //{
                //    string prosjek = "5.00";
                //    var polzeni=KonekcijaDBJanuar.db.

                //}
                foreach (var s in stud)
                {
                    string prosjek = "5.00";
                    var novi = new dtoStudenti()
                    {
                        Student = s,
                        Prosjek = prosjek
                    };
                    Studenti.Add(novi);
                }
                dgvStudenti.DataSource = Studenti;
            }
        }

        private void ucitajGradove()
        {
            var drzava = cbDrzava.SelectedItem as DrzaveJanuar;
            cbGrad.DataSource = null;
            if (KonekcijaDBJanuar.db.Gradovi.Where(x => x.DrzavaId == drzava.Id) is object) // moze is bez ovoga al  ovo je  provjera da li ima ist aodnosno da where upit nije nula 
                cbGrad.UcitajPodatke(KonekcijaDBJanuar.db.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList());
        }

        private void ucitajDrzave()
        {
            cbDrzava.UcitajPodatke(KonekcijaDBJanuar.db.Drzave.ToList());
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajGradove();
            ucitajDgv();
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajDgv();
        }
    }
}
