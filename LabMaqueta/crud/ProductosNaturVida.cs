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

namespace crud
{
    public partial class frmProductosNaturVida : Form
    {
        private Conexion conexion = new Conexion();
        public frmProductosNaturVida()
        {
            InitializeComponent();
        }

        private void btnLimpiarIngresar_Click(object sender, EventArgs e)
        {
            txtCodigoIngresar.Clear();
            txtDescIngresar.Clear();
            txtValorIngresar.Clear();
            txtCantidadIngresar.Clear();
        }

        private void txtValorIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <=47) || 
                (e.KeyChar >=58 && e.KeyChar <= 255)){
                MessageBox.Show("Sólo puede ingresar números.", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadIngresar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnGuardarIngresar_Click(object sender, EventArgs e)
        {
            var codigo = Int32.Parse(txtCodigoIngresar.Text);
            var descripcion = txtDescIngresar.Text;
            var valor = Int32.Parse(txtValorIngresar.Text);
            var cantidad = Int32.Parse(txtCantidadIngresar.Text);
            var insertarProducto = new Entidades.DatosProducto(codigo, descripcion, valor, cantidad);
            insertarProducto.Ingresar();

            MessageBox.Show("El producto fue añadido a la base de datos exitosamente.", "Producto guardado correctamente.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void llenarCmbBoxProductos()
        {
            try
            {
                using(var Command = new SqlCommand("Select proDescripcion from Productos"))
                {
                    Command.Connection = conexion.OpenConnection();
                    SqlDataReader dr;
                    dr = Command.ExecuteReader();  
                    while (dr.Read())
                    {
                        cmbProductoConsultar.Items.Add(dr["proDescripcion"].ToString()); 
                        cmbProductoModificar.Items.Add(dr["proDescripcion"].ToString()); 
                        cmbProductoEliminar.Items.Add(dr["proDescripcion"].ToString()); 
                    }
                    dr.Close();
                    Command.Connection = conexion.ClosedConnection();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductosNaturVida_Load(object sender, EventArgs e)
        {
            llenarCmbBoxProductos();
        }

        private void btnConsultarCons_Click(object sender, EventArgs e)
        {
            var ProductoConsultado = cmbProductoConsultar.Text;
            var Producto = new Entidades.DatosProducto();
            var Tabla = Producto.Consultar(ProductoConsultado.ToString());
            var NumFilas = Tabla.Rows.Count;

            if (NumFilas > 0)
            {
                dataGridProductos.Rows.Clear();
                for (int i = 0; i < NumFilas; i++)
                {
                    var codigo = Tabla.Rows[i][0].ToString();
                    var descripcion = Tabla.Rows[i][1].ToString();
                    var valor = Tabla.Rows[i][2].ToString();
                    var cantidad = Tabla.Rows[i][3].ToString();

                    dataGridProductos.Rows.Add(codigo, descripcion, valor, cantidad);
                }
            }     
        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarMod_Click(object sender, EventArgs e)
        {
            var codigo = "";
            var descripcion = "";
            var valor = "";
            var cantidad = "";
            var ProductoConsultado = cmbProductoModificar.Text;
            var Producto = new Entidades.DatosProducto();
            var Tabla = Producto.Consultar(ProductoConsultado.ToString());
            var NumFilas = Tabla.Rows.Count;

            txtCodidoMod.Clear();
            txtDescMod.Clear();
            txtValorMod.Clear();
            txtCantidadMod.Clear();

            if (ProductoConsultado != "" && NumFilas > 0)
            {
                for (int i = 0; i < NumFilas; i++)
                {
                    codigo = Tabla.Rows[i][0].ToString();
                    descripcion = Tabla.Rows[i][1].ToString();
                    valor = Tabla.Rows[i][2].ToString();
                    cantidad = Tabla.Rows[i][3].ToString();

                    txtCodidoMod.Text = codigo;
                    txtDescMod.Text = descripcion;
                    txtValorMod.Text = valor;
                    txtCantidadMod.Text = cantidad;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var codigo = Int32.Parse(txtCodidoMod.Text);
            var descripcion = txtDescMod.Text;
            var valor = Int32.Parse(txtValorMod.Text);
            var cantidad = Int32.Parse(txtCantidadMod.Text);
            var insertarProducto = new Entidades.DatosProducto(codigo, descripcion, valor, cantidad);
            insertarProducto.Modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //COLOCAR LA LÓGICA PARA ELIMINAR

        }
    }
}
