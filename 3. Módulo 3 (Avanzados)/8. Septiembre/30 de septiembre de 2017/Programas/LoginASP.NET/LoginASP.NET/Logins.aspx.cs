using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LoginASP.NET.Acceso_a_datos;

namespace LoginASP.NET
{
    public partial class Logins : System.Web.UI.Page
    {
        public DataSet Datos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Consultar_Datos();
                txtUsername.Text = string.Empty;
                txtDisplayname.Text = string.Empty;
            }
            else
            {
                Consultar_Datos();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string Sentencia = "insert into users (username,displayname) values ('" + txtUsername.Text + "','" + txtDisplayname + "')";
            Conexion db = new Conexion();
            db.EjecutarSentencia(Sentencia);
            Response.Clear();
        }
        public void Consultar_Datos()
        {
            try
            {
                Conexion db = new Conexion();
                Datos = db.HacerConsulta("SELECT * FROM users", "usuarios");
            }
            catch (Exception e)
            {
                Response.Write(e.Message);
            }
            /*foreach (DataTable Tabla in Datos.Tables)
            {
                foreach (DataRow Registro in Tabla.Rows)
                {
                    Response.Write(Registro.ItemArray[1]);
                    Response.Write("<BR>");
                }
            }*/
    }
        [System.Web.Services.WebMethod]
        public static string registro(string datos)
        {
            try
            {
                string Sentencia = "insert into users (username,displayname) values " + datos + ";";
                Sentencia = Sentencia.Replace("/", "'");
                Conexion db = new Conexion();
                db.EjecutarSentencia(Sentencia);
                return "Registros almacenados";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }
    }
}