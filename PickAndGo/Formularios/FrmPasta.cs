using PickAndGo.FormulariosMenú;
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
    public partial class FrmPasta : MetroFramework.Forms.MetroForm
    {
        public FrmPasta()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmPasta_Load(object sender, EventArgs e)
        {

        }

        private void btnSpa1_Click(object sender, EventArgs e)
        {
            FrmBolognesa frmBolognesa = new FrmBolognesa();
            frmBolognesa.ShowDialog();
        }

        private void btnSpa3_Click(object sender, EventArgs e)
        {
            FrmMacarrones frmMacarrones = new FrmMacarrones();
            frmMacarrones.ShowDialog();
        }

        private void btnSpa2_Click(object sender, EventArgs e)
        {
            FrmAlfredo frmAlfredo = new FrmAlfredo();
            frmAlfredo.ShowDialog();
        }
    }
}
