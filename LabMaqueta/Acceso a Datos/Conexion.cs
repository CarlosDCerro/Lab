using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public class Conexion
    {
        public static string cn = @"data source = DESKTOP-1CHKE50; 
                                    initial catalog = TiendaNaturista; 
                                    integrated security = true";

        private SqlConnection conecction = new SqlConnection(cn);

        public SqlConnection OpenConnection()
        {
            if (conecction.State == System.Data.ConnectionState.Closed)
            {
                conecction.Open();
            }
            return conecction;
        }
        
        public SqlConnection ClosedConnection()
        {
            if (conecction.State == System.Data.ConnectionState.Open)
            {
                conecction.Close();
            }
            return conecction;
        }
    }
}
