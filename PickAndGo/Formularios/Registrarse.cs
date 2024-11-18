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

namespace PickAndGo.Formularios
{
    public partial class Registrarse : MetroFramework.Forms.MetroForm
    {
        public Registrarse()
        {
            InitializeComponent();
        }

      private void btnRegistrarse_Click(object sender, EventArgs e)
      {
         string Nombre = (tbName.Text);
         int CedulaCif = int.Parse(tbCedula.Text);
         string Contraseña = (tbPassword.Text);
         string Telefono = (tbPhoneNumber.Text);
         
         MessageBox.Show("Gracias por registrarse");
         Close();
      }
   }
}
