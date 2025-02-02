using FIT.Data.januar;
using FIT.Infrastructure.januar;
using FIT.Infrastructure.jul;
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
    public partial class frmDrzave : Form
    {
        List<dtoDrzaveJanuar> Lista = new List<dtoDrzaveJanuar>();
        public frmDrzave()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
            ucitajDgv();
            timer1.Start();
        }

        private void ucitajDgv()
        {
            dgvDrzave.DataSource = null;
            List<DrzaveJanuar> drzave = KonekcijaDBJanuar.db.Drzave.ToList();
            Lista.Clear();
            int broj = 0;
            foreach (var d in drzave)
            {
                if (KonekcijaDBJanuar.db.Gradovi.Where(x => x.DrzavaId == d.Id) is object)
                    broj = KonekcijaDBJanuar.db.Gradovi.Where(x => x.DrzavaId == d.Id).Count();
                var nova = new dtoDrzaveJanuar()
                {
                    Drzava = d,
                    Broj = broj
                };
                Lista.Add(nova);
            }
            dgvDrzave.DataSource = Lista;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = "Trenutno vrijeme je " + DateTime.Now.ToLongTimeString();
        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrana = dgvDrzave.SelectedRows[0].DataBoundItem as dtoDrzaveJanuar;
            if (e.ColumnIndex != 4)
            {
                var nova = new frmNovaDrzavaJanuar(odabrana.Drzava);
                nova.ShowDialog();
                ucitajDgv();
            }
            ucitajDgv();

        }

        private void dgvDrzave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrana = dgvDrzave.SelectedRows[0].DataBoundItem as dtoDrzaveJanuar;
            if (e.ColumnIndex == 4)
            {
                var nova = new frmGradovi(odabrana.Drzava);
                nova.ShowDialog();
                ucitajDgv();
            }
            ucitajDgv();
        }
        private void btnNova_Click(object sender, EventArgs e)
        {
            var nova = new frmNovaDrzavaJanuar();
            nova.ShowDialog();
        }
        private void dgvDrzave_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
