using PickAndGo.Dao;
using PickAndGo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickAndGo.Formularios
{
    public partial class Registrarse : MetroFramework.Forms.MetroForm
    {
        private ClienteDao clientes;
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                CedulaCif = int.Parse(tbCif.Text),
                Nombre = tbName.Text,
                Contraseña = tbPassword.Text,
                Telefono = tbPhoneNumber.Text
            };

            RegistrodeUsuario clienteManager = new RegistrodeUsuario();

            try
            {
                clienteManager.RegistrarCliente(cliente);
                MessageBox.Show("Gracias por registrarse");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            int index = clientes.BuscarIndex(cliente.CedulaCif);

            if (index != -1)
            {
                clientes.Actualizar(cliente);
            }
            else
            {
                clientes.Agregar(cliente);
            }
        }

        private void tbCif_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            
            if (txt.Text.Length > 8)
            {
                txt.Text = txt.Text.Substring(0, 8);
                txt.SelectionStart = 8; 

            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            
            if (txt.Text.Length > 6)
            {
                txt.Text = txt.Text.Substring(0, 6);
                txt.SelectionStart = txt.Text.Length; 
            }
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
