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
using PickAndGo.Models;

namespace PickAndGo.Formularios
{
    public partial class FrmCart : MetroFramework.Forms.MetroForm
    {

        private Carrito carrito;
        public FrmCart()
        {
            InitializeComponent();
            carrito = new Carrito(); 
            ConfigurarDataGridView();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
            MostrarTotal();
        }
        private void ConfigurarDataGridView()
        {
            dgvCarrito.Columns.Clear();

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "Nombre";
            Width = 200;

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "Precio";

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "Cantidad";

            dgvCarrito.Columns.Add(colNombre);
            dgvCarrito.Columns.Add(colPrecio);
            dgvCarrito.Columns.Add(colCantidad);
        }

        public void AgregarAlCarrito(Comida comida)
        {
            carrito.AgregarComida(comida);

            int filaIndex = dgvCarrito.Rows.Add();
            dgvCarrito.Rows[filaIndex].Cells["Nombre"].Value = comida.Nombre;
            dgvCarrito.Rows[filaIndex].Cells["Precio"].Value = comida.Precio.ToString("C", CultureInfo.GetCultureInfo("es-NI"));
            dgvCarrito.Rows[filaIndex].Cells["Cantidad"].Value = 1;

            MostrarTotal();
        }

        private void MostrarTotal()
        {
            double total = carrito.ObtenerTotal();
            lblTotal2.Text = $"Total: {total.ToString("C", CultureInfo.GetCultureInfo("es-NI"))}";
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal2_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesoPago_Click(object sender, EventArgs e)
        {
            FrmPago frmPagar = new FrmPago(carrito);  
            frmPagar.ShowDialog();
        }
    }
}
