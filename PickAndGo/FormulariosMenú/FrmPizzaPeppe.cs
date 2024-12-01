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
    public partial class FrmPizzaPeppe : MetroFramework.Forms.MetroForm
    {
        public FrmPizzaPeppe()
        {
            InitializeComponent();
        }

        private void FrmPizzaPeppe_Load(object sender, EventArgs e)
        {

        }

        private void btnPpeper_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(1, "Pizza Pepperoni", 180.00);

            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }
            this.Close();
        }
    }
}
