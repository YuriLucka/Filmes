namespace Filmes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Filmes", "Avaliacao", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Filmes", "Avaliacao", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
