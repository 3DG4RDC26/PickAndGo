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
    public partial class FrmBurguer : MetroFramework.Forms.MetroForm
    {
        public FrmBurguer()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmBurguer_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btnHambChipotle_Click(object sender, EventArgs e)
        {
            FrmHambChipotle chipotle = new FrmHambChipotle();
            chipotle.ShowDialog();
        }

        private void btnHambClasic_Click(object sender, EventArgs e)
        {
            FrmHambClasica clasica = new FrmHambClasica();
            clasica.ShowDialog();
        }

        private void btnHambDobleCheese_Click(object sender, EventArgs e)
        {
            FrmHambDouble doubleCheese = new FrmHambDouble();
            doubleCheese.ShowDialog();
        }

        private void btnHambBBQ_Click(object sender, EventArgs e)
        {
            FrmHambBBQ bBQ = new FrmHambBBQ();
            bBQ.ShowDialog();
        }

        private void btnHambPepenillo_Click(object sender, EventArgs e)
        {
            FrmHambPepinillos pepinillos = new FrmHambPepinillos();
            pepinillos.ShowDialog();
        }
    }
}
