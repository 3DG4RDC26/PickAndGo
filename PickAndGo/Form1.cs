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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            int telefono = int.Parse(txtNumber.Text);
            int cif = int.Parse(txtCif.Text);

            Cliente cliente = new Cliente(idcliente, nombre, telefono, cif);

            Form2 form2 = new Form2();
            form2.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
