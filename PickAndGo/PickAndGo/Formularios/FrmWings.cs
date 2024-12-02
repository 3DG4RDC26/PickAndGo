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

        private void btnAlitas_Click(object sender, EventArgs e)
        {
            FrmAlitas Alitas = new FrmAlitas();
            Alitas.Show();
        }

        private void btnHotDog_Click(object sender, EventArgs e)
        {
            FrmHotClasico HotDog = new FrmHotClasico();
            HotDog.Show();
        }

        private void btnHotDogPepinillo_Click(object sender, EventArgs e)
        {
            FrmHotPepinillos HotPepinillos = new FrmHotPepinillos();
            HotPepinillos.Show();
        }

        private void btnHotDogBolonesa_Click(object sender, EventArgs e)
        {
            FrmHotBolognesa hotBolognesa = new FrmHotBolognesa();
            hotBolognesa.Show();
        }
    }
}
