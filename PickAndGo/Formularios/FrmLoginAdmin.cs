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
    public partial class FrmLoginAdmin : MetroFramework.Forms.MetroForm
    {
        public FrmLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cedulaCif = tbCedulaCif.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (cedulaCif == "Admin" && password == "2602")
            {
                FrmCRUD formCRUD = new FrmCRUD();
                formCRUD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cédula o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}