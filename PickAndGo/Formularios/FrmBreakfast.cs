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

        private void btnBreak1_Click(object sender, EventArgs e)
        {
            FrmSandwichPollo frmSandwichPollo = new FrmSandwichPollo();
            frmSandwichPollo.ShowDialog();
        }

        private void btnBreak2_Click(object sender, EventArgs e)
        {
            FrmSPollo frmSPollo = new FrmSPollo();
            frmSPollo.ShowDialog();
        }

        private void btnBreak3_Click(object sender, EventArgs e)
        {
            FrmQuesaDesayuno frmQuesaDesayuno = new FrmQuesaDesayuno();
            frmQuesaDesayuno.ShowDialog();
        }

        private void btnBreak4_Click(object sender, EventArgs e)
        {
            FrmQuesadilla frmQuesadilla = new FrmQuesadilla();
            frmQuesadilla.ShowDialog();
        }

        private void btnBreak5_Click(object sender, EventArgs e)
        {
            FrmCroJamonYQueso frmCroJamonYQueso = new FrmCroJamonYQueso();
            frmCroJamonYQueso.ShowDialog();

        }

        private void btnBreak6_Click(object sender, EventArgs e)
        {
            FrmCroiHuevo frmCroiHuevo = new FrmCroiHuevo();
            frmCroiHuevo.ShowDialog();
        }

        private void btnBreak7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
