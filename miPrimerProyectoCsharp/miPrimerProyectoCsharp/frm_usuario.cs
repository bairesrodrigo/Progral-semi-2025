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
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["usuarios"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idUsuario"] };

            grdUsuarios.DataSource = objDt.DefaultView;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idUsuario.Text = objDt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = objDt.Rows[posicion]["usuario"].ToString();
                txtClaveUsuario.Text = objDt.Rows[posicion]["clave"].ToString();
                txtNombreUsuario.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionUsuario.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoUsuario.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblRegistroUsuario.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++; //Posicion = Posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosUsuario.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idUsuario.Text = "";
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtConfirmarClave.Text = "";
            txtNombreUsuario.Text = "";
            txtDireccionUsuario.Text = "";
            txtTelefonoUsuario.Text = "";

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (btnAgregarUsuario.Text == "Nuevo")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else //Guardar
            {

                if (txtUsuario.Text.Length < 6 || txtUsuario.Text.Length > 16)
                {
                    MessageBox.Show("El usuario debe tener entre 6 y 16 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (txtClaveUsuario.Text != txtConfirmarClave.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmarClave.Focus();
                    return;
                }

                bool tieneLetra = txtClaveUsuario.Text.Any(char.IsLetter);
                bool tieneNumero = txtClaveUsuario.Text.Any(char.IsDigit);

                if (!tieneLetra || !tieneNumero)
                {
                    MessageBox.Show("La contraseña debe contener letras y números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveUsuario.Focus();
                    return;
                }

                String[] usuarios =
                {
                idUsuario.Text, txtUsuario.Text, txtClaveUsuario.Text, txtNombreUsuario.Text, txtDireccionUsuario.Text, txtTelefonoUsuario.Text
                };

                String respuesta = objConexion.administrarDatosUsuarios(usuarios, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else //Guardar
            {
                mostrarDatos();
                estadoControles(false);
                btnAgregarUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elIminar a " + txtNombreUsuario.Text, "Eliminando usuarios",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosUsuarios(
                    new String[] { idUsuario.Text, "", "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar usuario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            filtrarDatos(txtBuscarUsuario.Text);

            if (grdUsuarios.Rows.Count > 0)
            {
                seleccionarUsuario();
            }
        }
        private void filtrarDatos(String valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "usuario like '%" + valor + "%' OR nombre like '%" + valor + "%'";
            grdUsuarios.DataSource = objDv;
        }
        private void seleccionarUsuario()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdUsuarios.CurrentRow.Cells["id"].Value));
            mostrarDatos();
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarUsuario();
        }
    }
}
