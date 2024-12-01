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

       
    }
}
