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
    public partial class Menú : MetroFramework.Forms.MetroForm
    {
        public Menú()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            Inicio formInicio = new Inicio();
            formInicio.Show();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenu);
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCalzone_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnWing_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
