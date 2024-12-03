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
    public partial class FrmAlitas : MetroFramework.Forms.MetroForm
    {
        public FrmAlitas()
        {
            InitializeComponent();
          
        }

        private void FrmAlitas_Load(object sender, EventArgs e)
        {

        }

        private void btnACP_Click(object sender, EventArgs e)
        {
            Comida comidaSeleccionada = new Comida(500, "Alitas con papas", 250.00);
            FrmCart frmCart = (FrmCart)Application.OpenForms["FrmCart"];
            if (frmCart != null)
            {
                frmCart.AgregarAlCarrito(comidaSeleccionada);
            }

            this.Close();
        }
    }
}
