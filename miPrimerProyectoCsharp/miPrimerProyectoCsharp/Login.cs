using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Login : Form
    {
        Conexion objConexion = new Conexion();

        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = "SELECT * FROM usuarios WHERE usuario='" + usuario + "' AND clave='" + clave + "'";
                DataTable dt = new DataTable();

                objConexion.objComando.CommandText = sql;
                objConexion.objComando.Connection = objConexion.objConexion;
                objConexion.objAdaptador.SelectCommand = objConexion.objComando;
                objConexion.objAdaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bienvenido " + dt.Rows[0]["nombre"].ToString(), "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el formulario de usuarios
                    frm_usuario frm = new frm_usuario();
                    frm.Show();

                    this.Hide(); // Oculta el login
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
