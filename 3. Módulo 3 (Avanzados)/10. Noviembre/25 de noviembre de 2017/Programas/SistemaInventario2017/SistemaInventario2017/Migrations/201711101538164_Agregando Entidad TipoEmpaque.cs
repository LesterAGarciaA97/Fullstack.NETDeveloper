namespace SistemaInventario2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoEntidadTipoEmpaque : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoEmpaque",
                c => new
                    {
                        CodigoTipoEmpaque = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoTipoEmpaque);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoEmpaque");
        }
    }
}
