using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PickAndGo.Formularios;
using PickAndGo.Models;

namespace PickAndGo.FormulariosMenú
{
    public partial class FrmHambBBQ : MetroFramework.Forms.MetroForm
    {
        public FrmHambBBQ()
        {
            InitializeComponent();
        }

        private void FrmHambBBQ_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(102, "Hamburguesa BBQ", 140.00);

            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }
            this.Close();
        }
    }
}
