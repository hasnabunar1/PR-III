using FIT.Data;
using FIT.Data.januar;
using FIT.Infrastructure.januar;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.januar
{
    public partial class frmNovaDrzava : Form
    {
        public Drzava Drzava = null;
        public frmNovaDrzava()
        {
            InitializeComponent();

        }

        public frmNovaDrzava(Drzava drzava)
        {
            InitializeComponent();
            Drzava = drzava;
            ucitaj();
        }

        private void ucitaj()
        {
            pbZastava.Image = Drzava.Zastava.ToImage();
            tbNaziv.Text = Drzava.Naziv;
            cbStatus.Checked = Drzava.Status;

        }

        private void pbZastava_Click(object sender, EventArgs e)
        {
            var slika = new OpenFileDialog();
            if (slika.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(slika.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                if (Drzava==null)
                {
                    var slika = pbZastava.Image.ToByteArray();
                    var naziv = tbNaziv.Text;
                    var status= cbStatus.Checked;
                    var nova = new Drzava()
                    {
                        Zastava = slika,
                        Naziv = naziv,
                        Status = status
                    };
                    KonekcijaDB.db.Drzava.Add(nova);
                    KonekcijaDB.db.SaveChanges();
                    Close();
                }
                else
                {
                    Drzava.Zastava = pbZastava.Image.ToByteArray();
                    Drzava.Naziv= tbNaziv.Text;
                    Drzava.Status = cbStatus.Checked;
                    KonekcijaDB.db.Drzava.Update(Drzava);
                    KonekcijaDB.db.SaveChanges();
                    Close();

                }
            }
        }

        private bool validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, errorProvider1, Kljucevi.ReqiredValue) && Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
