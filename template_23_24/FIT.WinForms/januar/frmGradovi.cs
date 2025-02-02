using FIT.Data;
using FIT.Data.januar;
using FIT.Infrastructure.januar;
using FIT.Infrastructure.jul;
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
    public partial class frmGradovi : Form
    {
        public DrzaveJanuar Drzava1;

        public frmGradovi(DrzaveJanuar drzava)
        {
            InitializeComponent();
            dgvDodaj.AutoGenerateColumns = false;
            Drzava1 = drzava;
            ucitaj();
        }

        private void ucitaj()
        {
            pbzastavaGr.Image = Drzava1.Zastava.ToImage();
            label1.Text = Drzava1.Naziv;
            ucitajDgv();

        }

        private void ucitajDgv()
        {
            dgvDodaj.DataSource = null;
            List<GradoviJanuar> Gradovi = null;
            if (KonekcijaDBJanuar.db.Gradovi.Where(x => x.DrzavaId == Drzava1.Id) is object)
                Gradovi = KonekcijaDBJanuar.db.Gradovi.Where(x => x.DrzavaId == Drzava1.Id).ToList();
            dgvDodaj.DataSource = Gradovi;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validno() && DalIma())
            {
                var naziv = tbGrad.Text;
                var novi = new GradoviJanuar()
                {
                    Drzava = Drzava1,
                    Naziv = naziv,
                    Status = true
                };
                KonekcijaDBJanuar.db.Gradovi.Update(novi);
                KonekcijaDBJanuar.db.SaveChanges();
                ucitajDgv();
            }

        }

        private bool DalIma()
        {
            var naziv = tbGrad.Text;
            List<GradoviJanuar> gradovi = null;
            if (KonekcijaDBJanuar.db.Gradovi.Where(x => x.Drzava.Id == Drzava1.Id) is object)
                gradovi = KonekcijaDBJanuar.db.Gradovi.Where(x => x.Drzava.Id == Drzava1.Id).ToList();
            if (gradovi.Any(x => x.Naziv == naziv))
            {
                MessageBox.Show("Vec postoji taj grad u bazi");
                return false;
            }
            else return true;
        }

        private bool Validno()
        {
            return Helpers.Validator.ProvjeriUnos(tbGrad, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void dgvDodaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrani = dgvDodaj.SelectedRows[0].DataBoundItem as GradoviJanuar;
            if (e.ColumnIndex == 2)
            {
                if (odabrani.Status == true)
                    odabrani.Status = false;
                else
                    odabrani.Status = true;
                KonekcijaDBJanuar.db.Gradovi.Update(odabrani);
                KonekcijaDBJanuar.db.SaveChanges();
                ucitajDgv();
            }
        }

        private async  void btnGenerisi_Click(object sender, EventArgs e)
        {
            int broj;
            try
            {
                broj = int.Parse(tbBroj.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("morate unijeti broj");
                return;

            }
            var status=cbStatus.Checked;
            tbInfo.ScrollBars = ScrollBars.Vertical;
            await Task.Run(() =>
            {
                for (int i = 0; i < broj; i++)
                {
                    var novi = new GradoviJanuar()
                    {
                        Drzava = Drzava1,
                        Status = status,
                        Naziv = "Grad" + (i + 1)
                    };
                    KonekcijaDBJanuar.db.Gradovi.Add(novi);
                    tbInfo.Invoke(new Action(() =>
                    {
                        tbInfo.Text += DateTime.Now.ToString() + " dodat je grad Grad" + (i + 1).ToString() + " za drzavu " + Drzava1.Naziv + Environment.NewLine;
                    }));
                    Thread.Sleep(300);
                }
                KonekcijaDBJanuar.db.SaveChanges();
                BeginInvoke(ucitajDgv);
            });
        }
    }
}
