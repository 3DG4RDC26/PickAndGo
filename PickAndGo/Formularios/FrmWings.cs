using PickAndGo.FormulariosMenú;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace PickAndGo.Formularios
{
    public partial class FrmWings : MetroFramework.Forms.MetroForm
    {
        public FrmWings()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmWings_Load(object sender, EventArgs e)
        {

        }
       
        private void btnWings1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAlitas frmAlitas = new FrmAlitas();
               frmAlitas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void btnWings2_Click(object sender, EventArgs e)
        {
            FrmHotClasico frmHotClasico = new FrmHotClasico();
            frmHotClasico.ShowDialog();
        }

        private void btnWings4_Click(object sender, EventArgs e)
        {
            FrmHotBolognesa frmHotBolognesa = new FrmHotBolognesa();
            frmHotBolognesa.ShowDialog();
        }

        private void btnWings3_Click(object sender, EventArgs e)
        {
            FrmHotPepinillos frmHotPepinillos = new FrmHotPepinillos();
            frmHotPepinillos.ShowDialog();
        }

       
    }
}
