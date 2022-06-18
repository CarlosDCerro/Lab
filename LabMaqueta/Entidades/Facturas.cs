using Acceso_a_Datos;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Entidades
{
    public class Facturas
    {
        private Conexion conexion = new Conexion();
        private int _facNumero;
        private DateTime _facFecha;
        private string? _facCliente;
        private int _facTotal;
        private string? _facVendedor;

        public Facturas([Optional] int facNumero,
                        [Optional] DateTime facFecha,
                        [Optional] string? facCliente,
                        [Optional] int facTotal,
                        [Optional] string? facVendedor)
        {
            _facNumero = facNumero;
            _facFecha = facFecha;
            _facCliente = facCliente;
            _facTotal = facTotal; 
            _facVendedor = facVendedor;
        }

        public int FacNumero { get => _facNumero; set => _facNumero = value; }
        public DateTime FacFecha { get => _facFecha; set => _facFecha = value; }
        public string? FacCliente { get => _facCliente; set => _facCliente = value; }
        public int FacTotal { get => _facTotal; set => _facTotal = value; }
        public string? FacVendedor { get => _facVendedor; set => _facVendedor = value; }

        public DataTable Agregar(string producto)
        {
            var Producto = new Entidades.DatosProducto();
            var detalleProducto = Producto.Consultar(producto.ToString());
            var codigo = Int32.Parse(detalleProducto.Rows[0][0].ToString());
            var descripcion = detalleProducto.Rows[0][1].ToString();
            var valor = Int32.Parse(detalleProducto.Rows[0][2].ToString());

            DataRow datosNuevos = detalleProducto.NewRow();
            datosNuevos[0] = codigo;
            datosNuevos[1] = descripcion;
            datosNuevos[2] = valor;

            return detalleProducto;
        }

        public DataTable DatosFactura()
        {
            var factura = new DataTable();
            try
            {
                using (var Adapter = new SqlDataAdapter())
                {
                    Adapter.SelectCommand = new SqlCommand("Select * from Facturas");
                    Adapter.SelectCommand.Connection = conexion.OpenConnection();
                    Adapter.Fill(factura);
                    Adapter.SelectCommand.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return factura;
        }

        public void TerminarFactura(
            int FacNumero,
            DateTime FacFecha,
            int FacCLiente,
            int FacTotal,
            string FacVendedor,
            string FacProducto,
            int FacCantidad
            )
        {
            try
            {
                using (var Command = new SqlCommand("sp_InsertarFacturas"))
                {
                    Command.Parameters.AddWithValue("@facNumero", FacNumero);
                    Command.Parameters.AddWithValue("@facFecha", FacFecha);
                    Command.Parameters.AddWithValue("@facCliente", FacCLiente);
                    Command.Parameters.AddWithValue("@facValorTotal", FacTotal);
                    Command.Parameters.AddWithValue("@facVendedor", FacVendedor);
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Connection = conexion.OpenConnection();
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                }
                
                using (var Command = new SqlCommand("sp_InsertarFacturasDetalles"))
                {
                    Command.Parameters.AddWithValue("@facNumero", FacNumero);
                    Command.Parameters.AddWithValue("@facProducto", FacProducto);
                    Command.Parameters.AddWithValue("@facCantidad", FacCantidad);
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Connection = conexion.OpenConnection();
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}