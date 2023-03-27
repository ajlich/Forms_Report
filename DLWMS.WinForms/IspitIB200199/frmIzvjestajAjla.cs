using DLWMS.Data;
using DLWMS.Data.IspitIB200199;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB200199
{
    public partial class frmIzvjestajAjla : Form
    {
        DLWMSDbContext baza = KonekcijaNaBazu.Baza;
         Student _student;
        public frmIzvjestajAjla(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmIzvjestajAjla_Load(object sender, EventArgs e)
        {
            var tabela = new DSIzvjestaj.AtributiDataTable();
            var odabranaBaza = baza.StudentiPoruke.Where(x => x.Student.Id == _student.Id).ToList();
            foreach(var svaka in odabranaBaza)
            {
                var red = tabela.NewAtributiRow();
                red.Predmet = svaka.Predmet.ToString();
                red.Datum = svaka.Datum.ToString();
                red.Sadrzaj = svaka.Sadrzaj.ToString();
                red.Slika = svaka.Slika != null ? "DA" : "NE";

                tabela.AddAtributiRow(red);
            }
            var parametar = new ReportParameterCollection();
            parametar.Add(new ReportParameter("rptStudent", _student.ToString()));
            reportViewer1.LocalReport.SetParameters(parametar);

            var izvorPod = new ReportDataSource();
            izvorPod.Name = "infoTabela";
            izvorPod.Value = tabela;
            reportViewer1.LocalReport.DataSources.Add(izvorPod);
            reportViewer1.RefreshReport();
        }
    }
}
