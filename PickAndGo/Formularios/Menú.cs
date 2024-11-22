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
        FrmBurguer burguer;
        FrmPizza pizza;
        FrmCalzone calzone;
        FrmPasta pasta;
        FrmWings wings;
        FrmBreakfast breakfast;
        FrmDrinks drinks;
        FrmCart cart;
        FrmOrder order;
        FrmSettings settings;

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
            if (burguer == null)
            {
                burguer = new FrmBurguer();
                burguer.FormClosed += Burguer_FormClosed;
                burguer.MdiParent = this;
                burguer.Dock = DockStyle.Fill;
                burguer.Show();
            }
            else
            {
                burguer.Activate();
            }

            
        }

        private void Burguer_FormClosed(object sender, FormClosedEventArgs e)
        {
            burguer = null;
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            if (pizza == null)
            {
                pizza = new FrmPizza();
                pizza.FormClosed += Pizza_FormClosed;
                pizza.MdiParent = this;
                pizza.Dock = DockStyle.Fill;
                pizza.Show();
            }
            else
            {
                pizza.Activate();
            }

            
        }

        private void Pizza_FormClosed(object sender, FormClosedEventArgs e)
        {
            pizza = null;
        }

        private void btnCalzone_Click(object sender, EventArgs e)
        {
            if (calzone == null)
            {
                calzone = new FrmCalzone();
                calzone.FormClosed += Calzone_FormClosed;
                calzone.MdiParent = this;
                calzone.Dock = DockStyle.Fill;
                calzone.Show();
            }
            else
            {
                calzone.Activate();
            }

            
        }

        private void Calzone_FormClosed(object sender, FormClosedEventArgs e)
        {
            calzone = null;
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            if (pasta == null)
            {
                pasta = new FrmPasta();
                pasta.FormClosed += Pasta_FormClosed;
                pasta.MdiParent = this;
                pasta.Dock = DockStyle.Fill;
                pasta.Show();
            }
            else
            {
                pasta.Activate();
            }

            
        }

        private void Pasta_FormClosed(object sender, FormClosedEventArgs e)
        {
            pasta = null;
        }

        private void btnWing_Click(object sender, EventArgs e)
        {
            if (wings == null)
            {
                wings = new FrmWings();
                wings.FormClosed += Wings_FormClosed;
                wings.MdiParent = this;
                wings.Dock = DockStyle.Fill;
                wings.Show();
            }
            else
            {
                wings.Activate();
            }

            
        }

        private void Wings_FormClosed(object sender, FormClosedEventArgs e)
        {
            wings = null;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            if (breakfast == null)
            {
                breakfast = new FrmBreakfast();
                breakfast.FormClosed += Breakfast_FormClosed;
                breakfast.MdiParent = this;
                breakfast.Dock = DockStyle.Fill;
                breakfast.Show();
            }
            else
            {
                breakfast.Activate();
            }

            
        }

        private void Breakfast_FormClosed(object sender, FormClosedEventArgs e)
        {
            breakfast = null;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            if (drinks == null)
            {
                drinks = new FrmDrinks();
                drinks.FormClosed += Drinks_FormClosed;
                drinks.MdiParent = this;
                drinks.Dock = DockStyle.Fill;
                drinks.Show();
            }
            else
            {
                drinks.Activate();
            }

            
        }

        private void Drinks_FormClosed(object sender, FormClosedEventArgs e)
        {
            drinks = null;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (cart == null)
            {
                cart = new FrmCart();
                cart.FormClosed += Cart_FormClosed;
                cart.MdiParent = this;
                cart.Dock = DockStyle.Fill;
                cart.Show();
            }
            else
            {
                cart.Activate();
            }

            hideSubMenu();
        }

        private void Cart_FormClosed(object sender, FormClosedEventArgs e)
        {
            cart = null;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                order = new FrmOrder();
                order.FormClosed += Order_FormClosed;
                order.MdiParent = this;
                order.Dock = DockStyle.Fill;
                order.Show();
            }
            else
            {
                order.Activate();
            }

            hideSubMenu();
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            order = null;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new FrmSettings();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }

            hideSubMenu();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }


        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        //Codigo realizado por Daniel
        //20 de nov de 2024
    }
}
