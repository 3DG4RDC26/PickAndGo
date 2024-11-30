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
    public partial class FrmHambClasica : MetroFramework.Forms.MetroForm
    {
        public FrmHambClasica()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(1, "Hamburguesa Clásica", 110.00);

            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }
        }
    }
}
