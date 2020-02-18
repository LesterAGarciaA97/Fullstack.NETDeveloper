using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
namespace LoginASP.NET.Acceso_a_datos
{
    public class Conexion
    {
        private MySqlConnection _ConexionDB;
        //public SqlConnection ConexionDB { get; set; }
        public MySqlConnection ConexionDB
        {
            get
            {
                if(_ConexionDB == null)
                {
                    return _ConexionDB = new MySqlConnection("Server=192.168.101.101;Database=dbposts;Uid=sabado;Pwd=guatemala;");
                }
                else
                {
                    return _ConexionDB;
                }
            }
            set
            {
                _ConexionDB = value;
            }
        }
        public DataSet HacerConsulta(string Consulta, string NombreTabla)
        {
            DataSet Resultado = null;
            try
            {
                Resultado = new DataSet();
                MySqlDataAdapter DataAdapterConsulta = new MySqlDataAdapter(Consulta, ConexionDB);
                DataAdapterConsulta.Fill(Resultado, NombreTabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Resultado;
        }
        public void EjecutarSentencia(string Sentencia)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Sentencia, ConexionDB);
                ConexionDB.Open();
                cmd.ExecuteNonQuery();
                ConexionDB.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                ConexionDB.Close();
            }
        }
    }
}