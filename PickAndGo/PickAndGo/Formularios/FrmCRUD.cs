using Microsoft.Reporting.WinForms;
using PickAndGo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickAndGo.Formularios
{
    public partial class FrmCRUD : MetroFramework.Forms.MetroForm
    {
        private Cliente cliente;
        public FrmCRUD()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           ReportDataSource dataSourse = new ReportDataSource("DsDatos", cliente);

            FrmReportes frmReportes = new FrmReportes();
            frmReportes.reportViewer1.LocalReport.DataSources.Clear();
            frmReportes.reportViewer1.LocalReport.DataSources.Add(dataSourse);
            frmReportes.reportViewer1.LocalReport.ReportEmbeddedResource = "PickAndGo.Reportes.RptCliente.rdlc";
            frmReportes.reportViewer1.RefreshReport();
            frmReportes.ShowDialog();
        }
    }
}
