using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using SistemaInventario2017.ViewModels;
namespace SistemaInventario2017.Models
{
    public partial class BitacoraRegistroCompras
    {
        private InventarioContext db = new InventarioContext();
        private string CodigoBitacoraCompra { get; set; }
        private const string RegistroCompraSessionKey = "CodigoBitacoraCompra";
        // Generar el codigo de la compra 
        public string GetCodigoBitacoraCompra(HttpContextBase Contexto)
        {
            // Verificar si la session ya existe
            if (Contexto.Session[RegistroCompraSessionKey] == null)
            {
                // Validar si el usuario se encuentra logiado
                if (!string.IsNullOrWhiteSpace(Contexto.User.Identity.Name))
                {
                    Contexto.Session[RegistroCompraSessionKey] = Contexto.User.Identity.Name;
                }
                else
                {
                    Guid CodigoBitacoraCompraTemporal = Guid.NewGuid();
                    Contexto.Session[RegistroCompraSessionKey] = CodigoBitacoraCompraTemporal;
                }
            }
            return Contexto.Session[RegistroCompraSessionKey].ToString();
        }
        //Envio del controlador para crear el objeto que llevara el control de los productos registros en la compra
        public static BitacoraRegistroCompras GetBitacoraRegistroCompra(Controller Controlador)
        {
            return GetBitacoraRegistroCompra(Controlador.HttpContext);
        }
        //Asignación del codigo o llave para el registro de los productos en el proceso de la compora
        public static BitacoraRegistroCompras GetBitacoraRegistroCompra(HttpContextBase Contexto)
        {
            var BitacoraRegistroCompras = new BitacoraRegistroCompras();
            BitacoraRegistroCompras.CodigoBitacoraCompra = BitacoraRegistroCompras.GetCodigoBitacoraCompra(Contexto);
            return BitacoraRegistroCompras;
        }
        //Método para eliminar un elemento
        public int EliminarDeLaCompra(int Id)
        {
            var Elemento = db.RegistroCompras.Single(RC => RC.CodigoRegistro == Id);
            db.RegistroCompras.Remove(Elemento);
            db.SaveChanges();
            return 0;
        }

        //Metodo para agregar un elmento al registro de compra
        public void AgregarRegistroCompra(CompraProductoViewModel Producto)
        {
            //Valida si existe un producto con nombre del usuario y el codigo del producto
            var ElementoCompra = db.RegistroCompras.SingleOrDefault(rc => rc.NombreUsuario == this.CodigoBitacoraCompra &&
                rc.CodigoProducto == Producto.CodigoProducto);
            if (ElementoCompra == null)
            {
                //Crea un registro nuevo
                ElementoCompra = new RegistroCompras
                {
                    NombreUsuario = this.CodigoBitacoraCompra,
                    CodigoProducto = Producto.CodigoProducto,
                    Cantidad = Producto.Cantidad,
                    PrecioCompra = Producto.PrecioCompra,
                    FechaCreacion = DateTime.Now
                };
                db.RegistroCompras.Add(ElementoCompra);
            }
            else
            {
                ElementoCompra.Cantidad+=Producto.Cantidad;
            }
            db.SaveChanges();
        }
        // Metodo para obtener los elementos de la compra que se van registrando
        public List<RegistroCompras> GetElementosRegistroCompra()
        {
            return db.RegistroCompras.Where(rc => rc.NombreUsuario == this.CodigoBitacoraCompra).ToList();
        }
        //Metodo para obtener el total de la compra
        public decimal GetTotalCompra() {
            decimal? Total = (from RC in db.RegistroCompras
                             where RC.NombreUsuario == this.CodigoBitacoraCompra
                             select (decimal?)(RC.PrecioCompra * (int?)RC.Cantidad)).Sum();
            return Total ?? decimal.Zero;
        }
    }
}