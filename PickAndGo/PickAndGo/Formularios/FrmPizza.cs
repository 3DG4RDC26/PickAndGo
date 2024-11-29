using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PickAndGo.FormulariosMenú;

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

        private void btnPizzaPeperoni_Click(object sender, EventArgs e)
        {
            FrmPizzaPeppe PizzaPeperoni = new FrmPizzaPeppe();
            PizzaPeperoni.Show();
        }

        private void btnPizzaHawaina_Click(object sender, EventArgs e)
        {
            FrmPizzaHawaii PizzaHawaina = new FrmPizzaHawaii();
            PizzaHawaina.Show();
        }

        private void btnPizzaJamon_Click(object sender, EventArgs e)
        {
            FrmPizzaJamon PizzaJamon = new FrmPizzaJamon();
            PizzaJamon.Show();
        }

        private void btnCheeseSticks_Click(object sender, EventArgs e)
        {
            FrmCheeseSticks CheeseSticks = new FrmCheeseSticks();
            CheeseSticks.Show();
        }
    }
}
