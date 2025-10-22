using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Libreria para usar comando para trabajar con BD
using System.Data.SqlClient; //Esta libreria permite trabajar con SQL Server

namespace miPrimerProyectoCsharp
{
    class Conexion
    {
        //Definir los miembros de la clase, atributos y metodos.
        public SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD
        public SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD
        public SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Puente entre la BD y la App
        DataSet objDs = new DataSet(); //Representacion de la arquitectura de la BD en memoria

        public Conexion() //Constructor //Inicializador de los atributos
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpia el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar comandos

            objAdaptador.SelectCommand = objComando; //Establece el comando de seleccion

            objComando.CommandText = "SELECT * FROM usuarios";
            objAdaptador.Fill(objDs, "usuarios");

            return objDs;
        }

        public string administrarDatosUsuarios(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO usuarios(usuario,clave,nombre,direccion,telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE usuarios SET usuario='" + datos[1] + "', clave='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + datos[5] + "' WHERE idUsuario='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM usuarios WHERE idUsuario='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }

        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
