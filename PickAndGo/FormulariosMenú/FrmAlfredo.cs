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
    public partial class FrmAlfredo : MetroFramework.Forms.MetroForm
    {
        public FrmAlfredo()
        {
            InitializeComponent();
        }

        private void btnMSA_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(401, "Macarrones con pasta alfredo", 200.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
