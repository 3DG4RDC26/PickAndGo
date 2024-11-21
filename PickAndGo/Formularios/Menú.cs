using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenu);
        }

        private void btnBurguer_Click(object sender, EventArgs e)
        {

            hideSubMenu();
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

        private void btnWing_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        //Codigo realizado por Daniel
        //20 de nov de 2024
    }
}
