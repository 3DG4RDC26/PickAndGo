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
    public partial class FrmHotBolognesa : MetroFramework.Forms.MetroForm
    {
        public FrmHotBolognesa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHotBolognesa_Load(object sender, EventArgs e)
        {

        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(503, "Hot-Dog Bolognesa", 150.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
