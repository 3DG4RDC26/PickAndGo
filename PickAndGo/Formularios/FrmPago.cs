using PickAndGo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickAndGo.Formularios
{
    public partial class FrmPago : MetroFramework.Forms.MetroForm
    {
        private Carrito carrito;
        public FrmPago(Carrito carrito)
        {
            InitializeComponent();
            this.carrito = carrito;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigurarResumenPedido();
            MostrarResumenPedido();
            ActualizarTotal(carrito.ObtenerTotal());
        }

        private void ConfigurarResumenPedido()
        {
            dgvResumen.Columns.Clear();

            dgvResumen.Columns.Add("Nombre", "Nombre");
            dgvResumen.Columns.Add("Precio", "Precio");
            dgvResumen.Columns.Add("Cantidad", "Cantidad");
            dgvResumen.Columns.Add("Total", "Total");
            dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void MostrarResumenPedido()
        {

            dgvResumen.Rows.Clear();
            foreach (var comida in carrito.Productos)
            {

                int filaIndex = dgvResumen.Rows.Add();
                dgvResumen.Rows[filaIndex].Cells["Nombre"].Value = comida.Nombre;
                dgvResumen.Rows[filaIndex].Cells["Precio"].Value = comida.Precio.ToString("C", CultureInfo.GetCultureInfo("es-NI"));
                dgvResumen.Rows[filaIndex].Cells["Cantidad"].Value = 1;
                dgvResumen.Rows[filaIndex].Cells["Total"].Value = comida.Precio.ToString("C", CultureInfo.GetCultureInfo("es-NI"));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizarTotal(double total)
        {
            double totall = carrito.ObtenerTotal();
            lblTotal.Text = $" {total.ToString("C", CultureInfo.GetCultureInfo("es-NI"))}";
        }


        private void txtFrontales_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || txtFrontales.Text.Length >= 16)
            {
                e.Handled = true;
            }
        }

        private void txtSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || txtSeguridad.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void ConfigurarNumericUpDown()
        {
            nudYY.Minimum = 01;
            nudYY.Maximum = 99;
            nudYY.DecimalPlaces = 0;
        }

        private void ConfigurarNumericUpDown2()
        {
            nudMM.Minimum = 01;
            nudMM.Maximum = 31;
            nudMM.DecimalPlaces = 0;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposPago())
            {
                
                ProcesarPago();

              
                MessageBox.Show("Pago realizado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposPago()
        {
         
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                return false; 
            }
            if (string.IsNullOrWhiteSpace(txtFrontales.Text) || txtFrontales.Text.Length != 16)
            {
                return false; 
            }
            if (string.IsNullOrWhiteSpace(txtSeguridad.Text) || txtSeguridad.Text.Length != 3)
            {
                return false;
            }
            if (nudYY.Value == 0 || nudMM.Value == 0)
            {
                return false; 
            }

            return true;
        }

        private void ProcesarPago()
        {

            carrito.Limpiar();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            
        }
    }
}
