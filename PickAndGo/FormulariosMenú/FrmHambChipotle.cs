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
    public partial class FrmHambChipotle : MetroFramework.Forms.MetroForm
    {
        public FrmHambChipotle()
        {
            InitializeComponent();
        }

        private void AddCart_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(103, "Hamburguesa Chipotle", 110.00);

            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }
           this.Close();
        }
    }
}
