using Acceso_a_Datos;
using System.Data.SqlClient;
using System.Data;

namespace crud
{
    public partial class frmInicio : Form
    {
        private Conexion conexion = new Conexion();
        private frmMenu Menu = new frmMenu();

        public frmInicio()
        {
            InitializeComponent();
            lblErrorUsrVacio.Visible = false;
            lblErrorUsrInvalido.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var Usuario = txtUser.Text.ToString();
            var Clave = txtPassword.Text.ToString();
            var Validacion = Validar(Usuario, Clave);
            var UsuariosValidados = Validacion.Rows.Count;

            if (UsuariosValidados == 1)
            {
                lblErrorUsrVacio.Visible = false;
                lblErrorUsrInvalido.Visible = false;
                Menu.ShowDialog();

            }
            else if (UsuariosValidados == 0)
            {
                if(Usuario == "" || Clave == "")
                {
                    lblErrorUsrVacio.Visible = true;
                    lblErrorUsrInvalido.Visible = false;
                }
                else
                {
                    lblErrorUsrVacio.Visible = false;
                    lblErrorUsrInvalido.Visible = true;
                }
                
            }

        }

        public DataTable Validar(String User, String Pwd)
        {
            var validacion = new DataTable();
            try
            {
                conexion.OpenConnection();
                using (var Adapter = new SqlDataAdapter())
                {
                    Adapter.SelectCommand = new SqlCommand("select * from Vendedores where venUsuario='"+ User  + "' and venContrase�a='" + Pwd + "'");
                    Adapter.SelectCommand.Connection = conexion.OpenConnection();
                    Adapter.Fill(validacion);
                    Adapter.SelectCommand.Connection.Close();
                }
                conexion.ClosedConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validacion;

        }
    }
}