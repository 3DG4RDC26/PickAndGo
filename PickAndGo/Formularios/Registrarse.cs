﻿using PickAndGo.Dao;
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
            Cliente cliente = new Cliente
            {
                CedulaCif = int.Parse(tbCedulaCif.Text),
                Nombre = tbName.Text,
                Contraseña = tbPassword.Text,
                Telefono = tbPhoneNumber.Text
            };

            ClientesDao clienteManager = new ClientesDao();

            try
            {
                clienteManager.RegistrarClientes(cliente);
                MessageBox.Show("Gracias por registrarse");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
