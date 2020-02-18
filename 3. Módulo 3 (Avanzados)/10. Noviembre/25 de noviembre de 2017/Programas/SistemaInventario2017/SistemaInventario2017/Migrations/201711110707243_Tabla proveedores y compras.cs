namespace SistemaInventario2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablaproveedoresycompras : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        NumeroDocumento = c.Int(nullable: false),
                        CodigoProveedor = c.Int(nullable: false),
                        NombreUsuario = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        TotalCompra = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.NumeroDocumento)
                .ForeignKey("dbo.Proveedores", t => t.CodigoProveedor, cascadeDelete: true)
                .Index(t => t.CodigoProveedor);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        CodigoProveedor = c.Int(nullable: false, identity: true),
                        Nit = c.String(nullable: false),
                        RazonSocial = c.String(nullable: false),
                        PaginaWeb = c.String(),
                        ContactoPrincipal = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoProveedor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "CodigoProveedor", "dbo.Proveedores");
            DropIndex("dbo.Compras", new[] { "CodigoProveedor" });
            DropTable("dbo.Proveedores");
            DropTable("dbo.Compras");
        }
    }
}
