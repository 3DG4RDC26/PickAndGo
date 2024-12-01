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
    public partial class FrmSandwichPollo : MetroFramework.Forms.MetroForm
    {
        public FrmSandwichPollo()
        {
            InitializeComponent();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(1, "Sandwich de Pollo", 130.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
