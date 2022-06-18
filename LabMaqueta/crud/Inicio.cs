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
            int Password = Int32.Parse(Pwd);
            var validacion = new DataTable();
            try
            {
                using (var Adapter = new SqlDataAdapter())
                {
                    Adapter.SelectCommand = new SqlCommand("Select * from Vendedores where venUsuario = '"+ User  + "' and venContraseña = '" + Password + "'");
                    Adapter.SelectCommand.Connection = conexion.OpenConnection();
                    Adapter.Fill(validacion);
                    Adapter.SelectCommand.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validacion;
        }
        private void UsuarioVendedor()
        {
            frmFacturar facturar = new frmFacturar();
            facturar.Text = txtUser.Text; 
        }
    }
}