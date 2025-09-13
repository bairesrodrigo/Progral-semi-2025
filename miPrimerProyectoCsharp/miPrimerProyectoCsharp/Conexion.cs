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
        SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Puente entre la BD y la App
        DataSet objDs = new DataSet(); //Representacion de la arquitectura de la BD en memoria

        public Conexion() //Constructor //Inicializador de los atributos
        {
            String cadenaConexion = "";
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

            return objDs;
        }
    }
}
