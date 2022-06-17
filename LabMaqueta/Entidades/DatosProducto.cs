using System.Data.SqlClient;
using Acceso_a_Datos;
using System.Data;
using System.Runtime.InteropServices;

namespace Entidades
{
    public class DatosProducto
    {
        private Conexion conexion = new Conexion();

        private int _proCodigo;
        private string _proDescripcion = "";
        private int _proValor;
        private int _proCantdad;    
        public DatosProducto([Optional] int proCodigo,
                            [Optional] string proDescripcion,
                            [Optional] int proValor,
                            [Optional] int proCantdad)
        {
            _proCodigo = proCodigo;
            _proDescripcion = proDescripcion;
            _proValor = proValor;
            _proCantdad = proCantdad;
        }

        public int ProCodigo { get => _proCodigo; set => _proCodigo = value; }
        public string ProDescripcion { get => _proDescripcion; set => _proDescripcion = value; }
        public int ProValor { get => _proValor; set => _proValor = value; }
        public int ProCantdad { get => _proCantdad; set => _proCantdad = value; }

        public void Ingresar()
        {
            try
            {
                using (var Command = new SqlCommand("sp_InsertarProductos"))
                {
                    Command.Parameters.AddWithValue("@proCodigo", _proCodigo);
                    Command.Parameters.AddWithValue("@proDescripcion", _proDescripcion);
                    Command.Parameters.AddWithValue("@proValor", _proValor);
                    Command.Parameters.AddWithValue("@proCantidad", _proCantdad);
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Connection = conexion.OpenConnection();
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                }
            }catch(SqlException ex){
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        public DataTable Consultar(string producto)
        {
            var consulta = new DataTable();
            if(producto == "")
            {
                try
                {
                    using (var Adapter = new SqlDataAdapter())
                    {
                        Adapter.SelectCommand = new SqlCommand("Select * from Productos");
                        Adapter.SelectCommand.Connection = conexion.OpenConnection();
                        Adapter.Fill(consulta);
                        Adapter.SelectCommand.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (var Adapter = new SqlDataAdapter())
                    {
                        Adapter.SelectCommand = new SqlCommand("sp_BuscarProducto");
                        Adapter.SelectCommand.Parameters.AddWithValue("@textobuscar",producto);
                        Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        Adapter.SelectCommand.Connection = conexion.OpenConnection();
                        Adapter.Fill(consulta);
                        Adapter.SelectCommand.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return consulta;
        }

        public void Modificar()
        {
            try
            {
                using (var Command = new SqlCommand("sp_ModificarProductos"))
                {
                    Command.Parameters.AddWithValue("@proCodigo", _proCodigo);
                    Command.Parameters.AddWithValue("@proDescripcion", _proDescripcion);
                    Command.Parameters.AddWithValue("@proValor", _proValor);
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

            MessageBox.Show("El producto fue modificado a la base de datos exitosamente.", "Producto actualizado correctamente.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Eliminar ()
        {
            try
            {
                using (var Command = new SqlCommand("sp_EliminarProductos"))
                {
                    Command.Parameters.AddWithValue("@proDescripcion", _proDescripcion);
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
            MessageBox.Show("El producto fue eliminado a la base de datos exitosamente.", "Producto eiminado correctamente.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}