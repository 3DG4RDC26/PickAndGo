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
    public partial class FrmOrder : MetroFramework.Forms.MetroForm
    {
        private Carrito carrito;
        List<Producto> listaProductos = new List<Producto>();
        public FrmOrder()
        {
        }

        public FrmOrder(Carrito carrito)
        {
            InitializeComponent();
            this.carrito = carrito;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelFactura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
           

   
        }

        private void lblPrecio1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto
                {
                    Codigo = txtCodigo.Text,
                    Nombre = cmbProducto.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtCodigo.Text)
                };

                listaProductos.Add(producto);
                ActualizarDataGridView();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void ActualizarDataGridView()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
            dgvProductos.Columns["Total"].DefaultCellStyle.Format = "C";
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            cmbProducto.SelectedIndex = -1;
            txtPrecio.Clear();
            txtCodigo.Clear();
        }

        private decimal CalcularTotalFactura()
        {
            return listaProductos.Sum(p => p.Total);
        }
    }
}
