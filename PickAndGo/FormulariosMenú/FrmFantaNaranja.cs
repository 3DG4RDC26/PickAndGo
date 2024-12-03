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
    public partial class FrmFantaNaranja : MetroFramework.Forms.MetroForm
    {
        public FrmFantaNaranja()
        {
            InitializeComponent();
        }

        private void btnFN_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(007, "Fanta Naranja", 30.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
