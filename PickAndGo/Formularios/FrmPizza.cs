using PickAndGo.FormulariosMenú;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickAndGo.Formularios
{
    public partial class FrmPizza : MetroFramework.Forms.MetroForm
    {
        public FrmPizza()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmPizza_Load(object sender, EventArgs e)
        {

        }

        private void btnPizza1_Click(object sender, EventArgs e)
        {
            FrmPizzaPeppe frmPizzaPeppe = new FrmPizzaPeppe();
            frmPizzaPeppe.ShowDialog();
        }

        private void btnPizza2_Click(object sender, EventArgs e)
        {
            FrmPizzaHawaii frmPizzaHawaii = new FrmPizzaHawaii();
            frmPizzaHawaii.ShowDialog();
        }

        private void btnPizza3_Click(object sender, EventArgs e)
        {
            FrmPizzaJamon frmPizzaJamon = new FrmPizzaJamon();
            frmPizzaJamon.ShowDialog();
        }

        private void btnPizza4_Click(object sender, EventArgs e)
        {
            FrmCheeseSticks frmCheeseSticks = new FrmCheeseSticks();
            frmCheeseSticks.ShowDialog();
        }
    }
}
