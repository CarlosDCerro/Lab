using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Productos = new frmProductosNaturVida();
            Productos.ShowDialog();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Facturar = new frmFacturar();
            Facturar.ShowDialog();
        }
    }
}
