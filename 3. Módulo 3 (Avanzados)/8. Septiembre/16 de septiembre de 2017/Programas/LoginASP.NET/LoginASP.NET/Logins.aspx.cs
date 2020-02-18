﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Consultar_Datos();
                TxtUsername.Text = string.Empty;
                TxtDisplayname.Text = string.Empty;
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string Sentencia = "insert into users (username,displayname) values ('" + TxtUsername.Text + "','" + TxtDisplayname + "')";
            Conexion db = new Conexion();
            db.EjecutarSentencia(Sentencia);
            Response.Clear();
        }
        public void Consultar_Datos()
        {
            Conexion db = new Conexion();
            DataSet Datos = db.HacerConsulta("SELECT * FROM users", "usuarios");
            foreach (DataTable Tabla in Datos.Tables)
            {
                foreach (DataRow Registro in Tabla.Rows)
                {
                    Response.Write(Registro.ItemArray[1]);
                    Response.Write("<BR>");
                }
            }
    }
}
}