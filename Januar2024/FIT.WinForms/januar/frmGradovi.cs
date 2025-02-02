using FIT.Data;
using FIT.Data.januar;
using FIT.Infrastructure.januar;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
        public Drzava Drzava = new Drzava();


        public frmGradovi(Drzava drzava)
        {
            InitializeComponent();
            dgvGradovi.AutoGenerateColumns = false;
            Drzava = drzava;
            ucitaj();

        }

        private void ucitaj()
        {
            pbZastava.Image = Drzava.Zastava.ToImage();
            label1.Text = Drzava.Naziv;
            dgvGradovi.DataSource = null;
            List<Gradovi> gradovi = null;
            if (KonekcijaDB.db.Gradovi.Where(x => x.DrzavaId == Drzava.Id) is object)
                gradovi = KonekcijaDB.db.Gradovi.Where(x => x.DrzavaId == Drzava.Id).ToList();
            dgvGradovi.DataSource = gradovi;
        }

        private void dgvGradovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabra = dgvGradovi.SelectedRows[0].DataBoundItem as Gradovi;
            if (e.ColumnIndex == 2)
            {
                if (odabra.Status == true)
                    odabra.Status = false;
                else odabra.Status = true;
                KonekcijaDB.db.Gradovi.Update(odabra);
                KonekcijaDB.db.SaveChanges();
                ucitaj();
            }
        }

        private void frmGradovi_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (valdirA() && dalima())
            {
                var naziv = tbNaziv.Text;
                var novi = new Gradovi()
                {
                    Drzava = Drzava,
                    Naziv = naziv,
                    Status = true
                };
                KonekcijaDB.db.Gradovi.Add(novi);
                KonekcijaDB.db.SaveChanges();
                ucitaj();
            }
        }

        private bool dalima()
        {
            var naziv = tbNaziv.Text;
            if (KonekcijaDB.db.Gradovi.Where(x => x.DrzavaId == Drzava.Id).Any(x => x.Naziv == naziv))
            {
                MessageBox.Show("vec postoji ovaj grad");
                return false;

            }
            return true;
        }

        private bool valdirA()
        {
            return Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int broj;
            try
            {
                broj = int.Parse(tbBroj.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate uniejti broj");
                return;
            }
            var status = cbStatus.Checked;
            tbInfo.ScrollBars = ScrollBars.Vertical;
            await Task.Run(() =>
            {
                for (int i = 0; i < broj; i++)
                {

                    var novi = new Gradovi()
                    {
                        Drzava = Drzava,
                        Status = status,
                        Naziv = "Grad" + (i + 1)
                    };
                    KonekcijaDB.db.Gradovi.Add(novi);
                    tbInfo.Invoke(new Action(() =>
                    {
                        tbInfo.Text += DateTime.Now.ToString() + "  fofat grad Grad" + (i + 1) + " za drzavu " + Drzava.Naziv + Environment.NewLine;
                    }));
                    Thread.Sleep(300);
                }
                KonekcijaDB.db.SaveChanges();
                BeginInvoke(ucitaj);
            });
        }
    }
}
