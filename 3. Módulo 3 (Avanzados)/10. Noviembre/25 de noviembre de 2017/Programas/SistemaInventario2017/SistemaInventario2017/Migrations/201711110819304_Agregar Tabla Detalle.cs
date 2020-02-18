namespace SistemaInventario2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTablaDetalle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalleCompras",
                c => new
                    {
                        CodigoDetalleCompra = c.Int(nullable: false, identity: true),
                        NumeroDocumento = c.Int(nullable: false),
                        CodigoProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CodigoDetalleCompra)
                .ForeignKey("dbo.Compras", t => t.NumeroDocumento, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.CodigoProducto, cascadeDelete: true)
                .Index(t => t.NumeroDocumento)
                .Index(t => t.CodigoProducto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleCompras", "CodigoProducto", "dbo.Productos");
            DropForeignKey("dbo.DetalleCompras", "NumeroDocumento", "dbo.Compras");
            DropIndex("dbo.DetalleCompras", new[] { "CodigoProducto" });
            DropIndex("dbo.DetalleCompras", new[] { "NumeroDocumento" });
            DropTable("dbo.DetalleCompras");
        }
    }
}
