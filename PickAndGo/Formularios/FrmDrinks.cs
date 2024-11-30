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
    public partial class FrmDrinks : MetroFramework.Forms.MetroForm
    {
        public FrmDrinks()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmDrinks_Load(object sender, EventArgs e)
        {

        }

        private void btnDrink1_Click(object sender, EventArgs e)
        {
            FrmCanadaDry frmCanadaDry = new FrmCanadaDry();
            frmCanadaDry.ShowDialog();
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            FrmSprite frmSprite = new FrmSprite();
            frmSprite.ShowDialog();
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            FrmCocaCola frmCocaCola = new FrmCocaCola();
            frmCocaCola.ShowDialog();
        }

        private void btnDD4_Click(object sender, EventArgs e)
        {
            FrmFresca frmFresca = new FrmFresca();
            frmFresca.ShowDialog();
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            FrmDelValleLimon frmDelValleLimon = new FrmDelValleLimon();
            frmDelValleLimon.ShowDialog();
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            FrmFantaNaranja frmFantaNaranja = new FrmFantaNaranja();
            frmFantaNaranja.ShowDialog();
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            FrmFantaRoja frmFantaRoja = new FrmFantaRoja();
            frmFantaRoja.ShowDialog();
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            FrmPowerAdeAzul frmPowerAdeAzul = new FrmPowerAdeAzul();
            frmPowerAdeAzul.ShowDialog();
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            FrmPowerAdeRojo frmPowerRojo = new FrmPowerAdeRojo();   
            frmPowerRojo.ShowDialog();
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            FrmDelValleNaranja frmDelValleNaranja = new FrmDelValleNaranja();
            frmDelValleNaranja.ShowDialog(); 
                    
        }
    }
}
