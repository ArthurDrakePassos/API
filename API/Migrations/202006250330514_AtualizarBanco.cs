namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizarBanco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cachorro", "IdUsuario", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cachorro", "IdUsuario");
        }
    }
}
