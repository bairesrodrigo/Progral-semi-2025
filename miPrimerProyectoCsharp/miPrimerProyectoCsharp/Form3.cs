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
    public partial class Form3 : Form
    {
        public Form3()
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
            objDt = objDs.Tables["materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] };

            grdMateria.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idMateria.Text = objDt.Rows[posicion]["idMateria"].ToString();
                txtCodigoMateria.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreMateria.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUnidadValorativa.Text = objDt.Rows[posicion]["unidadvalorativa"].ToString();

                lblRegistroMateria.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++; //Posicion = Posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMateria_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroMateria_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosMaterias.Enabled = estado;
            grbNavegacionMateria.Enabled = !estado;
            btnEliminarMateria.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idMateria.Text = "";
            txtCodigoMateria.Text = "";
            txtNombreMateria.Text = "";
            txtUnidadValorativa.Text = "";
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (btnAgregarMateria.Text == "Nuevo")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();

            }
            else //Guardar
            {
                String[] materias =
                {
                    idMateria.Text, txtCodigoMateria.Text, txtNombreMateria.Text, txtUnidadValorativa.Text
                };

                String respuesta = objConexion.administrarDatosMateria(materias, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                    actualizarDs();
                }

            }
        }
        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (btnModificarMateria.Text == "Modificar")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else //Guardar
            {
                mostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elIminar a la materia " + txtNombreMateria.Text, "Eliminando materias",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosMateria(
                    new String[] { idMateria.Text, "", "", ""}, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarMateria_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarMateria.Text);

            if (grdMateria.Rows.Count > 0)
            {
                seleccionarMateria();
            }
        }
        private void filtrarDatos(String valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
            grdMateria.DataSource = objDv;
        }
        private void seleccionarMateria()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdMateria.CurrentRow.Cells["id"].Value));
            mostrarDatos();
        }

        private void grdMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarMateria();
        }
    }
}
