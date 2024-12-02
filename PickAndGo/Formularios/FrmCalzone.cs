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
    public partial class FrmCalzone : MetroFramework.Forms.MetroForm
    {
        public FrmCalzone()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmCalzone_Load(object sender, EventArgs e)
        {

        }

        private void btnCalzone1_Click(object sender, EventArgs e)
        {
            FrmCalzoneSupremo frmCalzoneSupremo = new FrmCalzoneSupremo();
            frmCalzoneSupremo.ShowDialog();
        }

        private void btnCalzone2_Click(object sender, EventArgs e)
        {
            FrmCalzoneBolognesa frmCalzoneBolognesa = new FrmCalzoneBolognesa();
            frmCalzoneBolognesa.ShowDialog();
        }

        private void btnCalzone3_Click(object sender, EventArgs e)
        {
            FrmCalzoneCombo frmCalzoneCombo = new FrmCalzoneCombo();
            frmCalzoneCombo.ShowDialog();
        }
    }
}
