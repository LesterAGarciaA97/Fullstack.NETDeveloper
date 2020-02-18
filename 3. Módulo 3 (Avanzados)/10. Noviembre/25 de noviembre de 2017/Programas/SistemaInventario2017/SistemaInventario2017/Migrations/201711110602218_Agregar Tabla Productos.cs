namespace SistemaInventario2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTablaProductos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        CodigoProducto = c.Int(nullable: false, identity: true),
                        CodigoCategoria = c.Int(nullable: false),
                        CodigoTipoEmpaque = c.Int(nullable: false),
                        Descripcion = c.String(),
                        PrecioUnitario = c.Decimal(precision: 18, scale: 2),
                        PrecioPorDocena = c.Decimal(precision: 18, scale: 2),
                        PrecioPorMayor = c.Decimal(precision: 18, scale: 2),
                        Existencia = c.Int(),
                        imagen = c.String(),
                    })
                .PrimaryKey(t => t.CodigoProducto)
                .ForeignKey("dbo.Categoria", t => t.CodigoCategoria, cascadeDelete: true)
                .ForeignKey("dbo.TipoEmpaque", t => t.CodigoTipoEmpaque, cascadeDelete: true)
                .Index(t => t.CodigoCategoria)
                .Index(t => t.CodigoTipoEmpaque);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "CodigoTipoEmpaque", "dbo.TipoEmpaque");
            DropForeignKey("dbo.Productos", "CodigoCategoria", "dbo.Categoria");
            DropIndex("dbo.Productos", new[] { "CodigoTipoEmpaque" });
            DropIndex("dbo.Productos", new[] { "CodigoCategoria" });
            DropTable("dbo.Productos");
        }
    }
}
