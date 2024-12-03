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
    public partial class FrmCheeseSticks : MetroFramework.Forms.MetroForm
    {
        public FrmCheeseSticks()
        {
            InitializeComponent();
        }

        private void FrmCheeseSticks_Load(object sender, EventArgs e)
        {

        }

        private void btnChS_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(204, "Chesse Sticks", 180.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
