using PickAndGo.Formularios;
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

namespace PickAndGo
{
   public partial class Login : MetroFramework.Forms.MetroForm
   {
      public Login()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         int CedulaCif = int.Parse(tbCedulaCif.Text);
         int Password = int.Parse(tbPassword.Text);

         Cliente cliente = new Cliente();

         Menú formMenu = new Menú();
         formMenu.Show();
      }

      private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         try
         {
            Registrarse formRegistrarse = new Registrarse();

            formRegistrarse.ShowDialog();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al abrir el formulario de registro: " + ex.Message);
         }
      }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}