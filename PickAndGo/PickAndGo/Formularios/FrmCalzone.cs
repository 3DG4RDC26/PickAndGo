using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PickAndGo.FormulariosMenú;

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

        private void btnCalzoneSupremo_Click(object sender, EventArgs e)
        {
            FrmCalzoneSupremo CalzoneSupremo = new FrmCalzoneSupremo();
            CalzoneSupremo.Show();
        }

        private void btnCalzoneBoloñesa_Click(object sender, EventArgs e)
        {
            FrmCalzoneBolognesa CalzoneBolognesa = new FrmCalzoneBolognesa();
            CalzoneBolognesa.Show();
        }

        private void btnCalzoneCombo_Click(object sender, EventArgs e)
        { 
            FrmCalzoneCombo CalzoneCombo = new FrmCalzoneCombo();
            CalzoneCombo.Show();
        }
    }
}
