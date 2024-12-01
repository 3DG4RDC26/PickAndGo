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
    public partial class FrmSPollo : MetroFramework.Forms.MetroForm
    {
        public FrmSPollo()
        {
            InitializeComponent();
        }

        private void FrmSPollo_Load(object sender, EventArgs e)
        {

        }

        private void btnSPO_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(1, "Sandwich de Pollo", 150.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
