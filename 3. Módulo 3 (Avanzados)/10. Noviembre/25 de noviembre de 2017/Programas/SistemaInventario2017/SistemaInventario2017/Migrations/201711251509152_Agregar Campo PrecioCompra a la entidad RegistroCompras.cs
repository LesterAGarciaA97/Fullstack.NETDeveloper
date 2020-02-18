namespace SistemaInventario2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarCampoPrecioCompraalaentidadRegistroCompras : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegistroCompras", "PrecioCompra", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegistroCompras", "PrecioCompra");
        }
    }
}
