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
    public partial class frmPretraga : Form
    {
        List<dtoStudent> Studneti= new List<dtoStudent> ();

        public frmPretraga()
        {
            InitializeComponent();
            ucitajDrzave();
            ucitajGradove();
            ucitajDgv();
        }

        private void ucitajGradove()
        {

            cbGrad.UcitajPodatke(KonekcijaDB.db.Gradovi.Where(x => x.DrzavaId == (cbDrzava.SelectedItem as Drzava).Id).ToList());
        }

        private void ucitajDrzave()
        {
            cbDrzava.UcitajPodatke(KonekcijaDB.db.Drzava.ToList());
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

        private void ucitajDgv()
        {
            dgvPretrag.DataSource = null;
            List<Student> stud= null;
            if (KonekcijaDB.db.Studenti.Where(x => x.GradId == (cbGrad.SelectedItem as Gradovi).Id ) is object ) 
                stud= KonekcijaDB.db.Studenti.Where(x => x.GradId == (cbGrad.SelectedItem as Gradovi).Id).ToList();
            foreach (var s in stud)
            {
                string prosjek = "5.00";
                var novi = new dtoStudent()
                {
                    Prosjek = prosjek,
                    Student = s

                };
                 Studneti.Add(novi);

            }
            dgvPretrag.DataSource = Studneti;
        }
    }
}
