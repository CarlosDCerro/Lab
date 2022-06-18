using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_a_Datos;
using System.Data.SqlClient;
using Entidades;

namespace crud
{
    public partial class frmFacturar : Form
    {
        private Conexion conexion = new Conexion();
        public frmFacturar()
        {
            InitializeComponent();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            llenarCombox();
            UltimaFactura();
        }
        public void llenarCombox()
        {
            try
            { 
                using (var CommandProducto = new SqlCommand("Select proDescripcion from Productos"))
                {
                    CommandProducto.Connection = conexion.OpenConnection();
                    SqlDataReader drProducto;
                    drProducto = CommandProducto.ExecuteReader();
                    cmbProductoFact.Items.Clear();  
                    while (drProducto.Read())
                    {
                        cmbProductoFact.Items.Add(drProducto["proDescripcion"].ToString());
                    }
                    drProducto.Close();
                    CommandProducto.Connection.Close();
                }

                using (var CommandCliente = new SqlCommand("Select * from Clientes"))
                {
                    CommandCliente.Connection = conexion.OpenConnection();
                    SqlDataReader drCliente;
                    drCliente = CommandCliente.ExecuteReader();
                    cmbClienteFact.Items.Clear();
                    while (drCliente.Read())
                    {
                        cmbClienteFact.Items.Add(drCliente["cliNombre"].ToString());
                    }
                    drCliente.Close();
                    CommandCliente.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            var cantidad = txtCantidadFact.Text;
            var cliente = cmbClienteFact.Text;
            var producto = cmbProductoFact.Text;
            var detalleProducto = new Entidades.Facturas();
            var totalFactura = 0;
            if (cantidad != "" && cliente != "")
            {
                var tabla = detalleProducto.Agregar(producto);
                var NumFilas = tabla.Rows.Count;

                if (NumFilas > 0)
                {
                    for (int i = 0; i < NumFilas; i++)
                    {
                        var codigo = Int32.Parse(tabla.Rows[i][0].ToString());
                        var descripcionProducto = tabla.Rows[i][1].ToString();
                        var valor = Int32.Parse(tabla.Rows[i][2].ToString());
                        var total = valor * Int32.Parse(cantidad);
                        
                        dataGridFactura.Rows.Add(codigo, descripcionProducto, cantidad, valor, total);
                        dataGridFactura.Columns[3].DefaultCellStyle.Format = "C";
                        dataGridFactura.Columns[4].DefaultCellStyle.Format = "C";
                    }

                    foreach(DataGridViewRow row in dataGridFactura.Rows)
                    {
                        totalFactura += Convert.ToInt32(row.Cells[4].Value);
                    }
                    txtTotalFact.Text = totalFactura.ToString();
                }
                
            }
            else if(cantidad == "")
            {
                MessageBox.Show("El producto no se puede añadir a la factura sin especificar la cantidad.", "Producto sin cantidad.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El producto no se puede añadir a la factura sin especificar el cliente.", "Producto sin cliente.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltimaFactura()
        {
            var detalleProducto = new Entidades.Facturas();
            var tabla = detalleProducto.DatosFactura();
            txtNumeroFact.Text = (tabla.Rows.Count + 1).ToString();
        }

        private void btnTerminarFact_Click(object sender, EventArgs e)
        {
            frmFacturar factura = new frmFacturar();
            factura.Close();

        }

        private void txtCantidadFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar números.", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cmbClienteFact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int BuscarDocumentoCliente(string nombreCliente)
        {
            int documento = 0;
            var consulta = new DataTable();
            if (nombreCliente != "")
            {
                try
                {
                    using (var Adapter = new SqlDataAdapter())
                    {
                        Adapter.SelectCommand = new SqlCommand("Select * from Clientes Where cliNombre = '" + nombreCliente + "'");
                        Adapter.SelectCommand.Connection = conexion.OpenConnection();
                        Adapter.Fill(consulta);
                        Adapter.SelectCommand.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                documento = Int32.Parse(consulta.Rows[0][0].ToString());
            }
            return documento;
        }
    }
}