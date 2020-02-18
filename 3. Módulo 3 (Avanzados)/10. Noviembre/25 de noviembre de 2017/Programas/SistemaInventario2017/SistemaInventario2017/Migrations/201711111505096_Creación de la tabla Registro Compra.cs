namespace SistemaInventario2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacióndelatablaRegistroCompra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistroCompras",
                c => new
                    {
                        CodigoRegistro = c.Int(nullable: false, identity: true),
                        NombreUsuario = c.String(),
                        CodigoProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoRegistro)
                .ForeignKey("dbo.Productos", t => t.CodigoProducto, cascadeDelete: true)
                .Index(t => t.CodigoProducto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroCompras", "CodigoProducto", "dbo.Productos");
            DropIndex("dbo.RegistroCompras", new[] { "CodigoProducto" });
            DropTable("dbo.RegistroCompras");
        }
    }
}
