namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attBanco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cachorro", "Peso", c => c.Double(nullable: false));
            DropColumn("dbo.Cachorro", "Pesoa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cachorro", "Pesoa", c => c.Double(nullable: false));
            DropColumn("dbo.Cachorro", "Peso");
        }
    }
}
