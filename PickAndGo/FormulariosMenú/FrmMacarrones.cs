using PickAndGo.Formularios;
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

namespace PickAndGo.FormulariosMenú
{
    public partial class FrmMacarrones : MetroFramework.Forms.MetroForm
    {
        public FrmMacarrones()
        {
            InitializeComponent();
        }

        private void FrmMacarrones_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnMSQC_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(1, "Macarrones en salsa de queso cheddar", 200.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
