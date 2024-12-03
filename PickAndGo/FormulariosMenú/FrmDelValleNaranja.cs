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
    public partial class FrmDelValleNaranja : MetroFramework.Forms.MetroForm
    {
        public FrmDelValleNaranja()
        {
            InitializeComponent();
        }

        private void btnDVN_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida (005, "DelValle Naranja", 45.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
