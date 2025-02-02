using FIT.Data.januar;
using FIT.Infrastructure.januar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.januar
{

    public partial class frmDrzave : Form
    {
        List<dtoDrzave> lista = new List<dtoDrzave>();

        public frmDrzave()
        {
            InitializeComponent();
            timer1.Start();
            dgvDrzave.AutoGenerateColumns = false;
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            lista.Clear();
            dgvDrzave.DataSource = null;
            List<Drzava> Drzava = KonekcijaDB.db.Drzava.ToList();
            int broj = 0;
            foreach (var d in Drzava)
            {
                if (KonekcijaDB.db.Gradovi.Where(x => x.DrzavaId == d.Id) is object)
                    broj = KonekcijaDB.db.Gradovi.Where(x => x.DrzavaId == d.Id).Count();
                var nova = new dtoDrzave()
                {
                    Drzava = d,
                    Broj = broj
                };
                lista.Add(nova);
            }
            dgvDrzave.DataSource = lista;
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            var nova = new frmNovaDrzava().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = " trenutno vrijeme je " + DateTime.Now.ToLongTimeString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var nova = new frmPocetna().ShowDialog();
        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrana = dgvDrzave.SelectedRows[0].DataBoundItem as dtoDrzave;
            if (e.ColumnIndex != 4)
            {
                var nova = new frmNovaDrzava(odabrana.Drzava).ShowDialog();
                ucitajDgv();
            }
            ucitajDgv();
        }

        private void dgvDrzave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrana = dgvDrzave.SelectedRows[0].DataBoundItem as dtoDrzave;
            if(e.ColumnIndex == 4) {
                var nova = new frmGradovi(odabrana.Drzava).ShowDialog();
                ucitajDgv();
            }
            ucitajDgv();
        }
    }
}
