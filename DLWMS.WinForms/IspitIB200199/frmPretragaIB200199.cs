using DLWMS.Data;
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
    public partial class frmPretragaIB200199 : Form
    {
        List<Student> _listaStudenta;
        string unos;
        DLWMSDbContext baza = KonekcijaNaBazu.Baza;

        public frmPretragaIB200199()
        {
            InitializeComponent();
        }
        private void UcitajPodatke(List<Student> _studenti=null)
        {
            if(_studenti==null)
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = baza.Studenti.ToList();
            }
            else
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = _studenti;
            }

        }
        private void FiltrirajPodatke()
        {
            unos = txtPretraga.Text.ToLower();
            if(txtPretraga.Text==string.Empty&&cmbSpol.SelectedIndex==0)
            {
                UcitajPodatke();
            }
            else if(txtPretraga.Text==string.Empty)
            {
                _listaStudenta = baza.Studenti.Where(x => x.Spol.Id == (cmbSpol.SelectedIndex + 1)).ToList();
                UcitajPodatke(_listaStudenta);
            }
            else if(txtPretraga.Text!=string.Empty&&cmbSpol.SelectedIndex==0)
            {
                _listaStudenta = baza.Studenti.Where(x => x.Ime.ToLower().Contains(unos)
                || x.Prezime.ToLower().Contains(unos) || x.BrojIndeksa.ToLower().Contains(unos)).ToList();
                UcitajPodatke(_listaStudenta);
            }
            else if (txtPretraga.Text != string.Empty)
            {
                _listaStudenta = baza.Studenti.Where(x => (x.Ime.ToLower().Contains(unos) ||
                x.Prezime.ToLower().Contains(unos) || x.BrojIndeksa.ToLower().Contains(unos))
                && (x.Spol.Id == (cmbSpol.SelectedIndex + 1))).ToList();
                UcitajPodatke(_listaStudenta);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            FiltrirajPodatke();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajPodatke();
        }

        private void frmPretragaIB200199_Load(object sender, EventArgs e)
        {
            dgvPretraga.DataSource = baza.Studenti.ToList();
            cmbSpol.DataSource = baza.Spolovi.ToList();
   
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var kolona = dgvPretraga.Columns[e.ColumnIndex];
            if(kolona is DataGridViewButtonColumn)
            {
                var student = dgvPretraga.Rows[e.RowIndex].DataBoundItem as Student;
                frmPorukeIB200199 open = new frmPorukeIB200199(student);
                Hide();
                open.ShowDialog();
                Show();
            }
        }
    }
}
