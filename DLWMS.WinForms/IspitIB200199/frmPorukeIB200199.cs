using DLWMS.Data;
using DLWMS.Data.IspitIB200199;
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

namespace DLWMS.WinForms.IspitIB200199
{
    public partial class frmPorukeIB200199 : Form
    {
         Student _student;
        DLWMSDbContext baza = KonekcijaNaBazu.Baza;
        List<StudentPoruka> _poruke;
        public frmPorukeIB200199(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmPorukeIB200199_Load(object sender, EventArgs e)
        {
            lblStudent.Text = _student.ToString();
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            _poruke = baza.StudentiPoruke.Where(x => x.Student.Id == _student.Id).Include(y => y.Student).Include(z => z.Predmet).ToList();
            if(_poruke!=null&&_poruke.Count()!=0)
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = _poruke;
            }
            else
            {
                dgvPoruke.DataSource = null;
            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB200199 open = new frmNovaPorukaIB200199(_student);
            Hide();
            open.ShowDialog();
            Show();
            UcitajPodatke();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4)
            {
                var index = e.RowIndex;
                var poruka = _poruke[index];
                var ispisPoruku = MessageBox.Show("Da li sigurno želite izbrisati?", "Brisanje", MessageBoxButtons.YesNo);
                if(ispisPoruku==DialogResult.Yes)
                {
                    baza.StudentiPoruke.Remove(poruka);
                    baza.SaveChanges();
                    UcitajPodatke();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            frmIzvjestajAjla open = new frmIzvjestajAjla(_student);
            open.ShowDialog();
        }
    }
}
