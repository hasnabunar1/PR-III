using FIT.Data;
using FIT.Data.jul;
using FIT.Infrastructure;
using FIT.Infrastructure.jul;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.jul
{
    public partial class frmPretraga : Form
    {
        DLWMSDbContext db = KonekcijaBaze.db;
        List<dtoStdudenti> studenti = new List<dtoStdudenti>();



        public frmPretraga()
        {
            using (var sve = new DLWMSDbContext())
            {
                studenti = sve.Studenti.Select(s => new dtoStdudenti
                {
                    Student = s
                }).ToList();

            }
            InitializeComponent();
            UcitajSpolove();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void ucitajDgv()
        {
            
          
            
            //string odabranispol = cmbspol.selectedindex == -1 ? "musko" : "zensko";
         

            var dtpOd = dtOd.Value;
            var dtpDo = dtDo.Value;
            var lista = db.Studenti.Where(x => x.DatumRodjenja >= dtpOd && x.DatumRodjenja <= dtpDo).ToList();
            dgvPretraga.DataSource= studenti;

            if (lista.Count == 0)
            {
                MessageBox.Show($"U bazi nema studenata koji su sljedeceg spola:" + $"{cmbSpol.SelectedIndex } i da su rođeni u periodu od {dtpOd.ToShortDateString()} " + $"do {dtpDo.ToShortDateString()}");
            }
            else
            {

                studenti.Clear();
                foreach (var st in lista)
                {
                    studenti.Add(new dtoStdudenti() { Student = st });
                    dgvPretraga.DataSource = studenti;
                }

            }

        }
        private void UcitajSpolove()
        {
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Naziv";
            var spolovi = studenti.Select(s => s.Spol).ToList();
            cmbSpol.DataSource = spolovi;
            cmbSpol.SelectedIndex = -1;
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void cmbSpol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajSpolove();
            string odabraniSpol = cmbSpol.SelectedIndex == 0 ? "Muski" : "Zenski";
            using (var sve = new DLWMSDbContext())
            {
                var filtriraniStudenti = sve.Studenti.Where(s => s.Spol == odabraniSpol).Select(s => new dtoStdudenti
                {
                    Student = s
                }).ToList();
                dgvPretraga.DataSource= filtriraniStudenti;
                ucitajDgv();
            }
        }
    }
}



