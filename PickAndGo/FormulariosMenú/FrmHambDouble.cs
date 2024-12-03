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
    public partial class FrmHambDouble : MetroFramework.Forms.MetroForm
    {
        public FrmHambDouble()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(105, "Hamburguesa Doble", 300.00);

            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }
            this.Close();

        }
    }
}
