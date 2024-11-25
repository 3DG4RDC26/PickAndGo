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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(tbCedulaCif.Text);
            string contraseña = tbPassword.Text;

            RegistrodeUsuario clienteManager = new RegistrodeUsuario();

            if (clienteManager.ValidarCliente(cedula, contraseña))
            {
                Menú formMenu = new Menú();
                formMenu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Cédula/Cif o contraseña incorrecta.");
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}