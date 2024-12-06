namespace Filmes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterFilmeInAvaliacaoToFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Filmes", "Avaliacao", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Filmes", "Avaliacao", c => c.String(nullable: false));
        }
    }
}
