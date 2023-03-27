using DLWMS.Data;
using DLWMS.Data.IspitIB200199;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB200199
{
    public partial class frmNovaPorukaIB200199 : Form
    {
         Student _student;
        DLWMSDbContext baza = KonekcijaNaBazu.Baza;
        public frmNovaPorukaIB200199(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            var odabranaSlika = new OpenFileDialog();
            if(odabranaSlika.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(odabranaSlika.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(Validator.ValidirajKontrolu(cmbPredmet,errProv,Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSadrzaj, errProv, Kljucevi.ObaveznaVrijednost))
            {
                StudentPoruka dodajNovu = new StudentPoruka()
                {
                    Student=_student,
                    Predmet=cmbPredmet.SelectedItem as Predmet,
                    Datum=DateTime.Now,
                    Sadrzaj=txtSadrzaj.Text,
                    Slika=(pbSlika.Image!=null?ImageHelper.FromImageToByte(pbSlika.Image):null),
                };
                baza.StudentiPoruke.Add(dodajNovu);
                baza.SaveChanges();
                MessageBox.Show("Uspjesno spaseni podaci !", "Obavjestenje");
                cmbPredmet.SelectedItem = null;
                txtSadrzaj.Clear();
                pbSlika.Image = null;
            }
        }

        private void frmNovaPorukaIB200199_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = baza.Predmeti.ToList();
            cmbPredmet.SelectedItem = null;
        }
    }
}
