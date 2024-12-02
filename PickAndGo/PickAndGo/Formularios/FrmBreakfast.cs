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
    public partial class FrmBreakfast : MetroFramework.Forms.MetroForm
    {
        public FrmBreakfast()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmBreakfast_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSandwichPollo_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSandwichRes_Click(object sender, EventArgs e)
        {
            FrmSPollo SandwichPollo = new FrmSPollo();
            SandwichPollo.Show();
        }

        private void btnQuesadilla_Click(object sender, EventArgs e)
        {
            FrmQuesadilla Quesadilla = new FrmQuesadilla();
            Quesadilla.Show();
        }

        private void btnQuesadillaPollo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCroissantJamón_Click(object sender, EventArgs e)
        {
            FrmCroissantJamon croissantJamon = new  FrmCroissantJamon();
            croissantJamon.Show();
        }

        private void btnCroissantHuevo_Click(object sender, EventArgs e)
        {
            FrmCroissantHuevo croissantHuevo = new FrmCroissantHuevo();
            croissantHuevo.Show();
        }

        private void btnCroissantPollo_Click(object sender, EventArgs e)
        {
            FrmCroissantPollo croissantPollo = new FrmCroissantPollo();
            croissantPollo.Show();
        }
    }
}
