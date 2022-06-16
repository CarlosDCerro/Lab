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
    public partial class frmFacturar : Form
    {
        public frmFacturar()
        {
            InitializeComponent();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {

        }
        public void llenarCombox()
        {
            try
            { /*
                using (var Command = new SqlCommand("Select proDescripcion from Productos"))
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
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
