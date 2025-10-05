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

            objComando.CommandText = "SELECT * FROM alumnos"; //Seleccionar todo de una tabla
            objAdaptador.Fill(objDs, "alumnos"); //Tomando los datos de la BD y llenando DataSet

            objComando.CommandText = "SELECT * FROM docentes"; //Seleccionar todo de una tabla
            objAdaptador.Fill(objDs, "docentes"); //Tomando los datos de la BD y llenando DataSet

            objComando.CommandText = "SELECT * FROM materias"; //Seleccionar todo de una tabla
            objAdaptador.Fill(objDs, "materias");

            return objDs;
        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        
        public string administrarDatosDocentes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO docentes(codigo,nombre,asignatura,direccion,telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "','" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE docentes SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', asignatura='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + datos[5] + "' WHERE idDocente='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocente='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        public string administrarDatosMateria(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,unidadvalorativa) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', unidadvalorativa='" + datos[3] + "' WHERE idMateria='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria='" + datos[0] + "'";
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
